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
    public partial class Form_Splash : Form
    {
        public Form_Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop(); // Dừng đếm thời gian
            Form_Login login = new Form_Login(); // Mở form đăng nhập
            login.Show();
            this.Hide(); // Ẩn Splash
        }
    }
}
