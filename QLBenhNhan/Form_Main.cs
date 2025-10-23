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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            // Gọi hàm bật hover cho menu
            EnableMenuHover(menuMain);

        }

        private void Form_Main_Resize(object sender, EventArgs e)
        {
            tblMain.Left = (this.ClientSize.Width - tblMain.Width) / 2;
            tblMain.Top = (this.ClientSize.Height - tblMain.Height) / 2;
        }
        // Hàm kích hoạt mở menu khi hover
        private void EnableMenuHover(MenuStrip menu)
        {
            foreach (ToolStripMenuItem item in menu.Items)
            {
                item.MouseHover += (s, e) =>
                {
                    if (item.DropDownItems.Count > 0)
                    {
                        item.ShowDropDown();
                    }
                };

                item.DropDown.MouseLeave += (s, e) =>
                {
                    item.HideDropDown();
                };
            }
        }

        // Tuỳ chỉnh màu menu
        public class CustomMenuColor : ProfessionalColorTable
        {
            public override Color MenuBorder => Color.White;
            public override Color MenuItemSelected => Color.FromArgb(255, 235, 205);
            public override Color MenuItemSelectedGradientBegin => Color.FromArgb(255, 235, 205);
            public override Color MenuItemSelectedGradientEnd => Color.FromArgb(255, 235, 205);
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in menuMain.Items)
            {
                item.MouseEnter += (s, ev) => item.ForeColor = Color.Orange;
                item.MouseLeave += (s, ev) => item.ForeColor = Color.Black;
            }
        }

        private void mnuChucNangNhiemVu_Click(object sender, EventArgs e)
        {
            Form_ChucNangNhiemVu frmCNNV = new Form_ChucNangNhiemVu();
            frmCNNV.ShowDialog();
        }

        private void mnuCoCauToChuc_Click(object sender, EventArgs e)
        {
            Form_CoCauToChuc frmCCTC = new Form_CoCauToChuc();
            frmCCTC.ShowDialog();
        }

        
    }
}
