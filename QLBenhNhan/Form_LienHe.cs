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
    public partial class Form_LienHe : Form
    {
        public Form_LienHe()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            // Đóng Form_LienHe và trở về Form_Main
            this.Close();
        }

        private void btnGuiEmail_Click(object sender, EventArgs e)
        {
            // nếu chưa nhập email hoặc nội dung
            if (txtLienHeHoTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo");
                txtLienHeHoTen.Focus();
            }
            else if (txtLienHeEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo");
                txtLienHeEmail.Focus();
            }
            else if (txtLienHeSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo");
                txtLienHeSDT.Focus();
            }
            else if (txtTieuDeEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tiêu đề!", "Thông báo");
                txtTieuDeEmail.Focus();
            }
            else if (txtNoiDungEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nội dung!", "Thông báo");
                txtNoiDungEmail.Focus();
            }
            else
            {
                // Gửi email thành công
                MessageBox.Show("Gửi email thành công!"+ " \nChúng tôi sẽ phản hồi trong thời gian sớm nhất.", "Thông báo");
                // Xoá trắng các TextBox
                txtLienHeHoTen.Clear();
                txtLienHeEmail.Clear();
                txtLienHeSDT.Clear();
                txtTieuDeEmail.Clear();
                txtNoiDungEmail.Clear();
                // Đặt con trỏ về TextBox họ tên
                txtLienHeHoTen.Focus();
            }
        }
    }
}
