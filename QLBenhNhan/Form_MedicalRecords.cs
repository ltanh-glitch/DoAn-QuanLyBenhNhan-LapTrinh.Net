using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLBenhNhan
{
    public partial class Form_MedicalRecords : Form
    {
        // Constructor
        SqlConnection conn;
        SqlDataAdapter daHSBA;
        SqlDataAdapter daBenhNhan;
        SqlCommandBuilder cbHSBA;
        SqlCommandBuilder cbBenhNhan;
        DataSet ds = new DataSet();
        bool isAdding = false;
        bool Edit = false;
        public Form_MedicalRecords()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form_MedicalRecords_Load(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Kết nối CSDL
                string connStr = ConfigurationManager.ConnectionStrings["QLBNConn"].ConnectionString;
                conn = new SqlConnection(connStr);

                // 2️⃣ Truy vấn dữ liệu Hồ sơ bệnh án + tên bệnh nhân
                string sQueryHoSo = @"SELECT h.*, b.HoTen AS TenBenhNhan
                                        FROM HoSoBenhAn h
                                        LEFT JOIN BenhNhan b ON h.BenhNhanID = b.BenhNhanID";


                daHSBA = new SqlDataAdapter(sQueryHoSo, conn);
                daHSBA.Fill(ds, "tblDSHoSoBenhAn");

                // 3️⃣ Load dữ liệu Bệnh nhân để tra cứu
                string sQueryBenhNhan = "SELECT * FROM BenhNhan";
                daBenhNhan = new SqlDataAdapter(sQueryBenhNhan, conn);
                daBenhNhan.Fill(ds, "tblDSBenhNhan");

                // 4️⃣ Đặt khóa chính cho bảng Hồ Sơ
                DataTable tblHoSo = ds.Tables["tblDSHoSoBenhAn"];
                tblHoSo.PrimaryKey = new DataColumn[] { tblHoSo.Columns["HoSoID"] };
                // ⚙ Đặt khóa chính cho bảng BenhNhan để dùng Rows.Find()
                DataTable tblBenhNhan = ds.Tables["tblDSBenhNhan"];
                tblBenhNhan.PrimaryKey = new DataColumn[] { tblBenhNhan.Columns["BenhNhanID"] };

                // 5️⃣ Hiển thị dữ liệu lên DataGridView
                DgViewHoSoBenhAn.DataSource = tblHoSo;
                DgViewHoSoBenhAn.Columns["TenBenhNhan"].HeaderText = "Họ Tên";
                // đưa cột Họ tên lên vị trí thứ 3
                DgViewHoSoBenhAn.Columns["TenBenhNhan"].DisplayIndex = 2;


                // 6️⃣ Khi load form, disable các TextBox, DateTimePicker
                txtIDHoSoBenhAn.Enabled = false;
                txtIDBenhNhan.Enabled = false;
                dateTimePickerNgayLap.Enabled = false;
                txtChuanDoan.Enabled = false;
                txtTrieuChung.Enabled = false;
                txtTienSuBenh.Enabled = false;
                txtGhiChu.Enabled = false;

                // 7️⃣ Disable các nút Lưu và Hủy
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi load dữ liệu hồ sơ bệnh án: " + ex.Message);
            }

        }

        private void DgViewHoSoBenhAn_SelectionChanged(object sender, EventArgs e)
        {
            if (DgViewHoSoBenhAn.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DgViewHoSoBenhAn.SelectedRows[0];

                txtIDHoSoBenhAn.Text = row.Cells["colHoSoID"].Value?.ToString();
                txtIDBenhNhan.Text = row.Cells["colBenhNhanID"].Value?.ToString();
                if (row.Cells["colNgayLap"].Value != DBNull.Value)
                    dateTimePickerNgayLap.Value = Convert.ToDateTime(row.Cells["colNgayLap"].Value);
                txtChuanDoan.Text = row.Cells["colChuanDoan"].Value?.ToString();
                txtTrieuChung.Text = row.Cells["colTrieuChung"].Value?.ToString();
                txtTienSuBenh.Text = row.Cells["colTienSuBenh"].Value?.ToString();
                txtGhiChu.Text = row.Cells["colGhiChu"].Value?.ToString();
            }
        }

        

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text.Trim() == "")
            {
                // Nếu không nhập gì -> Load lại toàn bộ
                LoadHoSoBenhAn();
                return;
            }

            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["QLBNConn"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    h.HoSoID,
                    h.BenhNhanID,
                    b.HoTen AS TenBenhNhan,
                    h.NgayLap,
                    h.ChuanDoan,
                    h.TrieuChung,
                    h.TienSuBenh,
                    h.GhiChu
                FROM HoSoBenhAn h
                LEFT JOIN BenhNhan b ON h.BenhNhanID = b.BenhNhanID
                WHERE 
                    b.HoTen LIKE @TuKhoa OR 
                    h.BenhNhanID LIKE @TuKhoa";

                    SqlDataAdapter daTim = new SqlDataAdapter(query, conn);
                    daTim.SelectCommand.Parameters.AddWithValue("@TuKhoa", "%" + txtTim.Text.Trim() + "%");

                    ds.Tables["tblDSHoSoBenhAn"].Clear();
                    daTim.Fill(ds, "tblDSHoSoBenhAn");

                    DgViewHoSoBenhAn.DataSource = ds.Tables["tblDSHoSoBenhAn"];

                    if (ds.Tables["tblDSHoSoBenhAn"].Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy hồ sơ bệnh án phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadHoSoBenhAn()
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["QLBNConn"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sQuery = @"
                SELECT 
                    h.HoSoID,
                    h.BenhNhanID,
                    b.HoTen AS TenBenhNhan,
                    h.NgayLap,
                    h.ChuanDoan,
                    h.TrieuChung,
                    h.TienSuBenh,
                    h.GhiChu
                FROM HoSoBenhAn h
                LEFT JOIN BenhNhan b ON h.BenhNhanID = b.BenhNhanID";

                    daHSBA = new SqlDataAdapter(sQuery, conn);
                    cbHSBA = new SqlCommandBuilder(daHSBA);

                    ds.Tables["tblDSHoSoBenhAn"].Clear();
                    daHSBA.Fill(ds, "tblDSHoSoBenhAn");
                    DgViewHoSoBenhAn.DataSource = ds.Tables["tblDSHoSoBenhAn"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hồ sơ bệnh án: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable tblHoSo = ds.Tables["tblDSHoSoBenhAn"];

            if (!isAdding)
            {
                // ================= BẮT ĐẦU THÊM MỚI =================
                isAdding = true;
                btnThem.Text = "Xác nhận";

                // Enable nhập liệu
                txtIDHoSoBenhAn.Enabled = true;
                txtIDBenhNhan.Enabled = true;
                txtChuanDoan.Enabled = true;
                txtTrieuChung.Enabled = true;
                txtTienSuBenh.Enabled = true;
                txtGhiChu.Enabled = true;
                dateTimePickerNgayLap.Enabled = true;

                // Button điều khiển
                btnHuy.Enabled = true;
                btnLuu.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

                // Xóa trắng nội dung
                txtIDHoSoBenhAn.Clear();
                txtIDBenhNhan.Clear();
                txtChuanDoan.Clear();
                txtTrieuChung.Clear();
                txtTienSuBenh.Clear();
                txtGhiChu.Clear();
                dateTimePickerNgayLap.Value = DateTime.Now;
            }
            else
            {
                // ================= KIỂM TRA DỮ LIỆU =================
                if (string.IsNullOrWhiteSpace(txtIDHoSoBenhAn.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã hồ sơ!", "Thông báo");
                    txtIDHoSoBenhAn.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtIDBenhNhan.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã bệnh nhân!", "Thông báo");
                    txtIDBenhNhan.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtChuanDoan.Text))
                {
                    MessageBox.Show("Vui lòng nhập chẩn đoán!", "Thông báo");
                    txtChuanDoan.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtTrieuChung.Text))
                {
                    MessageBox.Show("Vui lòng nhập triệu chứng!", "Thông báo");
                    txtTrieuChung.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtTienSuBenh.Text))
                {
                    MessageBox.Show("Vui lòng nhập tiền sử bệnh!", "Thông báo");
                    txtTienSuBenh.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtGhiChu.Text))
                {
                    MessageBox.Show("Vui lòng nhập ghi chú!", "Thông báo");
                    txtGhiChu.Focus();
                    return;
                }
                if (dateTimePickerNgayLap.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày lập không được lớn hơn ngày hiện tại!", "Lỗi ngày lập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateTimePickerNgayLap.Focus();
                    return;
                }

                // Kiểm tra trùng ID hồ sơ
                if (tblHoSo.Rows.Find(txtIDHoSoBenhAn.Text) != null)
                {
                    MessageBox.Show("Mã hồ sơ đã tồn tại!", "Trùng ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIDHoSoBenhAn.Focus();
                    return;
                }

                // Kiểm tra mã bệnh nhân tồn tại
                DataTable tblBenhNhan = ds.Tables["tblDSBenhNhan"];
                if (tblBenhNhan.Rows.Find(txtIDBenhNhan.Text) == null)
                {
                    MessageBox.Show("Mã bệnh nhân không tồn tại!", "Lỗi mã bệnh nhân", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIDBenhNhan.Focus();
                    return;
                }

                // ================= THÊM HỒ SƠ BỆNH ÁN =================
                DataRow newRow = tblHoSo.NewRow();
                newRow["HoSoID"] = txtIDHoSoBenhAn.Text;
                newRow["BenhNhanID"] = txtIDBenhNhan.Text;

                // Lấy tên bệnh nhân tự động
                DataRow[] foundBN = tblBenhNhan.Select($"BenhNhanID = '{txtIDBenhNhan.Text}'");
                newRow["TenBenhNhan"] = (foundBN.Length > 0) ? foundBN[0]["HoTen"] : "";

                newRow["NgayLap"] = dateTimePickerNgayLap.Value.Date;
                newRow["ChuanDoan"] = txtChuanDoan.Text;
                newRow["TrieuChung"] = txtTrieuChung.Text;
                newRow["TienSuBenh"] = txtTienSuBenh.Text;
                newRow["GhiChu"] = txtGhiChu.Text;

                tblHoSo.Rows.Add(newRow);

                MessageBox.Show("Thêm hồ sơ bệnh án thành công!", "Thông báo");

                // ================= RESET TRẠNG THÁI =================
                isAdding = false;
                btnThem.Text = "Thêm";

                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                // Disable nhập liệu
                txtIDHoSoBenhAn.Enabled = false;
                txtIDBenhNhan.Enabled = false;
                txtChuanDoan.Enabled = false;
                txtTrieuChung.Enabled = false;
                txtTienSuBenh.Enabled = false;
                txtGhiChu.Enabled = false;
                dateTimePickerNgayLap.Enabled = false;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataTable tblHoSo = ds.Tables["tblDSHoSoBenhAn"];

            if (!Edit)
            {
                // 🟡 Lần 1: Nhấn "Sửa" để bật chế độ chỉnh sửa
                if (string.IsNullOrEmpty(txtIDHoSoBenhAn.Text))
                {
                    MessageBox.Show("Vui lòng chọn hồ sơ cần sửa!", "Thông báo");
                    return;
                }

                Edit = true;
                btnSua.Text = "Xác nhận";

                // 🔓 Chỉ bật các ô được phép sửa
                txtChuanDoan.Enabled = true;
                txtTrieuChung.Enabled = true;
                txtTienSuBenh.Enabled = true;
                txtGhiChu.Enabled = true;

                // 🔒 Khóa các ô không được sửa
                txtIDHoSoBenhAn.Enabled = false;
                txtIDBenhNhan.Enabled = false;
                dateTimePickerNgayLap.Enabled = false;

                // 🔧 Vô hiệu hóa các nút khác trong khi sửa
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
                btnHuy.Enabled = true;
            }
            else
            {
                // 🟢 Lần 2: Nhấn "Xác nhận" để lưu thay đổi vào DataSet
                if (string.IsNullOrWhiteSpace(txtChuanDoan.Text) ||
                    string.IsNullOrWhiteSpace(txtTrieuChung.Text) ||
                    string.IsNullOrWhiteSpace(txtTienSuBenh.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết!", "Thông báo");
                    return;
                }

                DataRow row = tblHoSo.Rows.Find(txtIDHoSoBenhAn.Text);
                if (row != null)
                {
                    row["ChuanDoan"] = txtChuanDoan.Text;
                    row["TrieuChung"] = txtTrieuChung.Text;
                    row["TienSuBenh"] = txtTienSuBenh.Text;
                    row["GhiChu"] = txtGhiChu.Text;

                    MessageBox.Show("Cập nhật hồ sơ bệnh án thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hồ sơ cần sửa!", "Lỗi");
                }

                // 🔁 Reset trạng thái
                Edit = false;
                btnSua.Text = "Sửa";

                // Khóa lại các ô nhập liệu
                txtChuanDoan.Enabled = false;
                txtTrieuChung.Enabled = false;
                txtTienSuBenh.Enabled = false;
                txtGhiChu.Enabled = false;

                // Bật lại các nút khác
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;

                // Refresh lại DataGridView
                DgViewHoSoBenhAn.Refresh();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn hồ sơ cần xóa chưa
            if (string.IsNullOrEmpty(txtIDHoSoBenhAn.Text))
            {
                MessageBox.Show("Vui lòng chọn hồ sơ cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maHS = txtIDHoSoBenhAn.Text;

            // Hỏi người dùng xác nhận xóa
            DialogResult dr = MessageBox.Show(
                $"Bạn có chắc muốn xóa hồ sơ bệnh án có mã '{maHS}' không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dr == DialogResult.Yes)
            {
                // Đảm bảo bảng có khóa chính trước khi dùng Rows.Find
                ds.Tables["tblDSHoSoBenhAn"].PrimaryKey = new DataColumn[]
                {
        ds.Tables["tblDSHoSoBenhAn"].Columns["HoSoID"]
                };

                // Tìm dòng cần xóa trong DataSet
                DataRow row = ds.Tables["tblDSHoSoBenhAn"].Rows.Find(maHS);
                if (row != null)
                {
                    row.Delete();
                    MessageBox.Show("Đã xóa hồ sơ bệnh án khỏi danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hồ sơ cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Cho phép lưu lại xuống CSDL
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

            // Reset các TextBox và DateTimePicker
            txtIDHoSoBenhAn.Clear();
            txtIDBenhNhan.Clear();
            txtChuanDoan.Clear();
            txtGhiChu.Clear();
            txtTienSuBenh.Clear();
            txtTrieuChung.Clear();
            dateTimePickerNgayLap.Value = DateTime.Now;


            // Khóa các TextBox & DateTimePicker
            txtIDHoSoBenhAn.Enabled = false;
            txtIDBenhNhan.Enabled = false;
            txtChuanDoan.Enabled = false;
            txtGhiChu.Enabled = false;
            txtTienSuBenh.Enabled = false;
            txtTrieuChung.Enabled = false;
            dateTimePickerNgayLap.Enabled = false;

            // Bật lại các nút chính
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            // Khóa nút Lưu và Hủy (vì không còn thao tác)
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            // Làm mới dữ liệu từ database
            ds.Tables["tblDSHoSoBenhAn"].Clear();
            daHSBA.Fill(ds, "tblDSHoSoBenhAn");
            DgViewHoSoBenhAn.DataSource = ds.Tables["tblDSHoSoBenhAn"];

            // Nếu có dữ liệu thì chọn dòng đầu tiên và hiển thị lên textbox
            if (ds.Tables["tblDSHoSoBenhAn"].Rows.Count > 0)
            {
                DgViewHoSoBenhAn.Rows[0].Selected = true;
                DgViewHoSoBenhAn_SelectionChanged(null, new EventArgs());
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable tbl = ds.Tables["tblDSHoSoBenhAn"];

            // Kiểm tra nhập đủ dữ liệu
            if (string.IsNullOrWhiteSpace(txtIDHoSoBenhAn.Text) || string.IsNullOrWhiteSpace(txtIDBenhNhan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hồ sơ!");
                return;
            }

            if (isAdding)
            {
                // Kiểm tra trùng mã
                if (tbl.Rows.Find(txtIDHoSoBenhAn.Text) != null)
                {
                    MessageBox.Show("Mã hồ sơ đã tồn tại!");
                    return;
                }

                // 🆕 Thêm mới hồ sơ
                DataRow newRow = tbl.NewRow();
                newRow["HoSoID"] = txtIDHoSoBenhAn.Text;
                newRow["BenhNhanID"] = txtIDBenhNhan.Text;
                newRow["NgayLap"] = dateTimePickerNgayLap.Value.Date;
                newRow["TrieuChung"] = txtTrieuChung.Text;
                newRow["TienSuBenh"] = txtTienSuBenh.Text;
                newRow["Chuandoan"] = txtChuanDoan.Text;
                newRow["GhiChu"] = txtGhiChu.Text;
                tbl.Rows.Add(newRow);
            }
            else
            {
                // ✏️ Sửa hồ sơ có sẵn
                DataRow row = tbl.Rows.Find(txtIDHoSoBenhAn.Text);
                if (row != null)
                {
                    row["BenhNhanID"] = txtIDBenhNhan.Text;
                    row["NgayLap"] = dateTimePickerNgayLap.Value.Date;
                    row["TrieuChung"] = txtTrieuChung.Text;
                    row["TienSuBenh"] = txtTienSuBenh.Text;
                    row["Chuandoan"] = txtChuanDoan.Text;
                    row["GhiChu"] = txtGhiChu.Text;
                }
            }

            // 💾 Cập nhật xuống CSDL
            using (SqlDataAdapter daSave = new SqlDataAdapter("SELECT * FROM HoSoBenhAn", conn))
            {
                SqlCommandBuilder cbSave = new SqlCommandBuilder(daSave);
                daSave.Update(ds.Tables["tblDSHoSoBenhAn"]);
            }

            MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 🔄 Reset trạng thái
            txtIDHoSoBenhAn.Clear();
            txtIDBenhNhan.Clear();
            dateTimePickerNgayLap.Value = DateTime.Now;
            txtTrieuChung.Clear();
            txtTienSuBenh.Clear();
            txtChuanDoan.Clear();
            txtGhiChu.Clear();

            // 🔘 Bật lại các nút
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

            // 🔄 Load lại dữ liệu
            ds.Tables["tblDSHoSoBenhAn"].Clear();
            daHSBA.Fill(ds, "tblDSHoSoBenhAn");
            DgViewHoSoBenhAn.DataSource = ds.Tables["tblDSHoSoBenhAn"];

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại
            this.Close();
        }
    }
}
