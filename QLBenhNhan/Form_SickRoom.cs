using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBenhNhan
{
    public partial class Form_SickRoom : Form
    {
        // Constructor
        SqlConnection conn;
        SqlDataAdapter daPhongBenh;
        SqlDataAdapter daBenhNhan;
        SqlCommandBuilder cbPhong;
        SqlCommandBuilder cbBenhNhan;
        DataSet ds = new DataSet();
        bool isAdding = false;
        bool Edit = false;
        public Form_SickRoom()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form_SickRoom_Load(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Kết nối cơ sở dữ liệu
                string connStr = ConfigurationManager.ConnectionStrings["QLBNConn"].ConnectionString;
                conn = new SqlConnection(connStr);

                // 2️⃣ Load dữ liệu PhongBenh + tên bệnh nhân
                string sQueryPhongBenh = @"SELECT pb.PhongBenhID, pb.BenhNhanID, bn.HoTen AS TenBenhNhan, 
                           pb.NgayNhapVien, pb.NgayXuatVien, pb.PhongSo, pb.GiuongSo
                    FROM PhongBenh pb
                    LEFT JOIN BenhNhan bn ON pb.BenhNhanID = bn.BenhNhanID";


                daPhongBenh = new SqlDataAdapter(sQueryPhongBenh, conn);
                daPhongBenh.Fill(ds, "tblDSPhongBenh");

                
                //  Load dữ liệu Bệnh Nhân để tra cứu tên
                string sQueryBenhNhan = "SELECT * FROM BenhNhan";
                daBenhNhan = new SqlDataAdapter(sQueryBenhNhan, conn);
                daBenhNhan.Fill(ds, "tblDSBenhNhan");

                // 3️⃣ Gán khóa chính cho DataTable
                DataTable tblPhongBenh = ds.Tables["tblDSPhongBenh"];
                tblPhongBenh.PrimaryKey = new DataColumn[] { tblPhongBenh.Columns["PhongBenhID"] };

                // 4️⃣ Hiển thị dữ liệu lên DataGridView
                DgViewPhongBenh.DataSource = ds.Tables["tblDSPhongBenh"];

                // Đổi tên hiển thị cột TenBenhNhan
                DgViewPhongBenh.Columns["TenBenhNhan"].HeaderText = "Họ Tên";

                // 5️⃣ Khi load form, các TextBox và DateTimePicker bị disable
                txtIDPhongBenh.Enabled = false;
                txtIDBenhNhan.Enabled = false;
                dateTimePickerNgayNhapVien.Enabled = false;
                dateTimePickerNgayRaVien.Enabled = false;
                txtSoGiuong.Enabled = false;
                txtSoPhong.Enabled = false;

                // 6️⃣ Button Lưu và Hủy bị disable
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu phòng bệnh: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable tblPhongBenh = ds.Tables["tblDSPhongBenh"];

            if (!isAdding)
            {
                // Bắt đầu thêm mới
                isAdding = true;
                btnThem.Text = "Xác nhận";

                // Enable TextBox / DateTimePicker để nhập
                txtIDPhongBenh.Enabled = true;
                txtIDBenhNhan.Enabled = true;
                dateTimePickerNgayNhapVien.Enabled = true;
                dateTimePickerNgayRaVien.Enabled = true;
                txtSoPhong.Enabled = true;
                txtSoGiuong.Enabled = true;

                // Button điều khiển
                btnHuy.Enabled = true;
                btnLuu.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

                // Xóa trắng nội dung
                txtIDBenhNhan.Clear();
                txtIDPhongBenh.Clear();
                dateTimePickerNgayNhapVien.Value = DateTime.Now;
                dateTimePickerNgayRaVien.Value = DateTime.Now;
                txtSoPhong.Clear();
                txtSoGiuong.Clear();
            }
            else
            {
                // ================= KIỂM TRA DỮ LIỆU =================
                if (string.IsNullOrWhiteSpace(txtIDPhongBenh.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã phòng bệnh!", "Thông báo");
                    txtIDPhongBenh.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtIDBenhNhan.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã bệnh nhân!", "Thông báo");
                    txtIDBenhNhan.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtSoPhong.Text))
                {
                    MessageBox.Show("Vui lòng nhập số phòng!", "Thông báo");
                    txtSoPhong.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtSoGiuong.Text))
                {
                    MessageBox.Show("Vui lòng nhập số giường!", "Thông báo");
                    txtSoGiuong.Focus();
                    return;
                }

                // Kiểm tra ID trùng
                if (tblPhongBenh.Rows.Find(txtIDPhongBenh.Text) != null)
                {
                    MessageBox.Show("Mã phòng bệnh đã tồn tại!", "Trùng ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIDPhongBenh.Focus();
                    return;
                }
                // Kiểm tra mã bệnh nhân tồn tại
                DataTable tblMaBN = ds.Tables["tblDSBenhNhan"];
                if (tblMaBN.Rows.Find(txtIDBenhNhan.Text) == null)
                {
                    MessageBox.Show("Mã bệnh nhân không tồn tại!", "Lỗi mã bệnh nhân", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIDBenhNhan.Focus();
                    return;
                }
                // Kiểm tra trùng ID bệnh nhân trong phòng
                if (tblPhongBenh.Rows.Find(txtIDBenhNhan.Text) != null)
                {
                    MessageBox.Show("Bệnh nhân này đã được nhập vào phòng bệnh!", "Trùng bệnh nhân", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIDBenhNhan.Focus();
                    return;
                }

                // ================= THÊM PHÒNG BỆNH =================
                DataRow newRow = tblPhongBenh.NewRow();
                newRow["PhongBenhID"] = txtIDPhongBenh.Text;
                newRow["BenhNhanID"] = txtIDBenhNhan.Text;

                // Lấy tên bệnh nhân tự động
                DataTable tblBenhNhan = ds.Tables["tblDSBenhNhan"];
                DataRow[] foundBN = tblBenhNhan.Select($"BenhNhanID = '{txtIDBenhNhan.Text}'");
                newRow["TenBenhNhan"] = (foundBN.Length > 0) ? foundBN[0]["HoTen"] : "";
                newRow["NgayXuatVien"] = dateTimePickerNgayRaVien.Checked ? dateTimePickerNgayRaVien.Value.Date : (object)DBNull.Value;
                newRow["PhongSo"] = txtSoPhong.Text;
                newRow["GiuongSo"] = txtSoGiuong.Text;

                tblPhongBenh.Rows.Add(newRow);

                MessageBox.Show("Thêm phòng bệnh thành công!", "Thông báo");


                // ================= RESET TRẠNG THÁI =================
                isAdding = false;
                btnThem.Text = "Thêm";

                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                // Disable TextBox / DateTimePicker
                txtIDPhongBenh.Enabled = false;
                txtIDBenhNhan.Enabled = false;
                dateTimePickerNgayNhapVien.Enabled = false;
                dateTimePickerNgayRaVien.Enabled = false;
                txtSoPhong.Enabled = false;
                txtSoGiuong.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtIDPhongBenh.Enabled = true;
            txtIDBenhNhan.Enabled = true;
            dateTimePickerNgayNhapVien.Enabled = true;
            dateTimePickerNgayRaVien.Enabled = true;
            txtSoGiuong.Enabled = true;
            txtSoPhong.Enabled = true;

            if (!Edit)
            {
                // Lần nhấn 1: bật chế độ sửa
                if (string.IsNullOrEmpty(txtIDPhongBenh.Text))
                {
                    MessageBox.Show("Vui lòng chọn phòng cần sửa!", "Thông báo");
                    return;
                }

                Edit = true;
                btnSua.Text = "Xác nhận";
                txtIDPhongBenh.Enabled = false; // Không sửa ID
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                // Lần nhấn 2: xác nhận sửa
                if (txtIDPhongBenh.Text == "" || txtIDBenhNhan.Text == "" || txtSoGiuong.Text == "" || txtSoPhong.Text == "" || dateTimePickerNgayNhapVien.Text == "" || dateTimePickerNgayRaVien.Text =="")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                    return;
                }
                

                DataRow row = ds.Tables["tblDSPhongBenh"].Rows.Find(txtIDPhongBenh.Text);
                if (row != null)
                {
                    row["PhongBenhID"] = txtIDPhongBenh.Text;
                    row["BenhNhanID"] = txtIDBenhNhan.Text;
                    row["PhongSo"] = txtSoPhong.Text;
                    row["GiuongSo"] = txtSoGiuong.Text;
                    row["NgayNhapVien"] = dateTimePickerNgayNhapVien.Value.Date;
                    row["NgayXuatVien"] = dateTimePickerNgayRaVien.Checked ? dateTimePickerNgayRaVien.Value.Date : (object)DBNull.Value;

                    DgViewPhongBenh.DataSource = ds.Tables["tblDSPhongBenh"];
                    MessageBox.Show("Cập nhật thông tin phòng thành công!", "Thông báo");
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

        private void DgViewPhongBenh_SelectionChanged(object sender, EventArgs e)
        {
            if (DgViewPhongBenh.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DgViewPhongBenh.SelectedRows[0];

                txtIDPhongBenh.Text = row.Cells["colPhongBenhID"].Value?.ToString();
                txtIDBenhNhan.Text = row.Cells["colBenhNhanID"].Value?.ToString();
                txtSoPhong.Text = row.Cells["colPhongSo"].Value?.ToString();
                txtSoGiuong.Text = row.Cells["colGiuongSo"].Value?.ToString();
                dateTimePickerNgayNhapVien.Value = row.Cells["colNgayNhapVien"].Value != DBNull.Value
                    ? Convert.ToDateTime(row.Cells["colNgayNhapVien"].Value)
                    : DateTime.Now;
                if (row.Cells["colNgayXuatVien"].Value != DBNull.Value)
                {
                    dateTimePickerNgayRaVien.Value = Convert.ToDateTime(row.Cells["colNgayXuatVien"].Value);
                    dateTimePickerNgayRaVien.Checked = true;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDPhongBenh.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maPB = txtIDPhongBenh.Text;

            DialogResult dr = MessageBox.Show(
                $"Bạn có chắc muốn xóa Khoa có mã '{maPB}' không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dr == DialogResult.Yes)
            {
                ds.Tables["tblDSPhongBenh"].PrimaryKey = new DataColumn[]
                {
                    ds.Tables["tblDSPhongBenh"].Columns["PhongBenhID"]
                };

                DataRow row = ds.Tables["tblDSPhongBenh"].Rows.Find(maPB);
                if (row != null)
                {
                    row.Delete();
                    MessageBox.Show("Đã xóa phòn khỏi danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtIDPhongBenh.Clear();
            txtIDBenhNhan.Clear();
            dateTimePickerNgayNhapVien.Value = DateTime.Now;
            dateTimePickerNgayRaVien.Value = DateTime.Now;
            txtSoPhong.Clear();
            txtSoGiuong.Clear();

            // Enable các textbox
            txtIDPhongBenh.Enabled = false;
            txtIDBenhNhan.Enabled = false;
            dateTimePickerNgayNhapVien.Enabled = false;
            dateTimePickerNgayRaVien.Enabled = false;
            txtSoGiuong.Enabled = false;
            txtSoPhong.Enabled = false;
            // Disable các combobox
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;


            // Làm mới dữ liệu từ database
            ds.Tables["tblDSPhongBenh"].Clear();
            daPhongBenh.Fill(ds, "tblDSPhongBenh");
            DgViewPhongBenh.DataSource = ds.Tables["tblDSPhongBenh"];

            if (ds.Tables["tblDSPhongBenh"].Rows.Count > 0)
            {
                DgViewPhongBenh.Rows[0].Selected = true;
                DgViewPhongBenh_SelectionChanged(null, new EventArgs());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable tbl = ds.Tables["tblDSPhongBenh"];

            if (string.IsNullOrWhiteSpace(txtIDPhongBenh.Text) || string.IsNullOrWhiteSpace(txtIDBenhNhan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phòng!");
                return;
            }

            if (isAdding)
            {
                if (tbl.Rows.Find(txtIDPhongBenh.Text) != null)
                {
                    MessageBox.Show("Mã phòng đã tồn tại!");
                    return;
                }

                DataRow newRow = tbl.NewRow();
                newRow["PhongBenhID"] = txtIDPhongBenh.Text;
                newRow["BenhNhanID"] = txtIDBenhNhan.Text;
                newRow["NgayNhapVien"] = dateTimePickerNgayNhapVien.Value.Date;
                newRow["NgayXuatVien"] = dateTimePickerNgayRaVien.Checked ? dateTimePickerNgayRaVien.Value.Date : (object)DBNull.Value;
                newRow["PhongSo"] = txtSoPhong.Text;
                newRow["GiuongSo"] = txtSoGiuong.Text;
                tbl.Rows.Add(newRow);
            }
            else
            {
                DataRow row = tbl.Rows.Find(txtIDPhongBenh.Text);
                if (row != null)
                {
                    row["BenhNhanID"] = txtIDBenhNhan.Text;
                    row["NgayNhapVien"] = dateTimePickerNgayNhapVien.Value.Date;
                    row["NgayXuatVien"] = dateTimePickerNgayRaVien.Checked ? dateTimePickerNgayRaVien.Value.Date : (object)DBNull.Value;
                    row["PhongSo"] = txtSoPhong.Text;
                    row["GiuongSo"] = txtSoGiuong.Text;

                }
            }

            using (SqlDataAdapter daSave = new SqlDataAdapter("SELECT * FROM PhongBenh", conn))
            {
                SqlCommandBuilder cbSave = new SqlCommandBuilder(daSave);
                daSave.Update(ds.Tables["tblDSPhongBenh"]);
            }

            MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // reset trạng thái
            txtIDPhongBenh.Clear();
            txtIDBenhNhan.Clear();
            dateTimePickerNgayNhapVien.Value = DateTime.Now;
            dateTimePickerNgayRaVien.Value = DateTime.Now;
            txtSoPhong.Clear();
            txtSoGiuong.Clear();
            // bật các Button
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text.Trim() == "")
            {
                // Nếu rỗng, hiển thị lại tất cả phòng
                DgViewPhongBenh.DataSource = ds.Tables["tblDSPhongBenh"];
                return;
            }

            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["QLBNConn"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string query = @"SELECT pb.PhongBenhID, pb.BenhNhanID, bn.HoTen AS TenBenhNhan,
                                    pb.NgayNhapVien, pb.NgayXuatVien, pb.PhongSo, pb.GiuongSo
                             FROM PhongBenh pb
                             LEFT JOIN BenhNhan bn ON pb.BenhNhanID = bn.BenhNhanID
                             WHERE pb.PhongBenhID LIKE @TuKhoa
                                OR pb.BenhNhanID LIKE @TuKhoa
                                OR bn.HoTen LIKE @TuKhoa";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TuKhoa", "%" + txtTim.Text.Trim() + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            DgViewPhongBenh.DataSource = dt;

                            // Ẩn cột BenhNhanID nếu muốn, đổi tên TenBenhNhan
                            if (DgViewPhongBenh.Columns["BenhNhanID"] != null)
                                DgViewPhongBenh.Columns["BenhNhanID"].Visible = false;
                            if (DgViewPhongBenh.Columns["TenBenhNhan"] != null)
                                DgViewPhongBenh.Columns["TenBenhNhan"].HeaderText = "Họ Tên Bệnh Nhân";

                            // Chọn dòng đầu tiên
                            if (DgViewPhongBenh.Rows.Count > 0)
                            {
                                DgViewPhongBenh.Rows[0].Selected = true;
                                DgViewPhongBenh_SelectionChanged(null, new EventArgs());
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy phòng hoặc bệnh nhân!",
                                            "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Nếu muốn load lại tất cả
                            DgViewPhongBenh.DataSource = ds.Tables["tblDSPhongBenh"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // bật button
            btnHuy.Enabled = true;
        }
    }
}
