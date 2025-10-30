namespace QLBenhNhan
{
    partial class Form_Doctor
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSĐT = new System.Windows.Forms.TextBox();
            this.labSĐT = new System.Windows.Forms.Label();
            this.labChuyenKhoa = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtIDBacSi = new System.Windows.Forms.TextBox();
            this.labTrinhDo = new System.Windows.Forms.Label();
            this.labHoTen = new System.Windows.Forms.Label();
            this.labIDBacSi = new System.Windows.Forms.Label();
            this.panelThongTinBacSi = new System.Windows.Forms.Panel();
            this.txtTrinhDo = new System.Windows.Forms.TextBox();
            this.cboChuyenKhoa = new System.Windows.Forms.ComboBox();
            this.DgViewBacSi = new System.Windows.Forms.DataGridView();
            this.colBacSiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenChuyenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labDanhSachBacSi = new System.Windows.Forms.Label();
            this.labQuanLyBacSi = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlDoctor = new System.Windows.Forms.Panel();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.panelNhomNut.SuspendLayout();
            this.panelThongTinBacSi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewBacSi)).BeginInit();
            this.pnlDoctor.SuspendLayout();
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
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelNhomNut
            // 
            this.panelNhomNut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelNhomNut.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelNhomNut.Controls.Add(this.btnThoat);
            this.panelNhomNut.Controls.Add(this.btnHuy);
            this.panelNhomNut.Controls.Add(this.btnLuu);
            this.panelNhomNut.Controls.Add(this.btnXoa);
            this.panelNhomNut.Controls.Add(this.btnSua);
            this.panelNhomNut.Controls.Add(this.btnThem);
            this.panelNhomNut.Location = new System.Drawing.Point(870, 99);
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
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(118, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 30);
            this.txtEmail.TabIndex = 19;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 108);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 22);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // txtSĐT
            // 
            this.txtSĐT.Location = new System.Drawing.Point(516, 58);
            this.txtSĐT.Name = "txtSĐT";
            this.txtSĐT.Size = new System.Drawing.Size(227, 30);
            this.txtSĐT.TabIndex = 14;
            // 
            // labSĐT
            // 
            this.labSĐT.AutoSize = true;
            this.labSĐT.Location = new System.Drawing.Point(404, 62);
            this.labSĐT.Name = "labSĐT";
            this.labSĐT.Size = new System.Drawing.Size(52, 22);
            this.labSĐT.TabIndex = 5;
            this.labSĐT.Text = "SĐT:";
            // 
            // labChuyenKhoa
            // 
            this.labChuyenKhoa.AutoSize = true;
            this.labChuyenKhoa.Location = new System.Drawing.Point(404, 18);
            this.labChuyenKhoa.Name = "labChuyenKhoa";
            this.labChuyenKhoa.Size = new System.Drawing.Size(121, 22);
            this.labChuyenKhoa.TabIndex = 4;
            this.labChuyenKhoa.Text = "Chuyên Khoa:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(118, 58);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(227, 30);
            this.txtHoTen.TabIndex = 10;
            // 
            // txtIDBacSi
            // 
            this.txtIDBacSi.Location = new System.Drawing.Point(118, 14);
            this.txtIDBacSi.Name = "txtIDBacSi";
            this.txtIDBacSi.Size = new System.Drawing.Size(227, 30);
            this.txtIDBacSi.TabIndex = 9;
            // 
            // labTrinhDo
            // 
            this.labTrinhDo.AutoSize = true;
            this.labTrinhDo.Location = new System.Drawing.Point(404, 108);
            this.labTrinhDo.Name = "labTrinhDo";
            this.labTrinhDo.Size = new System.Drawing.Size(87, 22);
            this.labTrinhDo.TabIndex = 6;
            this.labTrinhDo.Text = "Trình Độ:";
            // 
            // labHoTen
            // 
            this.labHoTen.AutoSize = true;
            this.labHoTen.Location = new System.Drawing.Point(13, 62);
            this.labHoTen.Name = "labHoTen";
            this.labHoTen.Size = new System.Drawing.Size(104, 22);
            this.labHoTen.TabIndex = 2;
            this.labHoTen.Text = "Họ và  Tên:";
            // 
            // labIDBacSi
            // 
            this.labIDBacSi.AutoSize = true;
            this.labIDBacSi.Location = new System.Drawing.Point(13, 18);
            this.labIDBacSi.Name = "labIDBacSi";
            this.labIDBacSi.Size = new System.Drawing.Size(91, 22);
            this.labIDBacSi.TabIndex = 1;
            this.labIDBacSi.Text = "ID Bác sĩ:";
            // 
            // panelThongTinBacSi
            // 
            this.panelThongTinBacSi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelThongTinBacSi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelThongTinBacSi.Controls.Add(this.txtTrinhDo);
            this.panelThongTinBacSi.Controls.Add(this.cboChuyenKhoa);
            this.panelThongTinBacSi.Controls.Add(this.txtEmail);
            this.panelThongTinBacSi.Controls.Add(this.lblEmail);
            this.panelThongTinBacSi.Controls.Add(this.txtSĐT);
            this.panelThongTinBacSi.Controls.Add(this.labSĐT);
            this.panelThongTinBacSi.Controls.Add(this.labChuyenKhoa);
            this.panelThongTinBacSi.Controls.Add(this.txtHoTen);
            this.panelThongTinBacSi.Controls.Add(this.txtIDBacSi);
            this.panelThongTinBacSi.Controls.Add(this.labTrinhDo);
            this.panelThongTinBacSi.Controls.Add(this.labHoTen);
            this.panelThongTinBacSi.Controls.Add(this.labIDBacSi);
            this.panelThongTinBacSi.Location = new System.Drawing.Point(30, 99);
            this.panelThongTinBacSi.Name = "panelThongTinBacSi";
            this.panelThongTinBacSi.Size = new System.Drawing.Size(794, 221);
            this.panelThongTinBacSi.TabIndex = 36;
            // 
            // txtTrinhDo
            // 
            this.txtTrinhDo.Location = new System.Drawing.Point(516, 105);
            this.txtTrinhDo.Name = "txtTrinhDo";
            this.txtTrinhDo.Size = new System.Drawing.Size(227, 30);
            this.txtTrinhDo.TabIndex = 22;
            // 
            // cboChuyenKhoa
            // 
            this.cboChuyenKhoa.FormattingEnabled = true;
            this.cboChuyenKhoa.Location = new System.Drawing.Point(516, 15);
            this.cboChuyenKhoa.Name = "cboChuyenKhoa";
            this.cboChuyenKhoa.Size = new System.Drawing.Size(228, 30);
            this.cboChuyenKhoa.TabIndex = 21;
            // 
            // DgViewBacSi
            // 
            this.DgViewBacSi.AllowUserToOrderColumns = true;
            this.DgViewBacSi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgViewBacSi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgViewBacSi.BackgroundColor = System.Drawing.Color.White;
            this.DgViewBacSi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewBacSi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBacSiID,
            this.colHoTen,
            this.colTenChuyenKhoa,
            this.colSDT,
            this.colEmail,
            this.colTrinhDo});
            this.DgViewBacSi.Location = new System.Drawing.Point(21, 407);
            this.DgViewBacSi.Name = "DgViewBacSi";
            this.DgViewBacSi.RowHeadersVisible = false;
            this.DgViewBacSi.RowHeadersWidth = 62;
            this.DgViewBacSi.RowTemplate.Height = 28;
            this.DgViewBacSi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgViewBacSi.Size = new System.Drawing.Size(1113, 222);
            this.DgViewBacSi.TabIndex = 35;
            this.DgViewBacSi.SelectionChanged += new System.EventHandler(this.DgViewBacSi_SelectionChanged);
            // 
            // colBacSiID
            // 
            this.colBacSiID.DataPropertyName = "BacSiID";
            this.colBacSiID.HeaderText = "Mã Bác Sĩ";
            this.colBacSiID.MinimumWidth = 6;
            this.colBacSiID.Name = "colBacSiID";
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ và Tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            // 
            // colTenChuyenKhoa
            // 
            this.colTenChuyenKhoa.DataPropertyName = "TenChuyenKhoa";
            this.colTenChuyenKhoa.HeaderText = "Chuyên Khoa";
            this.colTenChuyenKhoa.MinimumWidth = 6;
            this.colTenChuyenKhoa.Name = "colTenChuyenKhoa";
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "SDT";
            this.colSDT.HeaderText = "Số Điện Thoại";
            this.colSDT.MinimumWidth = 6;
            this.colSDT.Name = "colSDT";
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            // 
            // colTrinhDo
            // 
            this.colTrinhDo.DataPropertyName = "TrinhDo";
            this.colTrinhDo.HeaderText = "Trình Độ";
            this.colTrinhDo.MinimumWidth = 6;
            this.colTrinhDo.Name = "colTrinhDo";
            // 
            // labDanhSachBacSi
            // 
            this.labDanhSachBacSi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDanhSachBacSi.AutoSize = true;
            this.labDanhSachBacSi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labDanhSachBacSi.Location = new System.Drawing.Point(21, 379);
            this.labDanhSachBacSi.Name = "labDanhSachBacSi";
            this.labDanhSachBacSi.Size = new System.Drawing.Size(164, 23);
            this.labDanhSachBacSi.TabIndex = 34;
            this.labDanhSachBacSi.Text = "Danh Sách Bác Sĩ:";
            // 
            // labQuanLyBacSi
            // 
            this.labQuanLyBacSi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labQuanLyBacSi.AutoSize = true;
            this.labQuanLyBacSi.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labQuanLyBacSi.ForeColor = System.Drawing.Color.Black;
            this.labQuanLyBacSi.Location = new System.Drawing.Point(414, 20);
            this.labQuanLyBacSi.Name = "labQuanLyBacSi";
            this.labQuanLyBacSi.Size = new System.Drawing.Size(283, 37);
            this.labQuanLyBacSi.TabIndex = 33;
            this.labQuanLyBacSi.Text = "QUẢN LÝ BÁC SĨ";
            this.labQuanLyBacSi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlDoctor
            // 
            this.pnlDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDoctor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlDoctor.Controls.Add(this.txtTim);
            this.pnlDoctor.Controls.Add(this.btnTim);
            this.pnlDoctor.Controls.Add(this.panelNhomNut);
            this.pnlDoctor.Controls.Add(this.panelThongTinBacSi);
            this.pnlDoctor.Controls.Add(this.DgViewBacSi);
            this.pnlDoctor.Controls.Add(this.labDanhSachBacSi);
            this.pnlDoctor.Controls.Add(this.labQuanLyBacSi);
            this.pnlDoctor.Location = new System.Drawing.Point(1, 1);
            this.pnlDoctor.Name = "pnlDoctor";
            this.pnlDoctor.Size = new System.Drawing.Size(1155, 608);
            this.pnlDoctor.TabIndex = 1;
            // 
            // txtTim
            // 
            this.txtTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTim.Location = new System.Drawing.Point(30, 346);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(345, 30);
            this.txtTim.TabIndex = 46;
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.ForeColor = System.Drawing.Color.Blue;
            this.btnTim.Location = new System.Drawing.Point(398, 346);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(79, 27);
            this.btnTim.TabIndex = 45;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // Form_Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 608);
            this.Controls.Add(this.pnlDoctor);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Doctor";
            this.Text = "Quản Lý Bác Sĩ";
            this.Load += new System.EventHandler(this.Form_Doctor_Load);
            this.panelNhomNut.ResumeLayout(false);
            this.panelThongTinBacSi.ResumeLayout(false);
            this.panelThongTinBacSi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewBacSi)).EndInit();
            this.pnlDoctor.ResumeLayout(false);
            this.pnlDoctor.PerformLayout();
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
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSĐT;
        private System.Windows.Forms.Label labSĐT;
        private System.Windows.Forms.Label labChuyenKhoa;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtIDBacSi;
        private System.Windows.Forms.Label labTrinhDo;
        private System.Windows.Forms.Label labHoTen;
        private System.Windows.Forms.Label labIDBacSi;
        private System.Windows.Forms.Panel panelThongTinBacSi;
        private System.Windows.Forms.DataGridView DgViewBacSi;
        private System.Windows.Forms.Label labDanhSachBacSi;
        private System.Windows.Forms.Label labQuanLyBacSi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlDoctor;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cboChuyenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBacSiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenChuyenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrinhDo;
        private System.Windows.Forms.TextBox txtTrinhDo;
    }
}