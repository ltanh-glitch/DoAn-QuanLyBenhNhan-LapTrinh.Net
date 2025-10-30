namespace QLBenhNhan
{
    partial class Form_MedicalRecords
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panelNhomNut = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtChuanDoan = new System.Windows.Forms.TextBox();
            this.lblChuanDoan = new System.Windows.Forms.Label();
            this.labNgayLap = new System.Windows.Forms.Label();
            this.txtTienSuBenh = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.labTienSuBenh = new System.Windows.Forms.Label();
            this.labTrieuChung = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtIDBenhNhan = new System.Windows.Forms.TextBox();
            this.txtIDHoSoBenhAn = new System.Windows.Forms.TextBox();
            this.labGhiChu = new System.Windows.Forms.Label();
            this.labIDBenhNhan = new System.Windows.Forms.Label();
            this.labIDHoSoBenhAn = new System.Windows.Forms.Label();
            this.panelThongTinHoSoBenhAn = new System.Windows.Forms.Panel();
            this.DgViewHoSoBenhAn = new System.Windows.Forms.DataGridView();
            this.labDanhSachHoSoBenhAn = new System.Windows.Forms.Label();
            this.labQuanLyHoSoBenhAn = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlMedicalRecords = new System.Windows.Forms.Panel();
            this.panelNhomNut.SuspendLayout();
            this.panelThongTinHoSoBenhAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewHoSoBenhAn)).BeginInit();
            this.pnlMedicalRecords.SuspendLayout();
            this.SuspendLayout();
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
            this.panelNhomNut.Location = new System.Drawing.Point(852, 122);
            this.panelNhomNut.Name = "panelNhomNut";
            this.panelNhomNut.Size = new System.Drawing.Size(255, 186);
            this.panelNhomNut.TabIndex = 37;
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
            // txtChuanDoan
            // 
            this.txtChuanDoan.Location = new System.Drawing.Point(118, 142);
            this.txtChuanDoan.Name = "txtChuanDoan";
            this.txtChuanDoan.Size = new System.Drawing.Size(227, 35);
            this.txtChuanDoan.TabIndex = 19;
            // 
            // lblChuanDoan
            // 
            this.lblChuanDoan.AutoSize = true;
            this.lblChuanDoan.Location = new System.Drawing.Point(13, 146);
            this.lblChuanDoan.Name = "lblChuanDoan";
            this.lblChuanDoan.Size = new System.Drawing.Size(134, 27);
            this.lblChuanDoan.TabIndex = 18;
            this.lblChuanDoan.Text = "Chuẩn đoán:";
            // 
            // labNgayLap
            // 
            this.labNgayLap.AutoSize = true;
            this.labNgayLap.Location = new System.Drawing.Point(13, 107);
            this.labNgayLap.Name = "labNgayLap";
            this.labNgayLap.Size = new System.Drawing.Size(113, 27);
            this.labNgayLap.TabIndex = 7;
            this.labNgayLap.Text = "Ngày Lập:";
            // 
            // txtTienSuBenh
            // 
            this.txtTienSuBenh.Location = new System.Drawing.Point(516, 58);
            this.txtTienSuBenh.Name = "txtTienSuBenh";
            this.txtTienSuBenh.Size = new System.Drawing.Size(227, 35);
            this.txtTienSuBenh.TabIndex = 14;
            // 
            // dateTimePickerNgayLap
            // 
            this.dateTimePickerNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayLap.Location = new System.Drawing.Point(132, 104);
            this.dateTimePickerNgayLap.Name = "dateTimePickerNgayLap";
            this.dateTimePickerNgayLap.Size = new System.Drawing.Size(141, 35);
            this.dateTimePickerNgayLap.TabIndex = 15;
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Location = new System.Drawing.Point(516, 14);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(227, 35);
            this.txtTrieuChung.TabIndex = 13;
            // 
            // labTienSuBenh
            // 
            this.labTienSuBenh.AutoSize = true;
            this.labTienSuBenh.Location = new System.Drawing.Point(404, 62);
            this.labTienSuBenh.Name = "labTienSuBenh";
            this.labTienSuBenh.Size = new System.Drawing.Size(141, 27);
            this.labTienSuBenh.TabIndex = 5;
            this.labTienSuBenh.Text = "Tiền sử bệnh:";
            // 
            // labTrieuChung
            // 
            this.labTrieuChung.AutoSize = true;
            this.labTrieuChung.Location = new System.Drawing.Point(404, 18);
            this.labTrieuChung.Name = "labTrieuChung";
            this.labTrieuChung.Size = new System.Drawing.Size(133, 27);
            this.labTrieuChung.TabIndex = 4;
            this.labTrieuChung.Text = "Triệu chứng:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(516, 104);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(227, 35);
            this.txtGhiChu.TabIndex = 12;
            // 
            // txtIDBenhNhan
            // 
            this.txtIDBenhNhan.Location = new System.Drawing.Point(118, 58);
            this.txtIDBenhNhan.Name = "txtIDBenhNhan";
            this.txtIDBenhNhan.Size = new System.Drawing.Size(227, 35);
            this.txtIDBenhNhan.TabIndex = 10;
            // 
            // txtIDHoSoBenhAn
            // 
            this.txtIDHoSoBenhAn.Location = new System.Drawing.Point(118, 14);
            this.txtIDHoSoBenhAn.Name = "txtIDHoSoBenhAn";
            this.txtIDHoSoBenhAn.Size = new System.Drawing.Size(227, 35);
            this.txtIDHoSoBenhAn.TabIndex = 9;
            // 
            // labGhiChu
            // 
            this.labGhiChu.AutoSize = true;
            this.labGhiChu.Location = new System.Drawing.Point(404, 108);
            this.labGhiChu.Name = "labGhiChu";
            this.labGhiChu.Size = new System.Drawing.Size(94, 27);
            this.labGhiChu.TabIndex = 6;
            this.labGhiChu.Text = "Ghi chú:";
            // 
            // labIDBenhNhan
            // 
            this.labIDBenhNhan.AutoSize = true;
            this.labIDBenhNhan.Location = new System.Drawing.Point(13, 62);
            this.labIDBenhNhan.Name = "labIDBenhNhan";
            this.labIDBenhNhan.Size = new System.Drawing.Size(153, 27);
            this.labIDBenhNhan.TabIndex = 2;
            this.labIDBenhNhan.Text = "ID Bệnh nhân:";
            // 
            // labIDHoSoBenhAn
            // 
            this.labIDHoSoBenhAn.AutoSize = true;
            this.labIDHoSoBenhAn.Location = new System.Drawing.Point(13, 18);
            this.labIDHoSoBenhAn.Name = "labIDHoSoBenhAn";
            this.labIDHoSoBenhAn.Size = new System.Drawing.Size(109, 27);
            this.labIDHoSoBenhAn.TabIndex = 1;
            this.labIDHoSoBenhAn.Text = "ID Hồ Sơ:";
            // 
            // panelThongTinHoSoBenhAn
            // 
            this.panelThongTinHoSoBenhAn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelThongTinHoSoBenhAn.BackColor = System.Drawing.Color.SeaShell;
            this.panelThongTinHoSoBenhAn.Controls.Add(this.txtChuanDoan);
            this.panelThongTinHoSoBenhAn.Controls.Add(this.lblChuanDoan);
            this.panelThongTinHoSoBenhAn.Controls.Add(this.labNgayLap);
            this.panelThongTinHoSoBenhAn.Controls.Add(this.txtTienSuBenh);
            this.panelThongTinHoSoBenhAn.Controls.Add(this.dateTimePickerNgayLap);
            this.panelThongTinHoSoBenhAn.Controls.Add(this.txtTrieuChung);
            this.panelThongTinHoSoBenhAn.Controls.Add(this.labTienSuBenh);
            this.panelThongTinHoSoBenhAn.Controls.Add(this.labTrieuChung);
            this.panelThongTinHoSoBenhAn.Controls.Add(this.txtGhiChu);
            this.panelThongTinHoSoBenhAn.Controls.Add(this.txtIDBenhNhan);
            this.panelThongTinHoSoBenhAn.Controls.Add(this.txtIDHoSoBenhAn);
            this.panelThongTinHoSoBenhAn.Controls.Add(this.labGhiChu);
            this.panelThongTinHoSoBenhAn.Controls.Add(this.labIDBenhNhan);
            this.panelThongTinHoSoBenhAn.Controls.Add(this.labIDHoSoBenhAn);
            this.panelThongTinHoSoBenhAn.Location = new System.Drawing.Point(12, 122);
            this.panelThongTinHoSoBenhAn.Name = "panelThongTinHoSoBenhAn";
            this.panelThongTinHoSoBenhAn.Size = new System.Drawing.Size(794, 221);
            this.panelThongTinHoSoBenhAn.TabIndex = 36;
            // 
            // DgViewHoSoBenhAn
            // 
            this.DgViewHoSoBenhAn.AllowUserToOrderColumns = true;
            this.DgViewHoSoBenhAn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgViewHoSoBenhAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgViewHoSoBenhAn.BackgroundColor = System.Drawing.Color.White;
            this.DgViewHoSoBenhAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewHoSoBenhAn.Location = new System.Drawing.Point(3, 430);
            this.DgViewHoSoBenhAn.Name = "DgViewHoSoBenhAn";
            this.DgViewHoSoBenhAn.RowHeadersVisible = false;
            this.DgViewHoSoBenhAn.RowHeadersWidth = 62;
            this.DgViewHoSoBenhAn.RowTemplate.Height = 28;
            this.DgViewHoSoBenhAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgViewHoSoBenhAn.Size = new System.Drawing.Size(1113, 222);
            this.DgViewHoSoBenhAn.TabIndex = 35;
            // 
            // labDanhSachHoSoBenhAn
            // 
            this.labDanhSachHoSoBenhAn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDanhSachHoSoBenhAn.AutoSize = true;
            this.labDanhSachHoSoBenhAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labDanhSachHoSoBenhAn.Location = new System.Drawing.Point(3, 402);
            this.labDanhSachHoSoBenhAn.Name = "labDanhSachHoSoBenhAn";
            this.labDanhSachHoSoBenhAn.Size = new System.Drawing.Size(294, 26);
            this.labDanhSachHoSoBenhAn.TabIndex = 34;
            this.labDanhSachHoSoBenhAn.Text = "Danh Sách Hồ Sơ Bệnh Án:";
            // 
            // labQuanLyHoSoBenhAn
            // 
            this.labQuanLyHoSoBenhAn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labQuanLyHoSoBenhAn.AutoSize = true;
            this.labQuanLyHoSoBenhAn.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labQuanLyHoSoBenhAn.ForeColor = System.Drawing.Color.Black;
            this.labQuanLyHoSoBenhAn.Location = new System.Drawing.Point(391, 51);
            this.labQuanLyHoSoBenhAn.Name = "labQuanLyHoSoBenhAn";
            this.labQuanLyHoSoBenhAn.Size = new System.Drawing.Size(531, 45);
            this.labQuanLyHoSoBenhAn.TabIndex = 33;
            this.labQuanLyHoSoBenhAn.Text = "QUẢN LÝ HỒ SƠ BỆNH ÁN";
            this.labQuanLyHoSoBenhAn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlMedicalRecords
            // 
            this.pnlMedicalRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMedicalRecords.BackColor = System.Drawing.Color.SeaShell;
            this.pnlMedicalRecords.Controls.Add(this.panelNhomNut);
            this.pnlMedicalRecords.Controls.Add(this.panelThongTinHoSoBenhAn);
            this.pnlMedicalRecords.Controls.Add(this.DgViewHoSoBenhAn);
            this.pnlMedicalRecords.Controls.Add(this.labDanhSachHoSoBenhAn);
            this.pnlMedicalRecords.Controls.Add(this.labQuanLyHoSoBenhAn);
            this.pnlMedicalRecords.Location = new System.Drawing.Point(0, 1);
            this.pnlMedicalRecords.Name = "pnlMedicalRecords";
            this.pnlMedicalRecords.Size = new System.Drawing.Size(1119, 655);
            this.pnlMedicalRecords.TabIndex = 1;
            // 
            // Form_MedicalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1156, 608);
            this.Controls.Add(this.pnlMedicalRecords);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_MedicalRecords";
            this.Text = "QUẢN LÝ HỒ SƠ BỆNH ÁN";
            this.panelNhomNut.ResumeLayout(false);
            this.panelThongTinHoSoBenhAn.ResumeLayout(false);
            this.panelThongTinHoSoBenhAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewHoSoBenhAn)).EndInit();
            this.pnlMedicalRecords.ResumeLayout(false);
            this.pnlMedicalRecords.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panelNhomNut;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtChuanDoan;
        private System.Windows.Forms.Label lblChuanDoan;
        private System.Windows.Forms.Label labNgayLap;
        private System.Windows.Forms.TextBox txtTienSuBenh;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLap;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.Label labTienSuBenh;
        private System.Windows.Forms.Label labTrieuChung;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtIDBenhNhan;
        private System.Windows.Forms.TextBox txtIDHoSoBenhAn;
        private System.Windows.Forms.Label labGhiChu;
        private System.Windows.Forms.Label labIDBenhNhan;
        private System.Windows.Forms.Label labIDHoSoBenhAn;
        private System.Windows.Forms.Panel panelThongTinHoSoBenhAn;
        private System.Windows.Forms.DataGridView DgViewHoSoBenhAn;
        private System.Windows.Forms.Label labDanhSachHoSoBenhAn;
        private System.Windows.Forms.Label labQuanLyHoSoBenhAn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlMedicalRecords;
    }
}