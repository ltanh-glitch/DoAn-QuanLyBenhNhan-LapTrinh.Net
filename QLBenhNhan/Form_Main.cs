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

        }

        private void Form_Main_Resize(object sender, EventArgs e)
        {
            tblMain.Left = (this.ClientSize.Width - tblMain.Width) / 2;
            tblMain.Top = (this.ClientSize.Height - tblMain.Height) / 2;
        }
        

        private void Form_Main_Load(object sender, EventArgs e)
        {
            // phân quyền người dùng
            if (!UserSession.IsAdmin)
            {
                tblMain.Visible = false;
                tblMainUser.Visible = true;
                khoaToolStripMenuItem.Visible = false;
                bácSĩToolStripMenuItem.Visible = false;
                tàiKhoảnToolStripMenuItem.Visible = false;

            }
            else             
            {
                tblMain.Visible = true;
                tblMainUser.Visible = false;
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

        private void pnlBenhNhanUser_Click(object sender, EventArgs e)
        {
            // Khi click vào panel bệnh nhân (user), mở form quản lý bệnh nhân
            Form_Patient frmPatient = new Form_Patient();
            frmPatient.ShowDialog();
        }

        private void picBanhNhanUser_Click(object sender, EventArgs e)
        {
            // Khi click vào hình ảnh bệnh nhân (user), mở form quản lý bệnh nhân
            Form_Patient frmPatient = new Form_Patient();
            frmPatient.ShowDialog();
        }

        private void lblBenhNhanUser_Click(object sender, EventArgs e)
        {
            // Khi click vào label bệnh nhân (user), mở form quản lý bệnh nhân
            Form_Patient frmPatient = new Form_Patient();
            frmPatient.ShowDialog();
        }

        private void pnlHSBAUser_Click(object sender, EventArgs e)
        {
            // Khi click vào panel hồ sơ bệnh án (user), mở form quản lý hồ sơ bệnh án
            Form_MedicalRecords frmMedicalRecord = new Form_MedicalRecords();
            frmMedicalRecord.ShowDialog();
        }

        private void picHSBAUser_Click(object sender, EventArgs e)
        {
            // Khi click vào hình ảnh hồ sơ bệnh án (user), mở form quản lý hồ sơ bệnh án
            Form_MedicalRecords frmMedicalRecord = new Form_MedicalRecords();
            frmMedicalRecord.ShowDialog();
        }

        private void lblHSBAUser_Click(object sender, EventArgs e)
        {
            // Khi click vào label hồ sơ bệnh án (user), mở form quản lý hồ sơ bệnh án
            Form_MedicalRecords frmMedicalRecord = new Form_MedicalRecords();
            frmMedicalRecord.ShowDialog();
        }

        private void pnlPhongBenhUser_Click(object sender, EventArgs e)
        {
            // Khi click vào panel phòng bệnh (user), mở form quản lý phòng bệnh
            Form_SickRoom frmSickRoom = new Form_SickRoom();
            frmSickRoom.ShowDialog();
        }

        private void picPhongBenhUser_Click(object sender, EventArgs e)
        {
            // Khi click vào hình ảnh phòng bệnh (user), mở form quản lý phòng bệnh
            Form_SickRoom frmSickRoom = new Form_SickRoom();
            frmSickRoom.ShowDialog();
        }

        private void lblPhongBenhUser_Click(object sender, EventArgs e)
        {
            // Khi click vào label phòng bệnh (user), mở form quản lý phòng bệnh
            Form_SickRoom frmSickRoom = new Form_SickRoom();
            frmSickRoom.ShowDialog();
        }

        private void pnlDieuTriUser_Click(object sender, EventArgs e)
        {
            // Khi click vào panel điều trị (user), mở form quản lý điều trị
            Form_Therapeutic frmTherapeutic = new Form_Therapeutic();
            frmTherapeutic.ShowDialog();
        }

        private void picDieuTriUser_Click(object sender, EventArgs e)
        {
            // Khi click vào hình ảnh điều trị (user), mở form quản lý điều trị
            Form_Therapeutic frmTherapeutic = new Form_Therapeutic();
            frmTherapeutic.ShowDialog();
        }

        private void lblDieuTriUser_Click(object sender, EventArgs e)
        {
            // Khi click vào label điều trị (user), mở form quản lý điều trị
            Form_Therapeutic frmTherapeutic = new Form_Therapeutic();
            frmTherapeutic.ShowDialog();
        }

        private void pnlBaoCaoUser_Click(object sender, EventArgs e)
        {
            // Khi click vào panel báo cáo (user), mở form báo cáo
            Form_BaoCao frmBaoCao = new Form_BaoCao();
            frmBaoCao.ShowDialog();
        }

        private void picBaoCaoUser_Click(object sender, EventArgs e)
        {
            // Khi click vào hình ảnh báo cáo (user), mở form báo cáo
            Form_BaoCao frmBaoCao = new Form_BaoCao();
            frmBaoCao.ShowDialog();
        }

        private void lblBaoCaoUser_Click(object sender, EventArgs e)
        {
            // Khi click vào label báo cáo (user), mở form báo cáo
            Form_BaoCao frmBaoCao = new Form_BaoCao();  
            frmBaoCao.ShowDialog();
        }

        private void pnlHeThongUser_Click(object sender, EventArgs e)
        {
            // Khi click vào panel hệ thống (user), mở form hệ thống
            Form_HeThong frmHeThong = new Form_HeThong();
            frmHeThong.ShowDialog();
        }

        private void picHeThongUser_Click(object sender, EventArgs e)
        {
            // Khi click vào hình ảnh hệ thống (user), mở form hệ thống
            Form_HeThong frmHeThong = new Form_HeThong();
            frmHeThong.ShowDialog();
        }

        private void lblHeThongUser_Click(object sender, EventArgs e)
        {
            // Khi click vào label hệ thống (user), mở form hệ thống
            Form_HeThong frmHeThong = new Form_HeThong();
            frmHeThong.ShowDialog();
        }

        private void bệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở Form_Patient khi click vào menu Bệnh Nhân
            Form_Patient frmPatient = new Form_Patient();
            frmPatient.ShowDialog();
        }

        private void hồSơBệnhÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở Form_MedicalRecords khi click vào menu Hồ Sơ Bệnh Án
            Form_MedicalRecords frmMedicalRecord = new Form_MedicalRecords();
            frmMedicalRecord.ShowDialog();
        }

        private void phòngBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở Form_SickRoom khi click vào menu Phòng Bệnh
            Form_SickRoom frmSickRoom = new Form_SickRoom();
            frmSickRoom.ShowDialog();
        }

        private void điềuTrịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở Form_Therapeutic khi click vào menu Điều Trị
            Form_Therapeutic frmTherapeutic = new Form_Therapeutic();
            frmTherapeutic.ShowDialog();
        }

        private void bácSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở Form_Doctor khi click vào menu Bác Sĩ
            Form_Doctor frmDoctor = new Form_Doctor();
            frmDoctor.ShowDialog();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở Form_Account khi click vào menu Tài Khoản
            Form_Account frmAccount = new Form_Account();
            frmAccount.ShowDialog();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở Form_BaoCao khi click vào menu Báo Cáo
            Form_BaoCao frmBaoCao = new Form_BaoCao();
            frmBaoCao.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Đăng xuất và trở về Form_Login
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                Form_Login frmLogin = new Form_Login();
                frmLogin.ShowDialog();
                this.Close();
            }
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Thoát ứng dụng
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                 Application.Exit();
            }
        }

        private void chứcNăngNhiệmVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở Form_ChucNangNhiemVu khi click vào menu Chức Năng Nhiệm Vụ
            Form_ChucNangNhiemVu frmCNNV = new Form_ChucNangNhiemVu();
            frmCNNV.ShowDialog();
        }

        private void cơCấuTổChứcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở Form_CoCauToChuc khi click vào menu Cơ Cấu Tổ Chức
            Form_CoCauToChuc frmCCTC = new Form_CoCauToChuc();
            frmCCTC.ShowDialog();
        }

        private void liênHệToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Mở Form_LienHe khi click vào menu Liên Hệ
            Form_LienHe frmLienHe = new Form_LienHe();
            frmLienHe.ShowDialog();
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Mở Form_HuongDanSuDung khi click vào menu Hướng Dẫn Sử Dụng
            Form_HuongDanSuDung frmHDSD = new Form_HuongDanSuDung();
            frmHDSD.ShowDialog();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở Form_Khoa khi click vào menu Khoa
            Form_Khoa frmChuyenKhoa = new Form_Khoa();
            frmChuyenKhoa.ShowDialog();
        }
    }
}
