using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLBenhNhan
{
    public partial class Form_Patient : Form
    {
        public Form_Patient()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        // ===================== Biến toàn cục =====================
        DataSet ds = new DataSet("dsQLBN");
        SqlDataAdapter daBenhNhan;
        SqlConnection conn;
        SqlCommandBuilder cb;
        bool Them = false; // Biến kiểm tra trạng thái thêm
        bool Sua = false;  // Biến kiểm tra trạng thái sửa

        // ===================== Form Load =====================
        private void Form_Patient_Load(object sender, EventArgs e)
        {
            // Lấy chuỗi kết nối từ App.config
            string connStr = ConfigurationManager.ConnectionStrings["QLBNConn"].ConnectionString;

            // Mở kết nối (không dùng using vì cần giữ kết nối)
            conn = new SqlConnection(connStr);
            conn.Open();

            // Lấy dữ liệu từ SQL
            string sqlBenhNhan = "SELECT * FROM BenhNhan";
            daBenhNhan = new SqlDataAdapter(sqlBenhNhan, conn);

            // Tạo CommandBuilder để hỗ trợ Update/Insert/Delete
            cb = new SqlCommandBuilder(daBenhNhan);

            daBenhNhan.Fill(ds, "tblDSBenhNhan");

            // Đặt cột BenhNhanID làm khóa chính cho DataTable
            ds.Tables["tblDSBenhNhan"].PrimaryKey =
                new DataColumn[] { ds.Tables["tblDSBenhNhan"].Columns["BenhNhanID"] };

            // Gán DataSet vào DataGridView
            DgViewBenhNhan.DataSource = ds.Tables["tblDSBenhNhan"];

            // Đổi tiêu đề cột
            DgViewBenhNhan.Columns["BenhNhanID"].HeaderText = "Mã BN";
            DgViewBenhNhan.Columns["HoTen"].HeaderText = "Họ Tên";
            DgViewBenhNhan.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            DgViewBenhNhan.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            DgViewBenhNhan.Columns["GioiTinh"].HeaderText = "Giới Tính";
            DgViewBenhNhan.Columns["SDT"].HeaderText = "SĐT";
            DgViewBenhNhan.Columns["CCCD"].HeaderText = "CCCD";
            DgViewBenhNhan.Columns["TenThanNhan"].HeaderText = "Tên Thân Nhân";
            DgViewBenhNhan.Columns["SDTThanNhan"].HeaderText = "SĐT Thân Nhân";

            // Chỉnh độ rộng cột
            DgViewBenhNhan.Columns["BenhNhanID"].Width = 80;

            // Tắt các control nhập liệu ban đầu
            ControlsEnabled(false);

            // Thiết lập trạng thái Button
            ButtonsEnabled(true);

            // Chọn dòng đầu tiên nếu có dữ liệu
            if (ds.Tables["tblDSBenhNhan"].Rows.Count > 0)
            {
                DgViewBenhNhan.Rows[0].Selected = true;
                // Hiển thị dữ liệu dòng đầu tiên vào textbox
                DgViewBenhNhan_SelectionChanged(null, new EventArgs());
            }
        }
        private void LoadBenhNhan()
        {
            try
            {
                ds.Tables["tblDSBenhNhan"].Clear(); // Xóa dữ liệu cũ trong DataSet
                daBenhNhan.Fill(ds, "tblDSBenhNhan"); // Nạp lại dữ liệu từ SQL
                DgViewBenhNhan.DataSource = ds.Tables["tblDSBenhNhan"]; // Hiển thị lại

                if (ds.Tables["tblDSBenhNhan"].Rows.Count > 0)
                {
                    DgViewBenhNhan.Rows[0].Selected = true;
                    DgViewBenhNhan_SelectionChanged(null, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách bệnh nhân: " + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Kích hoạt hoặc tắt các control nhập liệu
        private void ControlsEnabled(bool status)
        {
            txtID.Enabled = status;
            txtHoTen.Enabled = status;
            radNam.Enabled = status;
            radNu.Enabled = status;
            txtDiaChi.Enabled = status;
            dateTimePickerNgaySinh.Enabled = status;
            txtSĐT.Enabled = status;
            txtCCCD.Enabled = status;
            txtTenThanNhan.Enabled = status;
            txtSĐTThanNhan.Enabled = status;
        }

        // Kích hoạt hoặc tắt các Button
        private void ButtonsEnabled(bool status)
        {
            btnThem.Enabled = status;
            btnSua.Enabled = status;
            btnXoa.Enabled = status;
            btnLuu.Enabled = !status;
            btnHuy.Enabled = !status;
        }

        // Hiển thị dữ liệu dòng được chọn lên textbox khi chọn bằng chuột hoặc mũi tên
        private void DgViewBenhNhan_SelectionChanged(object sender, EventArgs e)
        {
            if (DgViewBenhNhan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DgViewBenhNhan.SelectedRows[0];

                txtID.Text = row.Cells["BenhNhanID"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtCCCD.Text = row.Cells["CCCD"].Value?.ToString();
                txtSĐT.Text = row.Cells["SDT"].Value?.ToString();
                txtTenThanNhan.Text = row.Cells["TenThanNhan"].Value?.ToString();
                txtSĐTThanNhan.Text = row.Cells["SDTThanNhan"].Value?.ToString();

                if (row.Cells["NgaySinh"].Value != DBNull.Value)
                    dateTimePickerNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);

                string gioiTinh = row.Cells["GioiTinh"].Value?.ToString();
                radNam.Checked = (gioiTinh == "Nam");
                radNu.Checked = (gioiTinh == "Nữ");
            }
        }

        // ===================== Các Button =====================
        // Thoát form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Hủy thao tác Thêm/Sửa
        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Hủy trạng thái Thêm hoặc Sửa
            if (Them)
            {
                Them = false;
                btnThem.Text = "Thêm";
            }
            else if (Sua)
            {
                Sua = false;
                btnSua.Text = "Sửa";
            }

            // Reset các textbox và control
            txtID.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtCCCD.Clear();
            txtSĐT.Clear();
            txtTenThanNhan.Clear();
            txtSĐTThanNhan.Clear();
            radNam.Checked = false;
            radNu.Checked = false;
            dateTimePickerNgaySinh.Value = DateTime.Now;

            ControlsEnabled(false);
            ButtonsEnabled(true);

            // Làm mới dữ liệu từ database
            ds.Tables["tblDSBenhNhan"].Clear();
            daBenhNhan.Fill(ds, "tblDSBenhNhan");
            DgViewBenhNhan.DataSource = ds.Tables["tblDSBenhNhan"];

            if (ds.Tables["tblDSBenhNhan"].Rows.Count > 0)
            {
                DgViewBenhNhan.Rows[0].Selected = true;
                DgViewBenhNhan_SelectionChanged(null, new EventArgs());
            }
        }

        // Thêm bệnh nhân
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!Them)
            {
                // Lần nhấn 1: bật chế độ thêm
                Them = true;
                btnThem.Text = "Xác nhận";

                ControlsEnabled(true);
                ButtonsEnabled(false);
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = true;

                // Xóa nội dung cũ
                txtID.Clear();
                txtHoTen.Clear();
                txtDiaChi.Clear();
                txtCCCD.Clear();
                txtSĐT.Clear();
                txtTenThanNhan.Clear();
                txtSĐTThanNhan.Clear();
                radNam.Checked = false;
                radNu.Checked = false;
                dateTimePickerNgaySinh.Value = DateTime.Now;
                txtID.Focus();
            }
            else
            {
                // Lần nhấn 2: xác nhận thêm
                // Kiểm tra dữ liệu bắt buộc
                if (txtID.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập ID!", "Thông báo");
                    txtID.Focus();
                    return;
                }
                if (txtHoTen.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo");
                    txtHoTen.Focus();
                    return;
                }
                if (!radNam.Checked && !radNu.Checked)
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo");
                    return;
                }
                if (txtDiaChi.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ!", "Thông báo");
                    txtDiaChi.Focus();
                    return;
                }
                if (txtCCCD.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập CCCD!", "Thông báo");
                    txtCCCD.Focus();
                    return;
                }
                if (txtSĐT.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo");
                    txtSĐT.Focus();
                    return;
                }
                if (txtTenThanNhan.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên thân nhân!", "Thông báo");
                    txtTenThanNhan.Focus();
                    return;
                }
                if (txtSĐTThanNhan.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại thân nhân!", "Thông báo");
                    txtSĐTThanNhan.Focus();
                    return;
                }

                // Kiểm tra trùng ID
                ds.Tables["tblDSBenhNhan"].PrimaryKey = new DataColumn[]
                {
                    ds.Tables["tblDSBenhNhan"].Columns["BenhNhanID"]
                };
                if (ds.Tables["tblDSBenhNhan"].Rows.Find(txtID.Text) != null)
                {
                    MessageBox.Show("Mã bệnh nhân đã tồn tại!", "Trùng ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Focus();
                    return;
                }

                // Thêm dữ liệu mới vào DataSet
                DataRow row = ds.Tables["tblDSBenhNhan"].NewRow();
                row["BenhNhanID"] = txtID.Text;
                row["HoTen"] = txtHoTen.Text;
                row["GioiTinh"] = radNu.Checked ? "Nữ" : "Nam";
                row["DiaChi"] = txtDiaChi.Text;
                row["NgaySinh"] = dateTimePickerNgaySinh.Value;
                row["SDT"] = txtSĐT.Text;
                row["CCCD"] = txtCCCD.Text;
                row["TenThanNhan"] = txtTenThanNhan.Text;
                row["SDTThanNhan"] = txtSĐTThanNhan.Text;

                ds.Tables["tblDSBenhNhan"].Rows.Add(row);

                DgViewBenhNhan.DataSource = ds.Tables["tblDSBenhNhan"];
                MessageBox.Show("Thêm bệnh nhân thành công!", "Thông báo");

                // Reset trạng thái nút
                Them = false;
                btnThem.Text = "Thêm";
                ControlsEnabled(false);
                ButtonsEnabled(true);
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
        }

        // Lưu dữ liệu xuống SQL
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                cb = new SqlCommandBuilder(daBenhNhan);
                daBenhNhan.Update(ds, "tblDSBenhNhan");
                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu dữ liệu thất bại!\nLỗi: " + ex.Message, "Lỗi");
            }
        }

        // Sửa bệnh nhân
        private void btnSua_Click(object sender, EventArgs e)
        {
            ControlsEnabled(true);
            ButtonsEnabled(false);

            if (!Sua)
            {
                // Lần nhấn 1: bật chế độ sửa
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Vui lòng chọn bệnh nhân cần sửa!", "Thông báo");
                    return;
                }

                Sua = true;
                btnSua.Text = "Xác nhận";
                txtID.Enabled = false; // Không sửa ID
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
            }
            else
            {
                // Lần nhấn 2: xác nhận sửa
                if (txtHoTen.Text == "" || (!radNam.Checked && !radNu.Checked) ||
                    txtDiaChi.Text == "" || txtCCCD.Text == "" || txtSĐT.Text == "" ||
                    txtTenThanNhan.Text == "" || txtSĐTThanNhan.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                    return;
                }

                DataRow row = ds.Tables["tblDSBenhNhan"].Rows.Find(txtID.Text);
                if (row != null)
                {
                    row["HoTen"] = txtHoTen.Text;
                    row["GioiTinh"] = radNu.Checked ? "Nữ" : "Nam";
                    row["DiaChi"] = txtDiaChi.Text;
                    row["NgaySinh"] = dateTimePickerNgaySinh.Value;
                    row["SDT"] = txtSĐT.Text;
                    row["CCCD"] = txtCCCD.Text;
                    row["TenThanNhan"] = txtTenThanNhan.Text;
                    row["SDTThanNhan"] = txtSĐTThanNhan.Text;

                    DgViewBenhNhan.DataSource = ds.Tables["tblDSBenhNhan"];
                    MessageBox.Show("Cập nhật thông tin bệnh nhân thành công!", "Thông báo");
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                }

                // Reset trạng thái
                Sua = false;
                btnSua.Text = "Sửa";
                ControlsEnabled(false);
                ButtonsEnabled(true);
                btnHuy.Enabled = true;
                btnLuu.Enabled = true;
            }
        }

        // Xóa bệnh nhân
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maBN = txtID.Text;

            DialogResult dr = MessageBox.Show(
                $"Bạn có chắc muốn xóa bệnh nhân có mã '{maBN}' không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dr == DialogResult.Yes)
            {
                ds.Tables["tblDSBenhNhan"].PrimaryKey = new DataColumn[]
                {
                    ds.Tables["tblDSBenhNhan"].Columns["BenhNhanID"]
                };

                DataRow row = ds.Tables["tblDSBenhNhan"].Rows.Find(maBN);
                if (row != null)
                {
                    row.Delete();
                    MessageBox.Show("Đã xóa bệnh nhân khỏi danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bệnh nhân cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
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
                    string query = "SELECT * FROM BenhNhan " +
                                    "WHERE HoTen LIKE @TuKhoa OR CCCD LIKE @TuKhoa";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TuKhoa", "%" + txtTim.Text.Trim() + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            DgViewBenhNhan.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy bệnh nhân nào phù hợp!",
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
            // Bật button
            btnHuy.Enabled = true;
        }
    }
}
