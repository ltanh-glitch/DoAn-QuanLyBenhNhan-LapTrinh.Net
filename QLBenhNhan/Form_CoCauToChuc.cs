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
    public partial class Form_CoCauToChuc : Form
    {
        public Form_CoCauToChuc()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại để trở về form chính
            this.Close();
        }
    }
}
