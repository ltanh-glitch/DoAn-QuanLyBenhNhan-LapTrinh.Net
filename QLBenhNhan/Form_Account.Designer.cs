namespace QLBenhNhan
{
    partial class Form_Account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.panelNhomNut = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panelThongTinTaiKhoan = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.labMatKhau = new System.Windows.Forms.Label();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtIDDangNhap = new System.Windows.Forms.TextBox();
            this.labTenTaiKhoan = new System.Windows.Forms.Label();
            this.labIDDangNhap = new System.Windows.Forms.Label();
            this.DgViewTaiKhoan = new System.Windows.Forms.DataGridView();
            this.labDanhSachTaiKhoan = new System.Windows.Forms.Label();
            this.labQuanLyTaiKhoan = new System.Windows.Forms.Label();
            this.labVaiTro = new System.Windows.Forms.Label();
            this.txtVaiTro = new System.Windows.Forms.TextBox();
            this.pnlAccount.SuspendLayout();
            this.panelNhomNut.SuspendLayout();
            this.panelThongTinTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAccount
            // 
            this.pnlAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAccount.BackColor = System.Drawing.Color.SeaShell;
            this.pnlAccount.Controls.Add(this.panelNhomNut);
            this.pnlAccount.Controls.Add(this.panelThongTinTaiKhoan);
            this.pnlAccount.Controls.Add(this.DgViewTaiKhoan);
            this.pnlAccount.Controls.Add(this.labDanhSachTaiKhoan);
            this.pnlAccount.Controls.Add(this.labQuanLyTaiKhoan);
            this.pnlAccount.Location = new System.Drawing.Point(1, 1);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(1155, 607);
            this.pnlAccount.TabIndex = 2;
            // 
            // panelNhomNut
            // 
            this.panelNhomNut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelNhomNut.BackColor = System.Drawing.Color.SeaShell;
            this.panelNhomNut.Controls.Add(this.btnThoat);
            this.panelNhomNut.Controls.Add(this.btnHuy);
            this.panelNhomNut.Controls.Add(this.btnLuu);
            this.panelNhomNut.Controls.Add(this.btnXoa);
            this.panelNhomNut.Controls.Add(this.btnSua);
            this.panelNhomNut.Controls.Add(this.btnThem);
            this.panelNhomNut.Location = new System.Drawing.Point(870, 98);
            this.panelNhomNut.Name = "panelNhomNut";
            this.panelNhomNut.Size = new System.Drawing.Size(255, 186);
            this.panelNhomNut.TabIndex = 37;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(148, 136);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 39);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.ForeColor = System.Drawing.Color.Red;
            this.btnHuy.Location = new System.Drawing.Point(148, 77);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(104, 39);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ForeColor = System.Drawing.Color.Red;
            this.btnLuu.Location = new System.Drawing.Point(148, 18);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(104, 39);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(3, 136);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 39);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.Red;
            this.btnSua.Location = new System.Drawing.Point(3, 77);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 39);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.Red;
            this.btnThem.Location = new System.Drawing.Point(3, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 39);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // panelThongTinTaiKhoan
            // 
            this.panelThongTinTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelThongTinTaiKhoan.BackColor = System.Drawing.Color.SeaShell;
            this.panelThongTinTaiKhoan.Controls.Add(this.txtVaiTro);
            this.panelThongTinTaiKhoan.Controls.Add(this.labVaiTro);
            this.panelThongTinTaiKhoan.Controls.Add(this.txtMatKhau);
            this.panelThongTinTaiKhoan.Controls.Add(this.labMatKhau);
            this.panelThongTinTaiKhoan.Controls.Add(this.txtTenTaiKhoan);
            this.panelThongTinTaiKhoan.Controls.Add(this.txtIDDangNhap);
            this.panelThongTinTaiKhoan.Controls.Add(this.labTenTaiKhoan);
            this.panelThongTinTaiKhoan.Controls.Add(this.labIDDangNhap);
            this.panelThongTinTaiKhoan.Location = new System.Drawing.Point(30, 98);
            this.panelThongTinTaiKhoan.Name = "panelThongTinTaiKhoan";
            this.panelThongTinTaiKhoan.Size = new System.Drawing.Size(794, 221);
            this.panelThongTinTaiKhoan.TabIndex = 36;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(516, 14);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(227, 35);
            this.txtMatKhau.TabIndex = 13;
            // 
            // labMatKhau
            // 
            this.labMatKhau.AutoSize = true;
            this.labMatKhau.Location = new System.Drawing.Point(404, 18);
            this.labMatKhau.Name = "labMatKhau";
            this.labMatKhau.Size = new System.Drawing.Size(115, 27);
            this.labMatKhau.TabIndex = 4;
            this.labMatKhau.Text = "Mật Khẩu:";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(118, 58);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(227, 35);
            this.txtTenTaiKhoan.TabIndex = 10;
            // 
            // txtIDDangNhap
            // 
            this.txtIDDangNhap.Location = new System.Drawing.Point(118, 14);
            this.txtIDDangNhap.Name = "txtIDDangNhap";
            this.txtIDDangNhap.Size = new System.Drawing.Size(227, 35);
            this.txtIDDangNhap.TabIndex = 9;
            // 
            // labTenTaiKhoan
            // 
            this.labTenTaiKhoan.AutoSize = true;
            this.labTenTaiKhoan.Location = new System.Drawing.Point(13, 62);
            this.labTenTaiKhoan.Name = "labTenTaiKhoan";
            this.labTenTaiKhoan.Size = new System.Drawing.Size(150, 27);
            this.labTenTaiKhoan.TabIndex = 2;
            this.labTenTaiKhoan.Text = "Tên tài khoản:";
            // 
            // labIDDangNhap
            // 
            this.labIDDangNhap.AutoSize = true;
            this.labIDDangNhap.Location = new System.Drawing.Point(13, 18);
            this.labIDDangNhap.Name = "labIDDangNhap";
            this.labIDDangNhap.Size = new System.Drawing.Size(158, 27);
            this.labIDDangNhap.TabIndex = 1;
            this.labIDDangNhap.Text = "ID Đăng Nhập:";
            // 
            // DgViewTaiKhoan
            // 
            this.DgViewTaiKhoan.AllowUserToOrderColumns = true;
            this.DgViewTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgViewTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgViewTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.DgViewTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewTaiKhoan.Location = new System.Drawing.Point(21, 406);
            this.DgViewTaiKhoan.Name = "DgViewTaiKhoan";
            this.DgViewTaiKhoan.RowHeadersVisible = false;
            this.DgViewTaiKhoan.RowHeadersWidth = 62;
            this.DgViewTaiKhoan.RowTemplate.Height = 28;
            this.DgViewTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgViewTaiKhoan.Size = new System.Drawing.Size(1113, 199);
            this.DgViewTaiKhoan.TabIndex = 35;
            // 
            // labDanhSachTaiKhoan
            // 
            this.labDanhSachTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDanhSachTaiKhoan.AutoSize = true;
            this.labDanhSachTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labDanhSachTaiKhoan.Location = new System.Drawing.Point(21, 378);
            this.labDanhSachTaiKhoan.Name = "labDanhSachTaiKhoan";
            this.labDanhSachTaiKhoan.Size = new System.Drawing.Size(245, 26);
            this.labDanhSachTaiKhoan.TabIndex = 34;
            this.labDanhSachTaiKhoan.Text = "Danh Sách Tài Khoản:";
            // 
            // labQuanLyTaiKhoan
            // 
            this.labQuanLyTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labQuanLyTaiKhoan.AutoSize = true;
            this.labQuanLyTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labQuanLyTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.labQuanLyTaiKhoan.Location = new System.Drawing.Point(409, 51);
            this.labQuanLyTaiKhoan.Name = "labQuanLyTaiKhoan";
            this.labQuanLyTaiKhoan.Size = new System.Drawing.Size(446, 45);
            this.labQuanLyTaiKhoan.TabIndex = 33;
            this.labQuanLyTaiKhoan.Text = "QUẢN LÝ TÀI KHOẢN";
            this.labQuanLyTaiKhoan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labVaiTro
            // 
            this.labVaiTro.AutoSize = true;
            this.labVaiTro.Location = new System.Drawing.Point(404, 61);
            this.labVaiTro.Name = "labVaiTro";
            this.labVaiTro.Size = new System.Drawing.Size(87, 27);
            this.labVaiTro.TabIndex = 14;
            this.labVaiTro.Text = "Vai Trò:";
            // 
            // txtVaiTro
            // 
            this.txtVaiTro.Location = new System.Drawing.Point(516, 58);
            this.txtVaiTro.Name = "txtVaiTro";
            this.txtVaiTro.Size = new System.Drawing.Size(227, 35);
            this.txtVaiTro.TabIndex = 15;
            // 
            // Form_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 608);
            this.Controls.Add(this.pnlAccount);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Account";
            this.Text = "QUẢN LÝ TÀI KHOẢN";
            this.pnlAccount.ResumeLayout(false);
            this.pnlAccount.PerformLayout();
            this.panelNhomNut.ResumeLayout(false);
            this.panelThongTinTaiKhoan.ResumeLayout(false);
            this.panelThongTinTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAccount;
        private System.Windows.Forms.Panel panelNhomNut;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panelThongTinTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label labMatKhau;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.TextBox txtIDDangNhap;
        private System.Windows.Forms.Label labTenTaiKhoan;
        private System.Windows.Forms.Label labIDDangNhap;
        private System.Windows.Forms.DataGridView DgViewTaiKhoan;
        private System.Windows.Forms.Label labDanhSachTaiKhoan;
        private System.Windows.Forms.Label labQuanLyTaiKhoan;
        private System.Windows.Forms.TextBox txtVaiTro;
        private System.Windows.Forms.Label labVaiTro;
    }
}