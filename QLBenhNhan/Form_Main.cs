using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBenhNhan.Common;

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

        private void DisableAdminPanel(Panel panel)
        {
            // Làm mờ panel và con của nó
            panel.Enabled = false;
            panel.BackColor = Color.FromArgb(230, 230, 230);

            foreach (Control ctrl in panel.Controls)
            {
                ctrl.ForeColor = Color.Gray;
            }

            // Tạo icon khóa
            Label lockIcon = new Label
            {
                Text = "🔒",
                Font = new Font("Segoe UI Emoji", 32, FontStyle.Bold),
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(100, Color.White)
            };

            // Tooltip khi rê chuột
            ToolTip tip = new ToolTip();
            tip.SetToolTip(panel, "Chức năng chỉ dành cho Quản trị viên (Admin)");

            // Thêm icon khóa chồng lên
            panel.Controls.Add(lockIcon);
            lockIcon.BringToFront();
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            // phân quyền người dùng
            if (!UserSession.IsAdmin)
            {
                DisableAdminPanel(pnlTaiKhoan);
                DisableAdminPanel(pnlBacSi);
                DisableAdminPanel(pnlChuyenKhoa);
            }

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

        private void pnlBenhNhan_Click(object sender, EventArgs e)
        {
            // Khi click vào panel bệnh nhân, mở form quản lý bệnh nhân
            Form_Patient frmPatient = new Form_Patient();
            frmPatient.ShowDialog();
        }

        private void picBenhNhan_Click(object sender, EventArgs e)
        {
            // Khi click vào hình ảnh bệnh nhân, mở form quản lý bệnh nhân
            Form_Patient frmPatient = new Form_Patient();
            frmPatient.ShowDialog();
        }

        private void lblBenhNhan_Click(object sender, EventArgs e)
        {
            // Khi click vào label bệnh nhân, mở form quản lý bệnh nhân
            Form_Patient frmPatient = new Form_Patient();
            frmPatient.ShowDialog();
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở Form_LienHe khi click vào menu Liên Hệ
            Form_LienHe frmLienHe = new Form_LienHe();
            frmLienHe.ShowDialog();
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở Form_HuongDanSuDung khi click vào menu Hướng Dẫn Sử Dụng
            Form_HuongDanSuDung frmHDSD = new Form_HuongDanSuDung();
            frmHDSD.ShowDialog();
        }

        private void pnlHeThong_Click(object sender, EventArgs e)
        {
            // Khi click vào panel hệ thống, mở form hệ thống
            Form_HeThong frmHeThong = new Form_HeThong();
            frmHeThong.ShowDialog();
        }

        private void picHeThong_Click(object sender, EventArgs e)
        {
            // Khi click vào hình ảnh hệ thống, mở form hệ thống
            Form_HeThong frmHeThong = new Form_HeThong();
            frmHeThong.ShowDialog();
        }

        private void lblHeThong_Click(object sender, EventArgs e)
        {
            // Khi click vào label hệ thống, mở form hệ thống
            Form_HeThong frmHeThong = new Form_HeThong();
            frmHeThong.ShowDialog();
        }

        private void picKhoa_Click(object sender, EventArgs e)
        {
            // Khi click vào hình ảnh chuyên khoa, mở form chuyên khoa
            Form_Khoa frmChuyenKhoa = new Form_Khoa();
            frmChuyenKhoa.ShowDialog();
        }

        private void lblChuyenKhoa_Click(object sender, EventArgs e)
        {
            // Khi click vào label chuyên khoa, mở form chuyên khoa
            Form_Khoa frmChuyenKhoa = new Form_Khoa();
            frmChuyenKhoa.ShowDialog();
        }

        private void pnlChuyenKhoa_Click(object sender, EventArgs e)
        {
            // Khi click vào panel chuyên khoa, mở form chuyên khoa
            Form_Khoa frmChuyenKhoa = new Form_Khoa();
            frmChuyenKhoa.ShowDialog();
        }

        private void pnlBacSi_Click(object sender, EventArgs e)
        {
            // Khi click vào panel bác sĩ, mở form quản lý bác sĩ
            Form_Doctor frmDoctor = new Form_Doctor();
            frmDoctor.ShowDialog();
        }

        private void picBacSi_Click(object sender, EventArgs e)
        {
            // Khi click vào hình ảnh bác sĩ, mở form quản lý bác sĩ
            Form_Doctor frmDoctor = new Form_Doctor();
            frmDoctor.ShowDialog();
        }

        private void lblBacSi_Click(object sender, EventArgs e)
        {
            // Khi click vào label bác sĩ, mở form quản lý bác sĩ
            Form_Doctor frmDoctor = new Form_Doctor();
            frmDoctor.ShowDialog();
        }

        private void pnlPhongBenh_Click(object sender, EventArgs e)
        {
            // Khi click vào panel phòng bệnh, mở form quản lý phòng bệnh
            Form_SickRoom frmSickRoom = new Form_SickRoom();
            frmSickRoom.ShowDialog();
        }

        private void picPhongBenh_Click(object sender, EventArgs e)
        {
            // Khi click vào hình ảnh phòng bệnh, mở form quản lý phòng bệnh
            Form_SickRoom frmSickRoom = new Form_SickRoom();
            frmSickRoom.ShowDialog();
        }

        private void lblPhongBenh_Click(object sender, EventArgs e)
        {
            // Khi click vào label phòng bệnh, mở form quản lý phòng bệnh
            Form_SickRoom frmSickRoom = new Form_SickRoom();
            frmSickRoom.ShowDialog();
        }

        private void pnlHoSoBenhAn_Click(object sender, EventArgs e)
        {
            // Khi click vào panel hồ sơ bệnh án, mở form quản lý hồ sơ bệnh án
            Form_MedicalRecords frmMedicalRecord = new Form_MedicalRecords();
            frmMedicalRecord.ShowDialog();
        }

        private void picHSBA_Click(object sender, EventArgs e)
        {
            // Khi click vào hình ảnh hồ sơ bệnh án, mở form quản lý hồ sơ bệnh án
            Form_MedicalRecords frmMedicalRecord = new Form_MedicalRecords();
            frmMedicalRecord.ShowDialog();
        }

        private void lblHSBA_Click(object sender, EventArgs e)
        {
            // Khi click vào label hồ sơ bệnh án, mở form quản lý hồ sơ bệnh án
            Form_MedicalRecords frmMedicalRecord = new Form_MedicalRecords();
            frmMedicalRecord.ShowDialog();
        }

        private void pnlTaiKhoan_Click(object sender, EventArgs e)
        {
            // Khi click vào panel tài khoản, mở form quản lý tài khoản
            Form_Account frmAccount = new Form_Account();
            frmAccount.ShowDialog();
        }

        private void picTaiKhoan_Click(object sender, EventArgs e)
        {
            // Khi click vào hình ảnh tài khoản, mở form quản lý tài khoản
            Form_Account frmAccount = new Form_Account();
            frmAccount.ShowDialog();
        }

        private void lblTaiKhoan_Click(object sender, EventArgs e)
        {
            // Khi click vào label tài khoản, mở form quản lý tài khoản
            Form_Account frmAccount = new Form_Account();
            frmAccount.ShowDialog();
        }

        private void pnlDieuTri_Click(object sender, EventArgs e)
        {
            // Khi click vào panel điều trị, mở form quản lý điều trị
            Form_Therapeutic frmTherapeutic = new Form_Therapeutic();
            frmTherapeutic.ShowDialog();
        }

        private void picDieuTri_Click(object sender, EventArgs e)
        {
            // Khi click vào hình ảnh điều trị, mở form quản lý điều trị
            Form_Therapeutic frmTherapeutic = new Form_Therapeutic();
            frmTherapeutic.ShowDialog();
        }

        private void lblDieuTri_Click(object sender, EventArgs e)
        {
            // Khi click vào label điều trị, mở form quản lý điều trị
            Form_Therapeutic frmTherapeutic = new Form_Therapeutic();
            frmTherapeutic.ShowDialog();
        }

        private void pnlBaoCao_Click(object sender, EventArgs e)
        {
            // Khi click vào panel báo cáo, mở form báo cáo
            Form_BaoCao frmBaoCao = new Form_BaoCao();
            frmBaoCao.ShowDialog();
        }

        private void picBaocao_Click(object sender, EventArgs e)
        {
            // Khi click vào hình ảnh báo cáo, mở form báo cáo
            Form_BaoCao frmBaoCao = new Form_BaoCao();
            frmBaoCao.ShowDialog();
        }

        private void lblBaoCao_Click(object sender, EventArgs e)
        {
            // Khi click vào label báo cáo, mở form báo cáo
            Form_BaoCao frmBaoCao = new Form_BaoCao();
            frmBaoCao.ShowDialog();
        }
    }
}
