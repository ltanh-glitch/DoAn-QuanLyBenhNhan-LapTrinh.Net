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
    public partial class Form_HuongDanSuDung : Form
    {
        public Form_HuongDanSuDung()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            // Đóng form hướng dẫn sử dụng
            this.Close();
        }
    }
}
