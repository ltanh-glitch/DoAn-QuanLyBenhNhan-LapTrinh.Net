using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace QLBenhNhan
{
    public partial class Form_Login : Form
    {
        private bool suppressTextChanged = false;

        public Form_Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtMatKhau.UseSystemPasswordChar = true;
            btnDangNhap.Click += btnDangNhap_Click;
            chkHienMatKhau.CheckedChanged += (s, e) =>
                txtMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked;

            // Gán sự kiện loại bỏ dấu, khoảng trắng
            txtTenDangNhap.KeyPress += TextBox_KeyPress_NoDiacritics;
            txtMatKhau.KeyPress += TextBox_KeyPress_NoDiacritics;
            txtTenDangNhap.TextChanged += TextBox_TextChanged_Sanitize;
            txtMatKhau.TextChanged += TextBox_TextChanged_Sanitize;
        }

        // 🔹 Căn giữa panel login
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (pnlLogin != null)
            {
                pnlLogin.Left = (ClientSize.Width - pnlLogin.Width) / 2;
                pnlLogin.Top = (ClientSize.Height - pnlLogin.Height) / 2;
            }
        }

        // 🔹 Chặn ký tự có dấu hoặc khoảng trắng
        private void TextBox_KeyPress_NoDiacritics(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (char.IsWhiteSpace(e.KeyChar) || CharHasDiacritic(e.KeyChar))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private bool CharHasDiacritic(char c)
        {
            string decomposed = c.ToString().Normalize(NormalizationForm.FormD);
            foreach (char dc in decomposed)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(dc) == UnicodeCategory.NonSpacingMark)
                    return true;
            }
            return false;
        }

        // 🔹 Xử lý khi người dùng dán hoặc nhập ký tự có dấu
        private void TextBox_TextChanged_Sanitize(object sender, EventArgs e)
        {
            if (suppressTextChanged) return;

            var tb = sender as TextBox;
            if (tb == null) return;

            string cleaned = RemoveDiacriticsAndSpaces(tb.Text);
            if (cleaned != tb.Text)
            {
                suppressTextChanged = true;
                int cursor = tb.SelectionStart;
                tb.Text = cleaned;
                tb.SelectionStart = Math.Min(cleaned.Length, cursor);
                suppressTextChanged = false;
            }
        }

        private string RemoveDiacriticsAndSpaces(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            string normalized = input.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();
            foreach (char c in normalized)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark &&
                    !char.IsWhiteSpace(c))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        // 🔹 Đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!chkDieuKien.Checked)
            {
                MessageBox.Show("Bạn phải đồng ý với điều khoản dịch vụ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connStr = ConfigurationManager.ConnectionStrings["QLBNConn"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap=@u AND MatKhau=@p";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password);

                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            // Hiện form Loading
                            using (var loading = new Form_Loading())
                                loading.ShowDialog();

                            // Mở form chính rồi ẩn form login
                            this.Hide();
                            using (var main = new Form_Main())
                            {
                                main.ShowDialog();
                            }
                            this.Close(); // ✅ Đảm bảo form login được đóng
                        }
                        else
                        {
                            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
