using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace QLBenhNhan
{
    public partial class Form_Khoa : Form
    {
        SqlConnection conn;
        SqlDataAdapter daKhoa;
        SqlCommandBuilder cb;
        DataSet ds = new DataSet();
        bool isAdding = false;
        bool Edit = false;

        public Form_Khoa()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        // ==========================
        // FORM LOAD
        // ==========================
        private void Form_Khoa_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["QLBNConn"].ConnectionString;
            conn = new SqlConnection(connStr);

            string sql = "SELECT * FROM ChuyenKhoa";
            daKhoa = new SqlDataAdapter(sql, conn);
            cb = new SqlCommandBuilder(daKhoa);

            daKhoa.Fill(ds, "ChuyenKhoa");

            // ✅ Đặt khóa chính đúng với tên cột trong DB
            ds.Tables["ChuyenKhoa"].PrimaryKey = new DataColumn[]
            {
                ds.Tables["ChuyenKhoa"].Columns["ChuyenKhoaID"]
            };

            dgvKhoa.AutoGenerateColumns = false;
            dgvKhoa.DataSource = ds.Tables["ChuyenKhoa"];

            Button(true);
            txtChuyenKhoaID.Enabled = false;
            txtTenChuyenKhoa.Enabled = false;
            txtMoTa.Enabled = false;
        }
        private void LoadBenhNhan()
        {
            try
            {
                ds.Tables["ChuyenKhoa"].Clear(); // Xóa dữ liệu cũ trong DataSet
                daKhoa.Fill(ds, "ChuyenKhoa"); // Nạp lại dữ liệu từ SQL
                dgvKhoa.DataSource = ds.Tables["ChuyenKhoa"]; // Hiển thị lại

                if (ds.Tables["ChuyenKhoa"].Rows.Count > 0)
                {
                    dgvKhoa.Rows[0].Selected = true;
                    dgvKhoa_SelectionChanged(null, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách khoa: " + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================
        // HÀM QUẢN LÝ NÚT
        // ==========================
        private void Button(bool status)
        {
            btnThem.Enabled = status;
            btnSua.Enabled = status;
            btnXoa.Enabled = status;
            btnLuu.Enabled = !status;
            btnHuy.Enabled = !status;
        }

        // ==========================
        // CLICK TRONG DATAGRIDVIEW
        // ==========================
        private void dgvKhoa_Click(object sender, EventArgs e)
        {
            if (dgvKhoa.SelectedRows.Count > 0)
            {
                txtChuyenKhoaID.Text = dgvKhoa.SelectedRows[0].Cells["ChuyenKhoaID"].Value?.ToString();
                txtTenChuyenKhoa.Text = dgvKhoa.SelectedRows[0].Cells["TenChuyenKhoa"].Value?.ToString();
                txtMoTa.Text = dgvKhoa.SelectedRows[0].Cells["MoTa"].Value?.ToString();
            }
        }


        // ==========================
        // NÚT THÊM
        // ==========================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!isAdding)
            {
                isAdding = true;
                btnThem.Text = "Xác nhận";

                txtChuyenKhoaID.Enabled = true;
                txtTenChuyenKhoa.Enabled = true;
                txtMoTa.Enabled = true;

                btnHuy.Enabled = true;
                btnLuu.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThoat.Enabled = true;

                txtChuyenKhoaID.Clear();
                txtTenChuyenKhoa.Clear();
                txtMoTa.Clear();
                txtChuyenKhoaID.Focus();
            }
            else
            {
                if (txtChuyenKhoaID.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã khoa!", "Thông báo");
                    txtChuyenKhoaID.Focus();
                    return;
                }
                if (txtTenChuyenKhoa.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên khoa!", "Thông báo");
                    txtTenChuyenKhoa.Focus();
                    return;
                }

                if (ds.Tables["ChuyenKhoa"].Rows.Find(txtChuyenKhoaID.Text) != null)
                {
                    MessageBox.Show("Mã Khoa đã tồn tại!", "Trùng ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtChuyenKhoaID.Focus();
                    return;
                }

                DataRow row = ds.Tables["ChuyenKhoa"].NewRow();
                row["ChuyenKhoaID"] = txtChuyenKhoaID.Text;
                row["TenChuyenKhoa"] = txtTenChuyenKhoa.Text;
                row["MoTa"] = txtMoTa.Text;

                ds.Tables["ChuyenKhoa"].Rows.Add(row);
                dgvKhoa.DataSource = ds.Tables["ChuyenKhoa"];

                MessageBox.Show("Thêm khoa thành công!", "Thông báo");

                isAdding = false;
                btnThem.Text = "Thêm";
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtChuyenKhoaID.Clear();
                txtTenChuyenKhoa.Clear();
                txtMoTa.Clear();
            }
        }

        // ==========================
        // CHỌN DÒNG TRONG DGV
        // ==========================
        private void dgvKhoa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhoa.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvKhoa.SelectedRows[0];
                txtChuyenKhoaID.Text = row.Cells[0].Value?.ToString();
                txtTenChuyenKhoa.Text = row.Cells[1].Value?.ToString();
                txtMoTa.Text = row.Cells[2].Value?.ToString();
            }
        }


        // ==========================
        // NÚT XÓA
        // ==========================

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtChuyenKhoaID.Text))
            {
                MessageBox.Show("Vui lòng chọn khoa cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maChuyenKhoa = txtChuyenKhoaID.Text;

            DialogResult dr = MessageBox.Show(
                $"Bạn có chắc muốn xóa Khoa có mã '{maChuyenKhoa}' không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dr == DialogResult.Yes)
            {
                ds.Tables["ChuyenKhoa"].PrimaryKey = new DataColumn[]
                {
                    ds.Tables["ChuyenKhoa"].Columns["ChuyenKhoaID"]
                };

                DataRow row = ds.Tables["ChuyenKhoa"].Rows.Find(maChuyenKhoa);
                if (row != null)
                {
                    row.Delete();
                    MessageBox.Show("Đã xóa Khoa khỏi danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khoa cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
        }

        // ==========================
        // NÚT LƯU
        // ==========================

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable tbl = ds.Tables["ChuyenKhoa"];

            if (string.IsNullOrWhiteSpace(txtChuyenKhoaID.Text) || string.IsNullOrWhiteSpace(txtTenChuyenKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin Khoa!");
                return;
            }

            if (isAdding)
            {
                if (tbl.Rows.Find(txtChuyenKhoaID.Text) != null)
                {
                    MessageBox.Show("Mã Khoa đã tồn tại!");
                    return;
                }

                DataRow newRow = tbl.NewRow();
                newRow["ChuyenKhoaID"] = txtChuyenKhoaID.Text;
                newRow["TenChuyenKhoa"] = txtTenChuyenKhoa.Text;
                newRow["MoTa"] = txtMoTa.Text;
                tbl.Rows.Add(newRow);
            }
            else
            {
                DataRow row = tbl.Rows.Find(txtChuyenKhoaID.Text);
                if (row != null)
                {
                    row["TenChuyenKhoa"] = txtTenChuyenKhoa.Text;
                    row["MoTa"] = txtMoTa.Text;
                }
            }

            daKhoa.Update(ds, "ChuyenKhoa");
            MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtChuyenKhoaID.Clear();
            txtTenChuyenKhoa.Clear();
            txtMoTa.Clear();
        }
        // ==========================
        // NÚT SỬA
        // ==========================
        private void btnSua_Click(object sender, EventArgs e)
        {
            txtChuyenKhoaID.Enabled = true;
            txtTenChuyenKhoa.Enabled = true;
            txtMoTa.Enabled = true;

            if (!Edit)
            {
                // Lần nhấn 1: bật chế độ sửa
                if (string.IsNullOrEmpty(txtChuyenKhoaID.Text))
                {
                    MessageBox.Show("Vui lòng chọn khoa cần sửa!", "Thông báo");
                    return;
                }

                Edit = true;
                btnSua.Text = "Xác nhận";
                txtChuyenKhoaID.Enabled = false; // Không sửa ID
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
            }
            else
            {
                // Lần nhấn 2: xác nhận sửa
                if (txtChuyenKhoaID.Text == "" || txtTenChuyenKhoa.Text == "" || txtMoTa.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                    return;
                }

                DataRow row = ds.Tables["ChuyenKhoa"].Rows.Find(txtChuyenKhoaID.Text);
                if (row != null)
                {
                    row["ChuyenKhoaID"] = txtChuyenKhoaID.Text;
                    row["TenChuyenKhoa"] = txtTenChuyenKhoa.Text;
                    row["MoTa"] = txtMoTa.Text;

                    dgvKhoa.DataSource = ds.Tables["ChuyenKhoa"];
                    MessageBox.Show("Cập nhật thông tin khoa thành công!", "Thông báo");
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                    txtChuyenKhoaID.Clear();
                    txtTenChuyenKhoa.Clear();
                    txtMoTa.Clear();
                }

                // Reset trạng thái
                Edit = false;
                btnSua.Text = "Sửa";
                btnHuy.Enabled = true;
                btnLuu.Enabled = true;
            }
        }

        // ==========================
        // NÚT HỦY
        // ==========================
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
            txtChuyenKhoaID.Clear();
            txtTenChuyenKhoa.Clear();
            txtMoTa.Clear();
            

            // Làm mới dữ liệu từ database
            ds.Tables["ChuyenKhoa"].Clear();
            daKhoa.Fill(ds, "ChuyenKhoa");
            dgvKhoa.DataSource = ds.Tables["ChuyenKhoa"];

            if (ds.Tables["ChuyenKhoa"].Rows.Count > 0)
            {
                dgvKhoa.Rows[0].Selected = true;
                dgvKhoa_SelectionChanged(null, new EventArgs());
            }
        }

        // ==========================
        // NÚT THOÁT
        // ==========================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text.Trim() == "")
            {
                LoadBenhNhan();
                return;
            }
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["QLBNConn"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    // 🧠 Câu lệnh tìm kiếm theo họ tên hoặc CCCD
                    string query = "SELECT * FROM ChuyenKhoa " +
                                    "WHERE ChuyenKhoaID LIKE @TuKhoa OR TenChuyenKhoa LIKE @TuKhoa";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TuKhoa", "%" + txtTim.Text.Trim() + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dgvKhoa.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khoa nào phù hợp!",
                                            "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBenhNhan();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
