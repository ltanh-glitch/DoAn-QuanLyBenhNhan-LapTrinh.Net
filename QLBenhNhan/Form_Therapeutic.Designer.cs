namespace QLBenhNhan
{
    partial class Form_Therapeutic
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
            this.labQuanLyDieuTri = new System.Windows.Forms.Label();
            this.labDanhSachDieuTri = new System.Windows.Forms.Label();
            this.DgViewDieuTri = new System.Windows.Forms.DataGridView();
            this.panelThongTinDieuTri = new System.Windows.Forms.Panel();
            this.labDDieuTri = new System.Windows.Forms.Label();
            this.labIDHoSo = new System.Windows.Forms.Label();
            this.labChiPhi = new System.Windows.Forms.Label();
            this.txtIDDieuTri = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtIDBacSi = new System.Windows.Forms.TextBox();
            this.labPhuongPhap = new System.Windows.Forms.Label();
            this.labKQ = new System.Windows.Forms.Label();
            this.labThuoc = new System.Windows.Forms.Label();
            this.txtPhuongPhap = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayDieuTri = new System.Windows.Forms.DateTimePicker();
            this.txtThuoc = new System.Windows.Forms.TextBox();
            this.labNgayDieuTri = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.lblBacSi = new System.Windows.Forms.Label();
            this.panelNhomNut = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnlTherapeutic = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtChiPhi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewDieuTri)).BeginInit();
            this.panelThongTinDieuTri.SuspendLayout();
            this.panelNhomNut.SuspendLayout();
            this.pnlTherapeutic.SuspendLayout();
            this.SuspendLayout();
            // 
            // labQuanLyDieuTri
            // 
            this.labQuanLyDieuTri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labQuanLyDieuTri.AutoSize = true;
            this.labQuanLyDieuTri.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labQuanLyDieuTri.ForeColor = System.Drawing.Color.Black;
            this.labQuanLyDieuTri.Location = new System.Drawing.Point(391, 51);
            this.labQuanLyDieuTri.Name = "labQuanLyDieuTri";
            this.labQuanLyDieuTri.Size = new System.Drawing.Size(396, 45);
            this.labQuanLyDieuTri.TabIndex = 33;
            this.labQuanLyDieuTri.Text = "QUẢN LÝ ĐIỀU TRỊ";
            this.labQuanLyDieuTri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labDanhSachDieuTri
            // 
            this.labDanhSachDieuTri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDanhSachDieuTri.AutoSize = true;
            this.labDanhSachDieuTri.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labDanhSachDieuTri.Location = new System.Drawing.Point(3, 371);
            this.labDanhSachDieuTri.Name = "labDanhSachDieuTri";
            this.labDanhSachDieuTri.Size = new System.Drawing.Size(221, 26);
            this.labDanhSachDieuTri.TabIndex = 34;
            this.labDanhSachDieuTri.Text = "Danh Sách Điều Trị:";
            // 
            // DgViewDieuTri
            // 
            this.DgViewDieuTri.AllowUserToOrderColumns = true;
            this.DgViewDieuTri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgViewDieuTri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgViewDieuTri.BackgroundColor = System.Drawing.Color.White;
            this.DgViewDieuTri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewDieuTri.Location = new System.Drawing.Point(3, 399);
            this.DgViewDieuTri.Name = "DgViewDieuTri";
            this.DgViewDieuTri.RowHeadersVisible = false;
            this.DgViewDieuTri.RowHeadersWidth = 62;
            this.DgViewDieuTri.RowTemplate.Height = 28;
            this.DgViewDieuTri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgViewDieuTri.Size = new System.Drawing.Size(1113, 222);
            this.DgViewDieuTri.TabIndex = 35;
            // 
            // panelThongTinDieuTri
            // 
            this.panelThongTinDieuTri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelThongTinDieuTri.BackColor = System.Drawing.Color.SeaShell;
            this.panelThongTinDieuTri.Controls.Add(this.txtChiPhi);
            this.panelThongTinDieuTri.Controls.Add(this.lblBacSi);
            this.panelThongTinDieuTri.Controls.Add(this.txtKQ);
            this.panelThongTinDieuTri.Controls.Add(this.labNgayDieuTri);
            this.panelThongTinDieuTri.Controls.Add(this.txtThuoc);
            this.panelThongTinDieuTri.Controls.Add(this.dateTimePickerNgayDieuTri);
            this.panelThongTinDieuTri.Controls.Add(this.txtPhuongPhap);
            this.panelThongTinDieuTri.Controls.Add(this.labThuoc);
            this.panelThongTinDieuTri.Controls.Add(this.labKQ);
            this.panelThongTinDieuTri.Controls.Add(this.labPhuongPhap);
            this.panelThongTinDieuTri.Controls.Add(this.txtIDBacSi);
            this.panelThongTinDieuTri.Controls.Add(this.txtHoTen);
            this.panelThongTinDieuTri.Controls.Add(this.txtIDDieuTri);
            this.panelThongTinDieuTri.Controls.Add(this.labChiPhi);
            this.panelThongTinDieuTri.Controls.Add(this.labIDHoSo);
            this.panelThongTinDieuTri.Controls.Add(this.labDDieuTri);
            this.panelThongTinDieuTri.Location = new System.Drawing.Point(12, 91);
            this.panelThongTinDieuTri.Name = "panelThongTinDieuTri";
            this.panelThongTinDieuTri.Size = new System.Drawing.Size(794, 221);
            this.panelThongTinDieuTri.TabIndex = 36;
            // 
            // labDDieuTri
            // 
            this.labDDieuTri.AutoSize = true;
            this.labDDieuTri.Location = new System.Drawing.Point(13, 18);
            this.labDDieuTri.Name = "labDDieuTri";
            this.labDDieuTri.Size = new System.Drawing.Size(117, 27);
            this.labDDieuTri.TabIndex = 1;
            this.labDDieuTri.Text = "ID điều trị:";
            // 
            // labIDHoSo
            // 
            this.labIDHoSo.AutoSize = true;
            this.labIDHoSo.Location = new System.Drawing.Point(13, 62);
            this.labIDHoSo.Name = "labIDHoSo";
            this.labIDHoSo.Size = new System.Drawing.Size(109, 27);
            this.labIDHoSo.TabIndex = 2;
            this.labIDHoSo.Text = "ID Hồ Sơ:";
            // 
            // labChiPhi
            // 
            this.labChiPhi.AutoSize = true;
            this.labChiPhi.Location = new System.Drawing.Point(404, 108);
            this.labChiPhi.Name = "labChiPhi";
            this.labChiPhi.Size = new System.Drawing.Size(88, 27);
            this.labChiPhi.TabIndex = 6;
            this.labChiPhi.Text = "Chi phí:";
            // 
            // txtIDDieuTri
            // 
            this.txtIDDieuTri.Location = new System.Drawing.Point(118, 14);
            this.txtIDDieuTri.Name = "txtIDDieuTri";
            this.txtIDDieuTri.Size = new System.Drawing.Size(227, 35);
            this.txtIDDieuTri.TabIndex = 9;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(118, 58);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(227, 35);
            this.txtHoTen.TabIndex = 10;
            // 
            // txtIDBacSi
            // 
            this.txtIDBacSi.Location = new System.Drawing.Point(118, 101);
            this.txtIDBacSi.Name = "txtIDBacSi";
            this.txtIDBacSi.Size = new System.Drawing.Size(227, 35);
            this.txtIDBacSi.TabIndex = 12;
            // 
            // labPhuongPhap
            // 
            this.labPhuongPhap.AutoSize = true;
            this.labPhuongPhap.Location = new System.Drawing.Point(404, 18);
            this.labPhuongPhap.Name = "labPhuongPhap";
            this.labPhuongPhap.Size = new System.Drawing.Size(146, 27);
            this.labPhuongPhap.TabIndex = 4;
            this.labPhuongPhap.Text = "Phương pháp:";
            // 
            // labKQ
            // 
            this.labKQ.AutoSize = true;
            this.labKQ.Location = new System.Drawing.Point(404, 146);
            this.labKQ.Name = "labKQ";
            this.labKQ.Size = new System.Drawing.Size(94, 27);
            this.labKQ.TabIndex = 8;
            this.labKQ.Text = "Kết quả:";
            // 
            // labThuoc
            // 
            this.labThuoc.AutoSize = true;
            this.labThuoc.Location = new System.Drawing.Point(404, 62);
            this.labThuoc.Name = "labThuoc";
            this.labThuoc.Size = new System.Drawing.Size(79, 27);
            this.labThuoc.TabIndex = 5;
            this.labThuoc.Text = "Thuốc:";
            // 
            // txtPhuongPhap
            // 
            this.txtPhuongPhap.Location = new System.Drawing.Point(516, 14);
            this.txtPhuongPhap.Name = "txtPhuongPhap";
            this.txtPhuongPhap.Size = new System.Drawing.Size(227, 35);
            this.txtPhuongPhap.TabIndex = 13;
            // 
            // dateTimePickerNgayDieuTri
            // 
            this.dateTimePickerNgayDieuTri.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayDieuTri.Location = new System.Drawing.Point(136, 153);
            this.dateTimePickerNgayDieuTri.Name = "dateTimePickerNgayDieuTri";
            this.dateTimePickerNgayDieuTri.Size = new System.Drawing.Size(141, 35);
            this.dateTimePickerNgayDieuTri.TabIndex = 15;
            // 
            // txtThuoc
            // 
            this.txtThuoc.Location = new System.Drawing.Point(516, 58);
            this.txtThuoc.Name = "txtThuoc";
            this.txtThuoc.Size = new System.Drawing.Size(227, 35);
            this.txtThuoc.TabIndex = 14;
            // 
            // labNgayDieuTri
            // 
            this.labNgayDieuTri.AutoSize = true;
            this.labNgayDieuTri.Location = new System.Drawing.Point(13, 159);
            this.labNgayDieuTri.Name = "labNgayDieuTri";
            this.labNgayDieuTri.Size = new System.Drawing.Size(143, 27);
            this.labNgayDieuTri.TabIndex = 7;
            this.labNgayDieuTri.Text = "Ngày điều trị:";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(516, 142);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(227, 35);
            this.txtKQ.TabIndex = 11;
            // 
            // lblBacSi
            // 
            this.lblBacSi.AutoSize = true;
            this.lblBacSi.Location = new System.Drawing.Point(13, 108);
            this.lblBacSi.Name = "lblBacSi";
            this.lblBacSi.Size = new System.Drawing.Size(111, 27);
            this.lblBacSi.TabIndex = 18;
            this.lblBacSi.Text = "ID Bác Sĩ:";
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
            this.panelNhomNut.Location = new System.Drawing.Point(852, 91);
            this.panelNhomNut.Name = "panelNhomNut";
            this.panelNhomNut.Size = new System.Drawing.Size(255, 186);
            this.panelNhomNut.TabIndex = 37;
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
            // pnlTherapeutic
            // 
            this.pnlTherapeutic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTherapeutic.BackColor = System.Drawing.Color.SeaShell;
            this.pnlTherapeutic.Controls.Add(this.panelNhomNut);
            this.pnlTherapeutic.Controls.Add(this.panelThongTinDieuTri);
            this.pnlTherapeutic.Controls.Add(this.DgViewDieuTri);
            this.pnlTherapeutic.Controls.Add(this.labDanhSachDieuTri);
            this.pnlTherapeutic.Controls.Add(this.labQuanLyDieuTri);
            this.pnlTherapeutic.Location = new System.Drawing.Point(2, 3);
            this.pnlTherapeutic.Name = "pnlTherapeutic";
            this.pnlTherapeutic.Size = new System.Drawing.Size(1119, 593);
            this.pnlTherapeutic.TabIndex = 1;
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.Location = new System.Drawing.Point(516, 99);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(227, 35);
            this.txtChiPhi.TabIndex = 19;
            // 
            // Form_Therapeutic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 608);
            this.Controls.Add(this.pnlTherapeutic);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Therapeutic";
            this.Text = "QUẢN LÝ ĐIỀU TRỊ ";
            ((System.ComponentModel.ISupportInitialize)(this.DgViewDieuTri)).EndInit();
            this.panelThongTinDieuTri.ResumeLayout(false);
            this.panelThongTinDieuTri.PerformLayout();
            this.panelNhomNut.ResumeLayout(false);
            this.pnlTherapeutic.ResumeLayout(false);
            this.pnlTherapeutic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labQuanLyDieuTri;
        private System.Windows.Forms.Label labDanhSachDieuTri;
        private System.Windows.Forms.DataGridView DgViewDieuTri;
        private System.Windows.Forms.Panel panelThongTinDieuTri;
        private System.Windows.Forms.Label lblBacSi;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label labNgayDieuTri;
        private System.Windows.Forms.TextBox txtThuoc;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayDieuTri;
        private System.Windows.Forms.TextBox txtPhuongPhap;
        private System.Windows.Forms.Label labThuoc;
        private System.Windows.Forms.Label labKQ;
        private System.Windows.Forms.Label labPhuongPhap;
        private System.Windows.Forms.TextBox txtIDBacSi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtIDDieuTri;
        private System.Windows.Forms.Label labChiPhi;
        private System.Windows.Forms.Label labIDHoSo;
        private System.Windows.Forms.Label labDDieuTri;
        private System.Windows.Forms.Panel panelNhomNut;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel pnlTherapeutic;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtChiPhi;
    }
}