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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MedicalRecords));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelNhomNut = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.DgViewHoSoBenhAn = new System.Windows.Forms.DataGridView();
            this.colHoSoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBenhNhanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrieuChung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienSuBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuanDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labDanhSachHoSoBenhAn = new System.Windows.Forms.Label();
            this.labQuanLyHoSoBenhAn = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBoxDieuTri = new System.Windows.Forms.GroupBox();
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
            this.panelNhomNut.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewHoSoBenhAn)).BeginInit();
            this.groupBoxDieuTri.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNhomNut
            // 
            this.panelNhomNut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelNhomNut.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelNhomNut.Controls.Add(this.groupBox1);
            this.panelNhomNut.Location = new System.Drawing.Point(871, 75);
            this.panelNhomNut.Name = "panelNhomNut";
            this.panelNhomNut.Size = new System.Drawing.Size(255, 221);
            this.panelNhomNut.TabIndex = 42;
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
            this.groupBox1.Size = new System.Drawing.Size(255, 221);
            this.groupBox1.TabIndex = 6;
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
            // DgViewHoSoBenhAn
            // 
            this.DgViewHoSoBenhAn.AllowUserToOrderColumns = true;
            this.DgViewHoSoBenhAn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgViewHoSoBenhAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgViewHoSoBenhAn.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgViewHoSoBenhAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgViewHoSoBenhAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewHoSoBenhAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHoSoID,
            this.colBenhNhanID,
            this.colNgayLap,
            this.colTrieuChung,
            this.colTienSuBenh,
            this.colChuanDoan,
            this.colGhiChu});
            this.DgViewHoSoBenhAn.Location = new System.Drawing.Point(22, 383);
            this.DgViewHoSoBenhAn.Name = "DgViewHoSoBenhAn";
            this.DgViewHoSoBenhAn.RowHeadersVisible = false;
            this.DgViewHoSoBenhAn.RowHeadersWidth = 62;
            this.DgViewHoSoBenhAn.RowTemplate.Height = 28;
            this.DgViewHoSoBenhAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgViewHoSoBenhAn.Size = new System.Drawing.Size(1113, 222);
            this.DgViewHoSoBenhAn.TabIndex = 40;
            this.DgViewHoSoBenhAn.SelectionChanged += new System.EventHandler(this.DgViewHoSoBenhAn_SelectionChanged);
            // 
            // colHoSoID
            // 
            this.colHoSoID.DataPropertyName = "HoSoID";
            this.colHoSoID.HeaderText = "Mã Hồ Sơ";
            this.colHoSoID.MinimumWidth = 6;
            this.colHoSoID.Name = "colHoSoID";
            // 
            // colBenhNhanID
            // 
            this.colBenhNhanID.DataPropertyName = "BenhNhanID";
            this.colBenhNhanID.HeaderText = "Mã Bệnh Nhân";
            this.colBenhNhanID.MinimumWidth = 6;
            this.colBenhNhanID.Name = "colBenhNhanID";
            // 
            // colNgayLap
            // 
            this.colNgayLap.DataPropertyName = "NgayLap";
            this.colNgayLap.HeaderText = "Ngày Lập";
            this.colNgayLap.MinimumWidth = 6;
            this.colNgayLap.Name = "colNgayLap";
            // 
            // colTrieuChung
            // 
            this.colTrieuChung.DataPropertyName = "TrieuChung";
            this.colTrieuChung.HeaderText = "Triệu Chứng";
            this.colTrieuChung.MinimumWidth = 6;
            this.colTrieuChung.Name = "colTrieuChung";
            // 
            // colTienSuBenh
            // 
            this.colTienSuBenh.DataPropertyName = "TienSuBenh";
            this.colTienSuBenh.HeaderText = "Tiền Sử Bệnh";
            this.colTienSuBenh.MinimumWidth = 6;
            this.colTienSuBenh.Name = "colTienSuBenh";
            // 
            // colChuanDoan
            // 
            this.colChuanDoan.DataPropertyName = "ChuanDoan";
            this.colChuanDoan.HeaderText = "Chuẩn Đoán";
            this.colChuanDoan.MinimumWidth = 6;
            this.colChuanDoan.Name = "colChuanDoan";
            // 
            // colGhiChu
            // 
            this.colGhiChu.DataPropertyName = "GhiChu";
            this.colGhiChu.HeaderText = "Ghi Chú";
            this.colGhiChu.MinimumWidth = 6;
            this.colGhiChu.Name = "colGhiChu";
            // 
            // labDanhSachHoSoBenhAn
            // 
            this.labDanhSachHoSoBenhAn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDanhSachHoSoBenhAn.AutoSize = true;
            this.labDanhSachHoSoBenhAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labDanhSachHoSoBenhAn.Location = new System.Drawing.Point(22, 355);
            this.labDanhSachHoSoBenhAn.Name = "labDanhSachHoSoBenhAn";
            this.labDanhSachHoSoBenhAn.Size = new System.Drawing.Size(240, 23);
            this.labDanhSachHoSoBenhAn.TabIndex = 39;
            this.labDanhSachHoSoBenhAn.Text = "Danh Sách Hồ Sơ Bệnh Án:";
            // 
            // labQuanLyHoSoBenhAn
            // 
            this.labQuanLyHoSoBenhAn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labQuanLyHoSoBenhAn.AutoSize = true;
            this.labQuanLyHoSoBenhAn.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labQuanLyHoSoBenhAn.ForeColor = System.Drawing.Color.Black;
            this.labQuanLyHoSoBenhAn.Location = new System.Drawing.Point(410, 4);
            this.labQuanLyHoSoBenhAn.Name = "labQuanLyHoSoBenhAn";
            this.labQuanLyHoSoBenhAn.Size = new System.Drawing.Size(436, 37);
            this.labQuanLyHoSoBenhAn.TabIndex = 38;
            this.labQuanLyHoSoBenhAn.Text = "QUẢN LÝ HỒ SƠ BỆNH ÁN";
            // 
            // txtTim
            // 
            this.txtTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTim.Location = new System.Drawing.Point(678, 322);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(345, 30);
            this.txtTim.TabIndex = 50;
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.ForeColor = System.Drawing.Color.Green;
            this.btnTim.Location = new System.Drawing.Point(1048, 325);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(79, 27);
            this.btnTim.TabIndex = 49;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupBoxDieuTri
            // 
            this.groupBoxDieuTri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDieuTri.Controls.Add(this.txtChuanDoan);
            this.groupBoxDieuTri.Controls.Add(this.lblChuanDoan);
            this.groupBoxDieuTri.Controls.Add(this.labNgayLap);
            this.groupBoxDieuTri.Controls.Add(this.txtTienSuBenh);
            this.groupBoxDieuTri.Controls.Add(this.dateTimePickerNgayLap);
            this.groupBoxDieuTri.Controls.Add(this.txtTrieuChung);
            this.groupBoxDieuTri.Controls.Add(this.labTienSuBenh);
            this.groupBoxDieuTri.Controls.Add(this.labTrieuChung);
            this.groupBoxDieuTri.Controls.Add(this.txtGhiChu);
            this.groupBoxDieuTri.Controls.Add(this.txtIDBenhNhan);
            this.groupBoxDieuTri.Controls.Add(this.txtIDHoSoBenhAn);
            this.groupBoxDieuTri.Controls.Add(this.labGhiChu);
            this.groupBoxDieuTri.Controls.Add(this.labIDBenhNhan);
            this.groupBoxDieuTri.Controls.Add(this.labIDHoSoBenhAn);
            this.groupBoxDieuTri.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxDieuTri.Location = new System.Drawing.Point(22, 75);
            this.groupBoxDieuTri.Name = "groupBoxDieuTri";
            this.groupBoxDieuTri.Size = new System.Drawing.Size(818, 206);
            this.groupBoxDieuTri.TabIndex = 51;
            this.groupBoxDieuTri.TabStop = false;
            this.groupBoxDieuTri.Text = "Thông tin:";
            // 
            // txtChuanDoan
            // 
            this.txtChuanDoan.Location = new System.Drawing.Point(152, 161);
            this.txtChuanDoan.Name = "txtChuanDoan";
            this.txtChuanDoan.Size = new System.Drawing.Size(227, 34);
            this.txtChuanDoan.TabIndex = 33;
            // 
            // lblChuanDoan
            // 
            this.lblChuanDoan.AutoSize = true;
            this.lblChuanDoan.Location = new System.Drawing.Point(47, 165);
            this.lblChuanDoan.Name = "lblChuanDoan";
            this.lblChuanDoan.Size = new System.Drawing.Size(136, 26);
            this.lblChuanDoan.TabIndex = 32;
            this.lblChuanDoan.Text = "Chuẩn Đoán:";
            // 
            // labNgayLap
            // 
            this.labNgayLap.AutoSize = true;
            this.labNgayLap.Location = new System.Drawing.Point(47, 126);
            this.labNgayLap.Name = "labNgayLap";
            this.labNgayLap.Size = new System.Drawing.Size(108, 26);
            this.labNgayLap.TabIndex = 25;
            this.labNgayLap.Text = "Ngày Lập:";
            // 
            // txtTienSuBenh
            // 
            this.txtTienSuBenh.Location = new System.Drawing.Point(550, 77);
            this.txtTienSuBenh.Name = "txtTienSuBenh";
            this.txtTienSuBenh.Size = new System.Drawing.Size(227, 34);
            this.txtTienSuBenh.TabIndex = 30;
            // 
            // dateTimePickerNgayLap
            // 
            this.dateTimePickerNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayLap.Location = new System.Drawing.Point(152, 121);
            this.dateTimePickerNgayLap.Name = "dateTimePickerNgayLap";
            this.dateTimePickerNgayLap.Size = new System.Drawing.Size(141, 34);
            this.dateTimePickerNgayLap.TabIndex = 31;
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Location = new System.Drawing.Point(550, 33);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(227, 34);
            this.txtTrieuChung.TabIndex = 29;
            // 
            // labTienSuBenh
            // 
            this.labTienSuBenh.AutoSize = true;
            this.labTienSuBenh.Location = new System.Drawing.Point(438, 81);
            this.labTienSuBenh.Name = "labTienSuBenh";
            this.labTienSuBenh.Size = new System.Drawing.Size(144, 26);
            this.labTienSuBenh.TabIndex = 23;
            this.labTienSuBenh.Text = "Tiền Sử Bệnh:";
            // 
            // labTrieuChung
            // 
            this.labTrieuChung.AutoSize = true;
            this.labTrieuChung.Location = new System.Drawing.Point(438, 37);
            this.labTrieuChung.Name = "labTrieuChung";
            this.labTrieuChung.Size = new System.Drawing.Size(135, 26);
            this.labTrieuChung.TabIndex = 22;
            this.labTrieuChung.Text = "Triệu Chứng:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(550, 123);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(227, 64);
            this.txtGhiChu.TabIndex = 28;
            // 
            // txtIDBenhNhan
            // 
            this.txtIDBenhNhan.Location = new System.Drawing.Point(152, 77);
            this.txtIDBenhNhan.Name = "txtIDBenhNhan";
            this.txtIDBenhNhan.Size = new System.Drawing.Size(227, 34);
            this.txtIDBenhNhan.TabIndex = 27;
            // 
            // txtIDHoSoBenhAn
            // 
            this.txtIDHoSoBenhAn.Location = new System.Drawing.Point(152, 33);
            this.txtIDHoSoBenhAn.Name = "txtIDHoSoBenhAn";
            this.txtIDHoSoBenhAn.Size = new System.Drawing.Size(227, 34);
            this.txtIDHoSoBenhAn.TabIndex = 26;
            // 
            // labGhiChu
            // 
            this.labGhiChu.AutoSize = true;
            this.labGhiChu.Location = new System.Drawing.Point(438, 127);
            this.labGhiChu.Name = "labGhiChu";
            this.labGhiChu.Size = new System.Drawing.Size(97, 26);
            this.labGhiChu.TabIndex = 24;
            this.labGhiChu.Text = "Ghi Chú:";
            // 
            // labIDBenhNhan
            // 
            this.labIDBenhNhan.AutoSize = true;
            this.labIDBenhNhan.Location = new System.Drawing.Point(47, 81);
            this.labIDBenhNhan.Name = "labIDBenhNhan";
            this.labIDBenhNhan.Size = new System.Drawing.Size(152, 26);
            this.labIDBenhNhan.TabIndex = 21;
            this.labIDBenhNhan.Text = "ID Bệnh Nhân:";
            // 
            // labIDHoSoBenhAn
            // 
            this.labIDHoSoBenhAn.AutoSize = true;
            this.labIDHoSoBenhAn.Location = new System.Drawing.Point(47, 37);
            this.labIDHoSoBenhAn.Name = "labIDHoSoBenhAn";
            this.labIDHoSoBenhAn.Size = new System.Drawing.Size(106, 26);
            this.labIDHoSoBenhAn.TabIndex = 20;
            this.labIDHoSoBenhAn.Text = "ID Hồ Sơ:";
            // 
            // Form_MedicalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1156, 608);
            this.Controls.Add(this.groupBoxDieuTri);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.panelNhomNut);
            this.Controls.Add(this.DgViewHoSoBenhAn);
            this.Controls.Add(this.labDanhSachHoSoBenhAn);
            this.Controls.Add(this.labQuanLyHoSoBenhAn);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_MedicalRecords";
            this.Text = "QUẢN LÝ HỒ SƠ BỆNH ÁN";
            this.Load += new System.EventHandler(this.Form_MedicalRecords_Load);
            this.panelNhomNut.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewHoSoBenhAn)).EndInit();
            this.groupBoxDieuTri.ResumeLayout(false);
            this.groupBoxDieuTri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelNhomNut;
        private System.Windows.Forms.DataGridView DgViewHoSoBenhAn;
        private System.Windows.Forms.Label labDanhSachHoSoBenhAn;
        private System.Windows.Forms.Label labQuanLyHoSoBenhAn;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoSoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBenhNhanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrieuChung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienSuBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuanDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.GroupBox groupBoxDieuTri;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}