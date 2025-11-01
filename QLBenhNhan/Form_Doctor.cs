using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace QLBenhNhan
{
    public partial class Form_Doctor : Form
    {
        SqlConnection conn;
        SqlDataAdapter daBacsi;
        SqlDataAdapter daChuyenkhoa;
        SqlCommandBuilder cbBacSi;
        SqlCommandBuilder cbChuyenKhoa;
        DataSet ds = new DataSet();
        bool isAdding = false;
        bool Edit = false;
        public Form_Doctor()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }


        private void Form_Doctor_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["QLBNConn"].ConnectionString;
            conn = new SqlConnection(connStr);

            // Dữ liệu combobox ChuyenKhoa 
            string sQueryChuyenKhoa = @"select * from ChuyenKhoa";
            daChuyenkhoa = new SqlDataAdapter(sQueryChuyenKhoa, conn);
            cbChuyenKhoa = new SqlCommandBuilder(daChuyenkhoa);
            daChuyenkhoa.Fill(ds, "tblDSChuyenKhoa");

            cboChuyenKhoa.DataSource = ds.Tables["tblDSChuyenKhoa"];
            cboChuyenKhoa.DisplayMember = "TenChuyenKhoa";
            cboChuyenKhoa.ValueMember = "ChuyenKhoaID";

            // Dữ liệu datagrid Danh sách nhân viên 
            string sQueryBacSi = @"select n.*, c.TenChuyenKhoa from BacSi n, ChuyenKhoa c where 
                                        n.ChuyenKhoaID = c.ChuyenKhoaID";
            daBacsi = new SqlDataAdapter(sQueryBacSi, conn);
            daBacsi.Fill(ds, "tblDSBacSi");

            // ✅ Gán khóa chính cho DataTable Bác sĩ
            DataTable tblBacSi = ds.Tables["tblDSBacSi"];
            tblBacSi.PrimaryKey = new DataColumn[] { tblBacSi.Columns["BacSiID"] };

            DgViewBacSi.DataSource = ds.Tables["tblDSBacSi"];
            DgViewBacSi.Columns["ChuyenKhoaID"].Visible = false;

            // Khi load form các txtbox và combobox bị disable
            txtIDBacSi.Enabled = false;
            txtHoTen.Enabled = false;
            txtSĐT.Enabled = false;
            txtEmail.Enabled = false;
            txtTrinhDo.Enabled = false;
            cboChuyenKhoa.Enabled = false;

            // Button Lưu và Hủy bị disable
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

        }
        // Load lại dữ liệu bác sĩ
        private void LoadBacSi()
        {
            try
            {
                ds.Tables["tblDSBacSi"].Clear(); // Xóa dữ liệu cũ trong DataSet
                daBacsi.Fill(ds, "tblDSBacSi"); // Nạp lại dữ liệu từ SQL
                DgViewBacSi.DataSource = ds.Tables["tblDSBacSi"]; // Hiển thị lại

                if (ds.Tables["tblDSBacSi"].Rows.Count > 0)
                {
                    DgViewBacSi.Rows[0].Selected = true;
                    DgViewBacSi_SelectionChanged(null, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách bác sĩ: " + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgViewBacSi_SelectionChanged(object sender, EventArgs e)
        {
            if (DgViewBacSi.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DgViewBacSi.SelectedRows[0];

                txtIDBacSi.Text = row.Cells["colBacSiID"].Value?.ToString();
                txtHoTen.Text = row.Cells["colHoTen"].Value?.ToString();
                txtSĐT.Text = row.Cells["colSDT"].Value?.ToString();
                txtEmail.Text = row.Cells["colEmail"].Value?.ToString();
                txtTrinhDo.Text = row.Cells["colTrinhDo"].Value?.ToString();

                // ✅ Lấy ChuyenKhoaID ẩn (có trong kết quả JOIN)
                string maChuyenKhoa = row.Cells["ChuyenKhoaID"].Value?.ToString();
                if (!string.IsNullOrEmpty(maChuyenKhoa))
                {
                    cboChuyenKhoa.SelectedValue = maChuyenKhoa; // Đúng cách khi combobox có ValueMember là ChuyenKhoaID
                }
            }
        }

        
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text.Trim() == "")
            {
                LoadBacSi();
                return;
            }

            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["QLBNConn"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    // ✅ Tìm kiếm và JOIN với bảng ChuyenKhoa để lấy tên chuyên khoa
                    string query = @"SELECT b.BacSiID,b.HoTen, b.SDT, b.Email, b.TrinhDo, b.ChuyenKhoaID, c.TenChuyenKhoa
                                    FROM BacSi b
                                    JOIN ChuyenKhoa c ON b.ChuyenKhoaID = c.ChuyenKhoaID
                                    WHERE b.BacSiID LIKE @TuKhoa 
                                       OR b.HoTen LIKE @TuKhoa 
                                       OR b.TrinhDo LIKE @TuKhoa";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TuKhoa", "%" + txtTim.Text.Trim() + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            DgViewBacSi.DataSource = dt;

                            // Ẩn cột ChuyenKhoaID, đặt tên cột TenChuyenKhoa
                            if (DgViewBacSi.Columns["ChuyenKhoaID"] != null)
                                DgViewBacSi.Columns["ChuyenKhoaID"].Visible = false;
                            if (DgViewBacSi.Columns["TenChuyenKhoa"] != null)
                                DgViewBacSi.Columns["TenChuyenKhoa"].HeaderText = "Chuyên khoa";

                            // Chọn dòng đầu tiên
                            if (DgViewBacSi.Rows.Count > 0)
                            {
                                DgViewBacSi.Rows[0].Selected = true;
                                DgViewBacSi_SelectionChanged(null, new EventArgs());
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không thấy bác sĩ cần tìm!",
                                            "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBacSi();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Bật button
            btnHuy.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!isAdding)
            {
                isAdding = true;
                btnThem.Text = "Xác nhận";

                txtIDBacSi.Enabled = true;
                txtHoTen.Enabled = true;
                txtSĐT.Enabled = true;
                txtEmail.Enabled = true;
                txtTrinhDo.Enabled = true;
                cboChuyenKhoa.Enabled = true;

                btnHuy.Enabled = true;
                btnLuu.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThoat.Enabled = true;

                txtIDBacSi.Clear();
                txtHoTen.Clear();
                txtSĐT.Clear();
                txtEmail.Clear();
                txtTrinhDo.Clear();
                cboChuyenKhoa.Text = "";
            }
            else
            {
                // ================== KIỂM TRA DỮ LIỆU ==================
                if (txtIDBacSi.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã bác sĩ!", "Thông báo");
                    txtIDBacSi.Focus();
                    return;
                }
                if (txtHoTen.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập họ tên bác sĩ!", "Thông báo");
                    txtHoTen.Focus();
                    return;
                }
                if (txtSĐT.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo");
                    txtSĐT.Focus();
                    return;
                }
                if (txtEmail.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập email!", "Thông báo");
                    txtEmail.Focus();
                    return;
                }
                if (txtTrinhDo.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập trình độ!", "Thông báo");
                    txtTrinhDo.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(cboChuyenKhoa.Text))
                {
                    MessageBox.Show("Vui lòng nhập hoặc chọn chuyên khoa!", "Thông báo");
                    cboChuyenKhoa.Focus();
                    return;
                }

                DataTable tblBacSi = ds.Tables["tblDSBacSi"];
                if (tblBacSi.Rows.Find(txtIDBacSi.Text) != null)
                {
                    MessageBox.Show("Mã bác sĩ đã tồn tại!", "Trùng ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIDBacSi.Focus();
                    return;
                }

                // ================== XỬ LÝ CHUYÊN KHOA ==================
                string tenChuyenKhoa = cboChuyenKhoa.Text.Trim();
                string maChuyenKhoa = null;

                // Tìm chuyên khoa trong bảng có sẵn
                DataTable tblChuyenKhoa = ds.Tables["tblDSChuyenKhoa"];
                DataRow[] foundRows = tblChuyenKhoa.Select($"TenChuyenKhoa = '{tenChuyenKhoa.Replace("'", "''")}'");

                if (foundRows.Length > 0)
                {
                    // Đã có chuyên khoa
                    maChuyenKhoa = foundRows[0]["ChuyenKhoaID"].ToString();
                }
                else
                {
                    // Chưa có → thêm mới chuyên khoa
                    maChuyenKhoa = "CK" + (tblChuyenKhoa.Rows.Count + 1).ToString("000");
                    DataRow newKhoa = tblChuyenKhoa.NewRow();
                    newKhoa["ChuyenKhoaID"] = maChuyenKhoa;
                    newKhoa["TenChuyenKhoa"] = tenChuyenKhoa;
                    tblChuyenKhoa.Rows.Add(newKhoa);

                    // Cập nhật luôn xuống SQL
                    SqlCommandBuilder cbChuyenKhoa = new SqlCommandBuilder(daChuyenkhoa);
                    daChuyenkhoa.Update(tblChuyenKhoa);
                }

                // ================== THÊM BÁC SĨ ==================
                DataRow newRow = tblBacSi.NewRow();
                newRow["BacSiID"] = txtIDBacSi.Text;
                newRow["HoTen"] = txtHoTen.Text;
                newRow["SDT"] = txtSĐT.Text;
                newRow["Email"] = txtEmail.Text;
                newRow["TrinhDo"] = txtTrinhDo.Text;
                newRow["ChuyenKhoaID"] = maChuyenKhoa;
                newRow["TenChuyenKhoa"] = tenChuyenKhoa;
                tblBacSi.Rows.Add(newRow);

                ds.Tables["tblDSBacSi"].PrimaryKey = new DataColumn[] { ds.Tables["tblDSBacSi"].Columns["BacSiID"] };


                MessageBox.Show("Thêm bác sĩ thành công!", "Thông báo");

                // Reset trạng thái
                isAdding = false;
                btnThem.Text = "Thêm";
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtIDBacSi.Enabled = true;
            txtHoTen.Enabled = true;
            txtSĐT.Enabled = true;
            txtEmail.Enabled = true;
            txtTrinhDo.Enabled = true;
            cboChuyenKhoa.Enabled = true;

            if (!Edit)
            {
                // Lần nhấn 1: bật chế độ sửa
                if (string.IsNullOrEmpty(txtIDBacSi.Text))
                {
                    MessageBox.Show("Vui lòng chọn bác sĩ cần sửa!", "Thông báo");
                    return;
                }

                Edit = true;
                btnSua.Text = "Xác nhận";
                txtIDBacSi.Enabled = false; // Không sửa ID
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                // Lần nhấn 2: xác nhận sửa
                if (txtIDBacSi.Text == "" || txtHoTen.Text == "" || txtSĐT.Text == "" || txtEmail.Text == "" || txtTrinhDo.Text == "" || cboChuyenKhoa.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                    return;
                }

                DataRow row = ds.Tables["tblDSBacSi"].Rows.Find(txtIDBacSi.Text);
                if (row != null)
                {
                    row["BacSiID"] = txtIDBacSi.Text;
                    row["HoTen"] = txtHoTen.Text;
                    row["SDT"] = txtSĐT.Text;
                    row["Email"] = txtEmail.Text;
                    row["TrinhDo"] = txtTrinhDo.Text;
                    row["ChuyenKhoaID"] = cboChuyenKhoa.SelectedValue.ToString();

                    DgViewBacSi.DataSource = ds.Tables["tblDSBacSi"];
                    MessageBox.Show("Cập nhật thông tin bác sĩ thành công!", "Thông báo");
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                }

                // Reset trạng thái
                Edit = false;
                btnSua.Text = "Sửa";
                btnHuy.Enabled = true;
                btnLuu.Enabled = true;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDBacSi.Text))
            {
                MessageBox.Show("Vui lòng chọn bác sĩ cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maBS = txtIDBacSi.Text;

            DialogResult dr = MessageBox.Show(
                $"Bạn có chắc muốn xóa Khoa có mã '{maBS}' không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dr == DialogResult.Yes)
            {
                ds.Tables["tblDSBacSi"].PrimaryKey = new DataColumn[]
                {
            ds.Tables["tblDSBacSi"].Columns["BacSiID"]
                };

                DataRow row = ds.Tables["tblDSBacSi"].Rows.Find(maBS);
                if (row != null)
                {
                    row.Delete();
                    MessageBox.Show("Đã xóa bác sĩ khỏi danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bác sĩ cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Hủy trạng thái Thêm hoặc Sửa
            if (isAdding)
            {
                isAdding = false;
                btnThem.Text = "Thêm";
            }
            else if (Edit)
            {
                Edit = false;
                btnSua.Text = "Sửa";
            }

            // Reset các textbox và control
            txtIDBacSi.Clear();
            txtHoTen.Clear();
            txtSĐT.Clear();
            txtEmail.Clear();
            txtTrinhDo.Clear();
            // reset combobox chuyên khoa về trạng thái ban đầu là có dữ liệu chứ không phải rỗng
            cboChuyenKhoa.SelectedIndex = -1;
            // Enable các textbox
            txtIDBacSi.Enabled = false;
            txtHoTen.Enabled = false;
            txtSĐT.Enabled = false;
            txtEmail.Enabled = false;
            txtTrinhDo.Enabled = false;
            cboChuyenKhoa.Enabled = false;
            // Disable các combobox
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;


            // Làm mới dữ liệu từ database
            ds.Tables["tblDSBacSi"].Clear();
            daBacsi.Fill(ds, "tblDSBacSi");
            DgViewBacSi.DataSource = ds.Tables["tblDSBacSi"];

            if (ds.Tables["tblDSBacSi"].Rows.Count > 0)
            {
                DgViewBacSi.Rows[0].Selected = true;
                DgViewBacSi_SelectionChanged(null, new EventArgs());
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable tbl = ds.Tables["tblDSBacSi"];

            if (string.IsNullOrWhiteSpace(txtIDBacSi.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bác sĩ!");
                return;
            }

            if (isAdding)
            {
                if (tbl.Rows.Find(txtIDBacSi.Text) != null)
                {
                    MessageBox.Show("Mã bác sĩ đã tồn tại!");
                    return;
                }

                DataRow newRow = tbl.NewRow();
                newRow["BacSiID"] = txtIDBacSi.Text;
                newRow["HoTen"] = txtHoTen.Text;
                newRow["SDT"] = txtSĐT.Text;
                newRow["Email"] = txtEmail.Text;
                newRow["TrinhDo"] = txtTrinhDo.Text;
                newRow["ChuyenKhoaID"] = cboChuyenKhoa.SelectedValue.ToString();
                newRow["TenChuyenKhoa"] = cboChuyenKhoa.Text;
                tbl.Rows.Add(newRow);
            }
            else
            {
                DataRow row = tbl.Rows.Find(txtIDBacSi.Text);
                if (row != null)
                {
                    row["HoTen"] = txtHoTen.Text;
                    row["SDT"] = txtSĐT.Text;
                    row["Email"] = txtEmail.Text;
                    row["TrinhDo"] = txtTrinhDo.Text;
                    row["ChuyenKhoaID"] = cboChuyenKhoa.SelectedValue.ToString();
                    row["TenChuyenKhoa"] = cboChuyenKhoa.Text;

                }
            }

            using (SqlDataAdapter daSave = new SqlDataAdapter("SELECT * FROM BacSi", conn))
            {
                SqlCommandBuilder cbSave = new SqlCommandBuilder(daSave);
                daSave.Update(ds.Tables["tblDSBacSi"]);
            }

            MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // reset trạng thái
            txtIDBacSi.Clear();
            txtHoTen.Clear();
            txtSĐT.Clear();
            txtEmail.Clear();
            txtTrinhDo.Clear();
            cboChuyenKhoa.Text = "";
            // bật lại Button
            btnThem.Enabled = true;
            btnXoa.Enabled = true;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Đóng form
            this.Close();
        }
    }
}
