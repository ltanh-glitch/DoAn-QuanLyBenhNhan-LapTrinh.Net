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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Doctor));
            this.panelNhomNut = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
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
            this.groupBoxDieuTri = new System.Windows.Forms.GroupBox();
            this.txtTrinhDo = new System.Windows.Forms.TextBox();
            this.cboChuyenKhoa = new System.Windows.Forms.ComboBox();
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
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.panelNhomNut.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewBacSi)).BeginInit();
            this.pnlDoctor.SuspendLayout();
            this.groupBoxDieuTri.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNhomNut
            // 
            this.panelNhomNut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelNhomNut.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelNhomNut.Controls.Add(this.groupBox1);
            this.panelNhomNut.Location = new System.Drawing.Point(870, 99);
            this.panelNhomNut.Name = "panelNhomNut";
            this.panelNhomNut.Size = new System.Drawing.Size(255, 213);
            this.panelNhomNut.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 213);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng:";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(134, 159);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 49);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = " &Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(134, 96);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(101, 49);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = " &Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(25, 34);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 49);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = " &Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(134, 34);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(101, 49);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = " &Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(25, 97);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 49);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = " &Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(25, 159);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 49);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = " &Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.pnlDoctor.Controls.Add(this.groupBoxDieuTri);
            this.pnlDoctor.Controls.Add(this.txtTim);
            this.pnlDoctor.Controls.Add(this.btnTim);
            this.pnlDoctor.Controls.Add(this.panelNhomNut);
            this.pnlDoctor.Controls.Add(this.DgViewBacSi);
            this.pnlDoctor.Controls.Add(this.labDanhSachBacSi);
            this.pnlDoctor.Controls.Add(this.labQuanLyBacSi);
            this.pnlDoctor.Location = new System.Drawing.Point(1, 1);
            this.pnlDoctor.Name = "pnlDoctor";
            this.pnlDoctor.Size = new System.Drawing.Size(1155, 608);
            this.pnlDoctor.TabIndex = 1;
            // 
            // groupBoxDieuTri
            // 
            this.groupBoxDieuTri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDieuTri.Controls.Add(this.txtTrinhDo);
            this.groupBoxDieuTri.Controls.Add(this.cboChuyenKhoa);
            this.groupBoxDieuTri.Controls.Add(this.txtEmail);
            this.groupBoxDieuTri.Controls.Add(this.lblEmail);
            this.groupBoxDieuTri.Controls.Add(this.txtSĐT);
            this.groupBoxDieuTri.Controls.Add(this.labSĐT);
            this.groupBoxDieuTri.Controls.Add(this.labChuyenKhoa);
            this.groupBoxDieuTri.Controls.Add(this.txtHoTen);
            this.groupBoxDieuTri.Controls.Add(this.txtIDBacSi);
            this.groupBoxDieuTri.Controls.Add(this.labTrinhDo);
            this.groupBoxDieuTri.Controls.Add(this.labHoTen);
            this.groupBoxDieuTri.Controls.Add(this.labIDBacSi);
            this.groupBoxDieuTri.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxDieuTri.Location = new System.Drawing.Point(30, 99);
            this.groupBoxDieuTri.Name = "groupBoxDieuTri";
            this.groupBoxDieuTri.Size = new System.Drawing.Size(818, 206);
            this.groupBoxDieuTri.TabIndex = 48;
            this.groupBoxDieuTri.TabStop = false;
            this.groupBoxDieuTri.Text = "Thông tin:";
            // 
            // txtTrinhDo
            // 
            this.txtTrinhDo.Location = new System.Drawing.Point(547, 154);
            this.txtTrinhDo.Name = "txtTrinhDo";
            this.txtTrinhDo.Size = new System.Drawing.Size(227, 34);
            this.txtTrinhDo.TabIndex = 34;
            // 
            // cboChuyenKhoa
            // 
            this.cboChuyenKhoa.FormattingEnabled = true;
            this.cboChuyenKhoa.Location = new System.Drawing.Point(547, 55);
            this.cboChuyenKhoa.Name = "cboChuyenKhoa";
            this.cboChuyenKhoa.Size = new System.Drawing.Size(228, 34);
            this.cboChuyenKhoa.TabIndex = 33;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(149, 154);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 34);
            this.txtEmail.TabIndex = 32;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(44, 157);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 26);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Email:";
            // 
            // txtSĐT
            // 
            this.txtSĐT.Location = new System.Drawing.Point(547, 107);
            this.txtSĐT.Name = "txtSĐT";
            this.txtSĐT.Size = new System.Drawing.Size(227, 34);
            this.txtSĐT.TabIndex = 30;
            // 
            // labSĐT
            // 
            this.labSĐT.AutoSize = true;
            this.labSĐT.Location = new System.Drawing.Point(435, 111);
            this.labSĐT.Name = "labSĐT";
            this.labSĐT.Size = new System.Drawing.Size(61, 26);
            this.labSĐT.TabIndex = 26;
            this.labSĐT.Text = "SĐT:";
            // 
            // labChuyenKhoa
            // 
            this.labChuyenKhoa.AutoSize = true;
            this.labChuyenKhoa.Location = new System.Drawing.Point(435, 58);
            this.labChuyenKhoa.Name = "labChuyenKhoa";
            this.labChuyenKhoa.Size = new System.Drawing.Size(147, 26);
            this.labChuyenKhoa.TabIndex = 25;
            this.labChuyenKhoa.Text = "Chuyên Khoa:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(149, 107);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(227, 34);
            this.txtHoTen.TabIndex = 29;
            // 
            // txtIDBacSi
            // 
            this.txtIDBacSi.Location = new System.Drawing.Point(149, 55);
            this.txtIDBacSi.Name = "txtIDBacSi";
            this.txtIDBacSi.Size = new System.Drawing.Size(227, 34);
            this.txtIDBacSi.TabIndex = 28;
            // 
            // labTrinhDo
            // 
            this.labTrinhDo.AutoSize = true;
            this.labTrinhDo.Location = new System.Drawing.Point(435, 157);
            this.labTrinhDo.Name = "labTrinhDo";
            this.labTrinhDo.Size = new System.Drawing.Size(104, 26);
            this.labTrinhDo.TabIndex = 27;
            this.labTrinhDo.Text = "Trình Độ:";
            // 
            // labHoTen
            // 
            this.labHoTen.AutoSize = true;
            this.labHoTen.Location = new System.Drawing.Point(44, 111);
            this.labHoTen.Name = "labHoTen";
            this.labHoTen.Size = new System.Drawing.Size(121, 26);
            this.labHoTen.TabIndex = 24;
            this.labHoTen.Text = "Họ và  Tên:";
            // 
            // labIDBacSi
            // 
            this.labIDBacSi.AutoSize = true;
            this.labIDBacSi.Location = new System.Drawing.Point(44, 63);
            this.labIDBacSi.Name = "labIDBacSi";
            this.labIDBacSi.Size = new System.Drawing.Size(103, 26);
            this.labIDBacSi.TabIndex = 23;
            this.labIDBacSi.Text = "ID Bác sĩ:";
            // 
            // txtTim
            // 
            this.txtTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTim.Location = new System.Drawing.Point(682, 348);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(345, 30);
            this.txtTim.TabIndex = 46;
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.ForeColor = System.Drawing.Color.Green;
            this.btnTim.Location = new System.Drawing.Point(1050, 348);
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
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewBacSi)).EndInit();
            this.pnlDoctor.ResumeLayout(false);
            this.pnlDoctor.PerformLayout();
            this.groupBoxDieuTri.ResumeLayout(false);
            this.groupBoxDieuTri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelNhomNut;
        private System.Windows.Forms.DataGridView DgViewBacSi;
        private System.Windows.Forms.Label labDanhSachBacSi;
        private System.Windows.Forms.Label labQuanLyBacSi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlDoctor;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBacSiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenChuyenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrinhDo;
        private System.Windows.Forms.GroupBox groupBoxDieuTri;
        private System.Windows.Forms.TextBox txtTrinhDo;
        private System.Windows.Forms.ComboBox cboChuyenKhoa;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}