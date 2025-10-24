using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBenhNhan
{
    public partial class Form_HeThong : Form
    {
        public Form_HeThong()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void picDangXuat_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận đăng xuất
            var kqDangXuat = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kqDangXuat == DialogResult.Yes)
            {
                // Nếu người dùng chọn "Yes", đóng Form_HeThong và mở Form_Login
                this.Hide();
                Form_Login frmLogin = new Form_Login();
                frmLogin.ShowDialog();
                this.Close();
            }
        }

        private void lblDangXuat_Click(object sender, EventArgs e)
        {
            // Gọi lại sự kiện click của picDangXuat để xử lý đăng xuất
            picDangXuat_Click(sender, e);
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận thoát ứng dụng
            var kqThoat = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kqThoat == DialogResult.Yes)
            {
                // Nếu người dùng chọn "Yes", thoát ứng dụng
                Application.Exit();
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            // Gọi lại sự kiện click của picThoat để xử lý thoát ứng dụng
            picThoat_Click(sender, e);
        }

        private void picTroVe_Click(object sender, EventArgs e)
        {
            // Đóng Form_HeThong để trở về Form_Main
            this.Close();
        }

        private void lblTroVe_Click(object sender, EventArgs e)
        {
            // Gọi lại sự kiện click của picTroVe để xử lý trở về
            picTroVe_Click(sender, e);
        }
    }
}
