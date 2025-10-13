using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QLBenhNhan
{
    public partial class Form_Login : Form

    {
        public Form_Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += FormLogin_Load;
            this.Resize += FormLogin_Resize;
            btnDangNhap.Click += btnDangNhap_Click;

            // Thiết lập mặc định ẩn mật khẩu
            txtMatKhau.UseSystemPasswordChar = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked;
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
        private void CenterLoginPanel()
        {
            pnlLogin.Left = (this.ClientSize.Width - pnlLogin.Width) / 2;
            pnlLogin.Top = (this.ClientSize.Height - pnlLogin.Height) / 2;
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!chkDieuKien.Checked)
            {
                MessageBox.Show("Bạn phải đồng ý với điều kiện và điều khoản dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connStr = ConfigurationManager.ConnectionStrings["QLBNConn"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @username AND MatKhau = @password";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Mở form khác nếu muốn, ví dụ:
                            // Form_Patient frm = new Form_Patient();
                            // frm.Show();
                            // this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
