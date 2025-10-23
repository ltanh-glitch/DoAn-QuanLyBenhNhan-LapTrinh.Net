using System;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLBenhNhan
{
    public partial class Form_Loading : Form
    {
        public Form_Loading()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // đảm bảo sự kiện Load được đăng ký
            this.Load += Form_Loading_Load;
            lblNameDoAn.Parent = pictureBoxLoading;
            lblLoading.Parent = pictureBoxLoading;
            lblLoading.BackColor = System.Drawing.Color.Transparent;
            lblNameDoAn.BackColor = System.Drawing.Color.Transparent;
            lblNameDoAn.BringToFront();
            lblLoading.BringToFront();
        }
        private void Form_Loading_Load(object sender, EventArgs e)
        {
            StartLoading();
        }
        private async void StartLoading()
        {
            progressBarLoading.Value = 0;
            lblLoading.Text = "0%";

            // Giả lập quá trình cập nhật tiến độ
            for (int i = 0; i <= 100; i++)
            {
                // Cập nhật ProgressBar và Label mỗi lần
                progressBarLoading.Value = i;
                lblLoading.Text = i + "%";

                // Cập nhật giao diện ngay
                progressBarLoading.Refresh();
                lblLoading.Refresh();

                // Chờ 50ms để cập nhật từng bước
                await Task.Delay(50);
            }

            // Khi tiến độ đạt 100%, đóng form
            await Task.Delay(300); // Giữ 0.3s để người dùng thấy đủ thanh
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
