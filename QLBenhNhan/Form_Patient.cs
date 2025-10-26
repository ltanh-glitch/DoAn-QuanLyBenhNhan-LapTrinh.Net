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

        DataSet ds = new DataSet("dsQLBN");
        SqlDataAdapter daBenhNhan;
        SqlConnection conn;
        SqlCommandBuilder cb;
        bool Them = false; // Biến toàn cục trong class
        bool Sua = false;


        private void Form_Patient_Load(object sender, EventArgs e)
        {
            // Lấy chuỗi kết nối từ App.config
            string connStr = ConfigurationManager.ConnectionStrings["QLBNConn"].ConnectionString;

            // KHÔNG dùng "using" nữa — vì cần giữ kết nối để Update sau này
            conn = new SqlConnection(connStr);
            conn.Open();

            string sqlBenhNhan = "SELECT * FROM BenhNhan";
            daBenhNhan = new SqlDataAdapter(sqlBenhNhan, conn);

            // Tạo command builder cho insert/update/delete
            cb = new SqlCommandBuilder(daBenhNhan);

            daBenhNhan.Fill(ds, "tblDSBenhNhan");

            // DataSet đã có PrimaryKey, có thể dùng Rows.Find() ngay
            DgViewBenhNhan.DataSource = ds.Tables["tblDSBenhNhan"];


            // Gán dữ liệu vào DataGridView
            DgViewBenhNhan.DataSource = ds.Tables["tblDSBenhNhan"];

            // Đổi tiêu đề cột hiển thị
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

            // gọi hàm tắt control nhập liệu (các cái txt)
            ControlsEnabled(false);
            // gọi hàm thiết lập trạng thái Button
            ButtonsEnabled(true);

            // Sau khi gán DataSource và thiết lập cột
            if (ds.Tables["tblDSBenhNhan"].Rows.Count > 0)
            {
                // Chọn dòng đầu tiên
                DgViewBenhNhan.Rows[0].Selected = true;

                // Gọi sự kiện CellClick thủ công để hiển thị thông tin dòng đầu tiên
                DgViewBenhNhan_CellClick(null, new DataGridViewCellEventArgs(0, 0));
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại để trở về form chính
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // 1️⃣ Nếu đang trong chế độ thêm, hủy bỏ thêm
            if (Them)
            {
                Them = false;
                btnThem.Text = "Thêm";
            }else if (Sua)
            {
                // Nếu đang trong chế độ sửa, hủy bỏ sửa
                Sua = false;
                btnSua.Text = "Sửa";
            }

            // 2️⃣ Reset các textbox, radio button, datepicker
            this.txtID.Clear();
            this.txtHoTen.Clear();
            this.txtDiaChi.Clear();
            this.txtCCCD.Clear();
            this.txtSĐT.Clear();
            this.txtTenThanNhan.Clear();
            this.txtSĐTThanNhan.Clear();
            radNam.Checked = false;
            radNu.Checked = false;
            this.dateTimePickerNgaySinh.Value = DateTime.Now;

            // 3️⃣ Khóa lại các control nhập
            ControlsEnabled(false);
            ButtonsEnabled(true);

            // 4️⃣ Làm mới dữ liệu từ SQL để DataGridView hiển thị lại đúng
            ds.Tables["tblDSBenhNhan"].Clear(); // Xóa dữ liệu cũ trong dataset
            daBenhNhan.Fill(ds, "tblDSBenhNhan"); // Load lại từ SQL
            DgViewBenhNhan.DataSource = ds.Tables["tblDSBenhNhan"];
            // Sau khi gán DataSource và thiết lập cột
            if (ds.Tables["tblDSBenhNhan"].Rows.Count > 0)
            {
                // Chọn dòng đầu tiên
                DgViewBenhNhan.Rows[0].Selected = true;

                // Gọi sự kiện CellClick thủ công để hiển thị thông tin dòng đầu tiên
                DgViewBenhNhan_CellClick(null, new DataGridViewCellEventArgs(0, 0));
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!Them)
            {
                // ---- LẦN NHẤN 1 ----
                Them = true;
                btnThem.Text = "Xác nhận";

                ControlsEnabled(true);
                ButtonsEnabled(false);
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = true;

                // Xóa nội dung cũ
                this.txtID.Clear();
                this.txtHoTen.Clear();
                this.txtDiaChi.Clear();
                this.txtCCCD.Clear();
                this.txtSĐT.Clear();
                this.txtTenThanNhan.Clear();
                this.txtSĐTThanNhan.Clear();
                radNam.Checked = false;
                radNu.Checked = false;
                this.dateTimePickerNgaySinh.Value = DateTime.Now;
                this.txtID.Focus();
            }
            else
            {
                // ---- LẦN NHẤN 2 ----
                // Kiểm tra dữ liệu
                if (txtID.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập ID!", "Thông báo");
                    txtID.Focus();
                    return;
                }
                else if (txtHoTen.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo");
                    txtHoTen.Focus();
                    return;
                }
                else if (!radNam.Checked && !radNu.Checked)
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo");
                    return;
                }
                else if (txtDiaChi.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ!", "Thông báo");
                    txtDiaChi.Focus();
                    return;
                }
                else if (txtCCCD.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập CCCD!", "Thông báo");
                    txtCCCD.Focus();
                    return;
                }
                else if (txtSĐT.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo");
                    txtSĐT.Focus();
                    return;
                }
                else if (txtTenThanNhan.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên thân nhân!", "Thông báo");
                    txtTenThanNhan.Focus();
                    return;
                }
                else if (txtSĐTThanNhan.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại thân nhân!", "Thông báo");
                    txtSĐTThanNhan.Focus();
                    return;
                }
                // Đảm bảo có PrimaryKey để kiểm tra trùng
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

                // Tạo dòng mới
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

                // Cập nhật lại hiển thị
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


        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                cb = new SqlCommandBuilder(daBenhNhan); // Đảm bảo có lệnh Update
                daBenhNhan.Update(ds, "tblDSBenhNhan");
                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu dữ liệu thất bại!\nLỗi: " + ex.Message, "Lỗi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Mở các control để sửa (txt)
            ControlsEnabled(true);
            ButtonsEnabled(false);
            // Nếu chưa vào chế độ sửa
            if (!Sua)
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Vui lòng chọn bệnh nhân cần sửa!", "Thông báo");
                    return;
                }

                Sua = true;
                btnSua.Text = "Xác nhận";

                ControlsEnabled(true);
                txtID.Enabled = false; // Không cho sửa ID
                ButtonsEnabled(false);
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
            }
            else
            {
                // ---- LẦN NHẤN 2 ----
                // Kiểm tra dữ liệu nhập
                if (txtHoTen.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo");
                    txtHoTen.Focus();
                    return;
                }
                else if (!radNam.Checked && !radNu.Checked)
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo");
                    return;
                }
                else if (txtDiaChi.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ!", "Thông báo");
                    txtDiaChi.Focus();
                    return;
                }
                else if (txtCCCD.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập CCCD!", "Thông báo");
                    txtCCCD.Focus();
                    return;
                }
                else if (txtSĐT.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo");
                    txtSĐT.Focus();
                    return;
                }
                else if (txtTenThanNhan.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên thân nhân!", "Thông báo");
                    txtTenThanNhan.Focus();
                    return;
                }
                else if (txtSĐTThanNhan.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại thân nhân!", "Thông báo");
                    txtSĐTThanNhan.Focus();
                    return;
                }

                // Tìm dòng cần sửa trong dataset
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

                    // Cập nhật lại hiển thị
                    DgViewBenhNhan.DataSource = ds.Tables["tblDSBenhNhan"];
                    MessageBox.Show("Cập nhật thông tin bệnh nhân thành công!", "Thông báo");
                    // Cho phép lưu hoặc hủy sau khi sửa
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

        private void DgViewBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu người dùng click vào dòng hợp lệ(không phải header)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DgViewBenhNhan.Rows[e.RowIndex];

                // Hiển thị dữ liệu lên các TextBox
                txtID.Text = row.Cells["BenhNhanID"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtCCCD.Text = row.Cells["CCCD"].Value.ToString();
                txtSĐT.Text = row.Cells["SDT"].Value.ToString();
                txtTenThanNhan.Text = row.Cells["TenThanNhan"].Value.ToString();
                txtSĐTThanNhan.Text = row.Cells["SDTThanNhan"].Value.ToString();

                // Ngày sinh
                if (row.Cells["NgaySinh"].Value != DBNull.Value)
                {
                    dateTimePickerNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                }

                // Giới tính
                string gioiTinh = row.Cells["GioiTinh"].Value.ToString();
                radNam.Checked = (gioiTinh == "Nam");
                radNu.Checked = (gioiTinh == "Nữ");
            }
        }
        // Khi form hiện thì tắt các control nhập liệu
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
        // Khi Form hiện thì có một số Button mở và một số Button tắt
        private void ButtonsEnabled(bool status)
        {
            btnThem.Enabled = status;
            btnSua.Enabled = status;
            btnXoa.Enabled = status;
            btnLuu.Enabled = !status;
            btnHuy.Enabled = !status;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maBN = txtID.Text;

            // Hỏi người dùng xác nhận
            DialogResult dr = MessageBox.Show(
                $"Bạn có chắc muốn xóa bệnh nhân có mã '{maBN}' không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dr == DialogResult.Yes)
            {
                // Đảm bảo có PrimaryKey để dùng Rows.Find()
                ds.Tables["tblDSBenhNhan"].PrimaryKey = new DataColumn[]
                {
                ds.Tables["tblDSBenhNhan"].Columns["BenhNhanID"]
                };

                // Tìm dòng cần xóa trong DataSet
                DataRow row = ds.Tables["tblDSBenhNhan"].Rows.Find(maBN);

                if (row != null)
                {
                    // Xóa dòng khỏi DataSet (sẽ hiện ra ngay trên DataGridView)
                    row.Delete();

                    MessageBox.Show("Đã xóa bệnh nhân khỏi danh sách .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bệnh nhân cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // BtnLưu và BtnXoa để cập nhật thay đổi vào database
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
        }

    }
}
