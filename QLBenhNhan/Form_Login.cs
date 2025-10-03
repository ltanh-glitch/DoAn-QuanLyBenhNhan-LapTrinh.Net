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
    public partial class Form_Login : Form

    {
        public Form_Login()
        {
            InitializeComponent();
            //Khi form được tạo: đảm bảo khởi tạo các sự kiện
             this.StartPosition = FormStartPosition.CenterScreen; // căn giữa khi mở
            this.Load += FormLogin_Load;
            this.Resize += FormLogin_Resize; // gọi mỗi khi form thay đổi kích thước (maximize/minimize/resize)
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            CenterLoginPanel();
            this.Resize += (s, ev) => CenterLoginPanel(); // Tự căn giữa khi phóng to / thu nhỏ
        }

        private void FormLogin_Resize(object sender, EventArgs e)
        {
            CenterLoginBox();
        }

        /// <summary>
        /// Hàm căn giữa pictureBox1 so với vùng client của Form
        /// </summary>
        private void CenterLoginBox()
        {
            if (pnlLogin == null) return;

            // Nếu pictureBox nằm trực tiếp trên Form => tính toán so với ClientSize của Form
            pnlLogin.Left = (this.ClientSize.Width - pnlLogin.Width) / 2;
            pnlLogin.Top = (this.ClientSize.Height - pnlLogin.Height) / 2;
        }

        // Tùy chọn: đảm bảo lần hiển thị đầu tiên (sau khi layout xong) sẽ chính xác
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            CenterLoginBox();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

        }
        private void labTenDangNhap_Click(object sender, EventArgs e)
        {

        }
        private void CenterLoginPanel()
        {
            pnlLogin.Left = (this.ClientSize.Width - pnlLogin.Width) / 2;
            pnlLogin.Top = (this.ClientSize.Height - pnlLogin.Height) / 2;
        }

    }
}
