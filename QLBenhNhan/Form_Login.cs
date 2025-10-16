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
using System.Globalization;

namespace QLBenhNhan
{
    public partial class Form_Login : Form

    {
        // Flag để tránh vòng lặp khi thay đổi Text trong TextChanged
        private bool _suppressTextChanged = false;

        public Form_Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized; //Phóng to toàn màn hình
            this.Load += FormLogin_Load;
            this.Resize += FormLogin_Resize;
            btnDangNhap.Click += btnDangNhap_Click;

            // Thiết lập mặc định ẩn mật khẩu
            txtMatKhau.Multiline = false;
            txtMatKhau.UseSystemPasswordChar = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;

            // Gắn sự kiện chặn gõ ngay khi nhập
            txtTenDangNhap.KeyPress += TextBox_KeyPress_NoDiacritics;
            txtMatKhau.KeyPress += TextBox_KeyPress_NoDiacritics;

            // Dự phòng: nếu IME hoặc compose nhập vượt qua KeyPress, sanitize trong TextChanged
            txtTenDangNhap.TextChanged += TextBox_TextChanged_Sanitize;
            txtMatKhau.TextChanged += TextBox_TextChanged_Sanitize;
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

        /// <summary>
        /// Kiểm tra ký tự có chứa dấu (diacritic) không bằng cách phân rã (FormD)
        /// Nếu phân rã chứa NonSpacingMark => ký tự có dấu.
        /// </summary>
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

        /// <summary>
        /// Chặn ký tự khi gõ: không cho khoảng trắng và ký tự có dấu.
        /// Cho phép phím điều khiển (Backspace, Delete, mũi tên...) để người dùng chỉnh sửa.
        /// </summary>
        private void TextBox_KeyPress_NoDiacritics(object sender, KeyPressEventArgs e)
        {
            // cho phép phím điều khiển
            if (char.IsControl(e.KeyChar)) return;

            // chặn khoảng trắng
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            // chặn ký tự có dấu (ví dụ: á, ầ, ẻ, ê, ô, ơ, ư...)
            if (CharHasDiacritic(e.KeyChar))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
                return;
            }

            // khác: cho phép nhập
        }

        /// <summary>
        /// Loại bỏ dấu và khoảng trắng khỏi chuỗi (dùng trong TextChanged để dọn dẹp input nếu cần).
        /// Kết quả: chuỗi "viết liền, không dấu".
        /// </summary>
        private string RemoveDiacriticsAndSpaces(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            string normalized = input.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder(normalized.Length);
            foreach (char c in normalized)
            {
                var uc = CharUnicodeInfo.GetUnicodeCategory(c);
                if (uc == UnicodeCategory.NonSpacingMark) continue; // bỏ dấu
                if (char.IsWhiteSpace(c)) continue; // bỏ khoảng trắng
                sb.Append(c);
            }
            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        /// <summary>
        /// TextChanged: sanitize toàn bộ nội dung textbox (dự phòng cho IME/composition).
        /// Không gây nhấp nháy vị trí con trỏ vì dùng flag để tránh vòng lặp.
        /// </summary>
        private void TextBox_TextChanged_Sanitize(object sender, EventArgs e)
        {
            if (_suppressTextChanged) return;

            var tb = sender as TextBox;
            if (tb == null) return;

            string original = tb.Text;
            string sanitized = RemoveDiacriticsAndSpaces(original);

            if (sanitized != original)
            {
                try
                {
                    _suppressTextChanged = true;
                    int oldSel = tb.SelectionStart;
                    tb.Text = sanitized;
                    // đặt con trỏ về cuối hoặc gần vị trí trước đó nếu có thể
                    tb.SelectionStart = Math.Min(sanitized.Length, Math.Max(0, oldSel - (original.Length - sanitized.Length)));
                }
                finally
                {
                    _suppressTextChanged = false;
                }
                System.Media.SystemSounds.Beep.Play();
            }
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

                            // Hiện form loading (progress) trước khi mở Form_Main
                            /*using (var loading = new Form_Loading())
                            {
                                loading.DurationMs = 1000; // thời gian mô phỏng (ms) — chỉnh nếu cần
                                loading.ShowDialog(this);
                            }*/

                            // Sau khi loading xong, mở form main
                            //Form_Main frmMain = new Form_Main();
                            //frmMain.Show();
                            //this.Hide();
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
