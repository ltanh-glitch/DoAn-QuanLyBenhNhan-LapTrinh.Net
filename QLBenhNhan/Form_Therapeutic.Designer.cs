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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Therapeutic));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DgViewDieuTri = new System.Windows.Forms.DataGridView();
            this.colDieuTriID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoSoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBacSiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDieuTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhuongPhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labDanhSachDieuTri = new System.Windows.Forms.Label();
            this.labQuanLyDieuTri = new System.Windows.Forms.Label();
            this.panelNhomNut = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBoxDieuTri = new System.Windows.Forms.GroupBox();
            this.txtIDHoSo = new System.Windows.Forms.TextBox();
            this.txtChiPhi = new System.Windows.Forms.TextBox();
            this.lblBacSi = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.labNgayDieuTri = new System.Windows.Forms.Label();
            this.txtThuoc = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayDieuTri = new System.Windows.Forms.DateTimePicker();
            this.txtPhuongPhap = new System.Windows.Forms.TextBox();
            this.labThuoc = new System.Windows.Forms.Label();
            this.labKQ = new System.Windows.Forms.Label();
            this.labPhuongPhap = new System.Windows.Forms.Label();
            this.txtIDBacSi = new System.Windows.Forms.TextBox();
            this.txtIDDieuTri = new System.Windows.Forms.TextBox();
            this.labChiPhi = new System.Windows.Forms.Label();
            this.labIDHoSo = new System.Windows.Forms.Label();
            this.labDDieuTri = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewDieuTri)).BeginInit();
            this.panelNhomNut.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxDieuTri.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgViewDieuTri
            // 
            this.DgViewDieuTri.AllowUserToOrderColumns = true;
            this.DgViewDieuTri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgViewDieuTri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgViewDieuTri.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgViewDieuTri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgViewDieuTri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewDieuTri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDieuTriID,
            this.colHoSoID,
            this.colBacSiID,
            this.colNgayDieuTri,
            this.colPhuongPhap,
            this.colThuoc,
            this.colChiPhi,
            this.colKetQua});
            this.DgViewDieuTri.Location = new System.Drawing.Point(22, 367);
            this.DgViewDieuTri.Name = "DgViewDieuTri";
            this.DgViewDieuTri.RowHeadersVisible = false;
            this.DgViewDieuTri.RowHeadersWidth = 62;
            this.DgViewDieuTri.RowTemplate.Height = 28;
            this.DgViewDieuTri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgViewDieuTri.Size = new System.Drawing.Size(1113, 222);
            this.DgViewDieuTri.TabIndex = 40;
            this.DgViewDieuTri.SelectionChanged += new System.EventHandler(this.DgViewDieuTri_SelectionChanged);
            // 
            // colDieuTriID
            // 
            this.colDieuTriID.DataPropertyName = "DieuTriID";
            this.colDieuTriID.HeaderText = "Mã Điều Trị";
            this.colDieuTriID.MinimumWidth = 6;
            this.colDieuTriID.Name = "colDieuTriID";
            // 
            // colHoSoID
            // 
            this.colHoSoID.DataPropertyName = "HoSoID";
            this.colHoSoID.HeaderText = "Mã Hồ Sơ";
            this.colHoSoID.MinimumWidth = 6;
            this.colHoSoID.Name = "colHoSoID";
            // 
            // colBacSiID
            // 
            this.colBacSiID.DataPropertyName = "BacSiID";
            this.colBacSiID.HeaderText = "Mã Bác Sĩ";
            this.colBacSiID.MinimumWidth = 6;
            this.colBacSiID.Name = "colBacSiID";
            // 
            // colNgayDieuTri
            // 
            this.colNgayDieuTri.DataPropertyName = "NgayDieuTri";
            this.colNgayDieuTri.HeaderText = "Ngày Điều Trị";
            this.colNgayDieuTri.MinimumWidth = 6;
            this.colNgayDieuTri.Name = "colNgayDieuTri";
            // 
            // colPhuongPhap
            // 
            this.colPhuongPhap.DataPropertyName = "PhuongPhap";
            this.colPhuongPhap.HeaderText = "Phương Pháp";
            this.colPhuongPhap.MinimumWidth = 6;
            this.colPhuongPhap.Name = "colPhuongPhap";
            // 
            // colThuoc
            // 
            this.colThuoc.DataPropertyName = "Thuoc";
            this.colThuoc.HeaderText = "Thuốc";
            this.colThuoc.MinimumWidth = 6;
            this.colThuoc.Name = "colThuoc";
            // 
            // colChiPhi
            // 
            this.colChiPhi.DataPropertyName = "ChiPhi";
            this.colChiPhi.HeaderText = "Chi Phí";
            this.colChiPhi.MinimumWidth = 6;
            this.colChiPhi.Name = "colChiPhi";
            // 
            // colKetQua
            // 
            this.colKetQua.DataPropertyName = "KetQua";
            this.colKetQua.HeaderText = "Kết Quả";
            this.colKetQua.MinimumWidth = 6;
            this.colKetQua.Name = "colKetQua";
            // 
            // labDanhSachDieuTri
            // 
            this.labDanhSachDieuTri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labDanhSachDieuTri.AutoSize = true;
            this.labDanhSachDieuTri.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labDanhSachDieuTri.Location = new System.Drawing.Point(22, 339);
            this.labDanhSachDieuTri.Name = "labDanhSachDieuTri";
            this.labDanhSachDieuTri.Size = new System.Drawing.Size(216, 25);
            this.labDanhSachDieuTri.TabIndex = 39;
            this.labDanhSachDieuTri.Text = "Danh Sách Điều Trị:";
            // 
            // labQuanLyDieuTri
            // 
            this.labQuanLyDieuTri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labQuanLyDieuTri.AutoSize = true;
            this.labQuanLyDieuTri.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labQuanLyDieuTri.ForeColor = System.Drawing.Color.Black;
            this.labQuanLyDieuTri.Location = new System.Drawing.Point(410, 19);
            this.labQuanLyDieuTri.Name = "labQuanLyDieuTri";
            this.labQuanLyDieuTri.Size = new System.Drawing.Size(324, 37);
            this.labQuanLyDieuTri.TabIndex = 38;
            this.labQuanLyDieuTri.Text = "QUẢN LÝ ĐIỀU TRỊ";
            this.labQuanLyDieuTri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelNhomNut
            // 
            this.panelNhomNut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelNhomNut.BackColor = System.Drawing.Color.SeaShell;
            this.panelNhomNut.Controls.Add(this.groupBox1);
            this.panelNhomNut.Location = new System.Drawing.Point(871, 59);
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
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 221);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
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
            // groupBoxDieuTri
            // 
            this.groupBoxDieuTri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDieuTri.Controls.Add(this.txtIDHoSo);
            this.groupBoxDieuTri.Controls.Add(this.txtChiPhi);
            this.groupBoxDieuTri.Controls.Add(this.lblBacSi);
            this.groupBoxDieuTri.Controls.Add(this.txtKQ);
            this.groupBoxDieuTri.Controls.Add(this.labNgayDieuTri);
            this.groupBoxDieuTri.Controls.Add(this.txtThuoc);
            this.groupBoxDieuTri.Controls.Add(this.dateTimePickerNgayDieuTri);
            this.groupBoxDieuTri.Controls.Add(this.txtPhuongPhap);
            this.groupBoxDieuTri.Controls.Add(this.labThuoc);
            this.groupBoxDieuTri.Controls.Add(this.labKQ);
            this.groupBoxDieuTri.Controls.Add(this.labPhuongPhap);
            this.groupBoxDieuTri.Controls.Add(this.txtIDBacSi);
            this.groupBoxDieuTri.Controls.Add(this.txtIDDieuTri);
            this.groupBoxDieuTri.Controls.Add(this.labChiPhi);
            this.groupBoxDieuTri.Controls.Add(this.labIDHoSo);
            this.groupBoxDieuTri.Controls.Add(this.labDDieuTri);
            this.groupBoxDieuTri.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxDieuTri.Location = new System.Drawing.Point(26, 59);
            this.groupBoxDieuTri.Name = "groupBoxDieuTri";
            this.groupBoxDieuTri.Size = new System.Drawing.Size(818, 221);
            this.groupBoxDieuTri.TabIndex = 43;
            this.groupBoxDieuTri.TabStop = false;
            this.groupBoxDieuTri.Text = "Thông tin:";
            // 
            // txtIDHoSo
            // 
            this.txtIDHoSo.Location = new System.Drawing.Point(149, 71);
            this.txtIDHoSo.Name = "txtIDHoSo";
            this.txtIDHoSo.Size = new System.Drawing.Size(227, 34);
            this.txtIDHoSo.TabIndex = 35;
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.Location = new System.Drawing.Point(547, 111);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(227, 34);
            this.txtChiPhi.TabIndex = 34;
            // 
            // lblBacSi
            // 
            this.lblBacSi.AutoSize = true;
            this.lblBacSi.Location = new System.Drawing.Point(44, 120);
            this.lblBacSi.Name = "lblBacSi";
            this.lblBacSi.Size = new System.Drawing.Size(107, 26);
            this.lblBacSi.TabIndex = 33;
            this.lblBacSi.Text = "ID Bác Sĩ:";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(547, 154);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(227, 34);
            this.txtKQ.TabIndex = 28;
            // 
            // labNgayDieuTri
            // 
            this.labNgayDieuTri.AutoSize = true;
            this.labNgayDieuTri.Location = new System.Drawing.Point(44, 171);
            this.labNgayDieuTri.Name = "labNgayDieuTri";
            this.labNgayDieuTri.Size = new System.Drawing.Size(139, 26);
            this.labNgayDieuTri.TabIndex = 25;
            this.labNgayDieuTri.Text = "Ngày điều trị:";
            // 
            // txtThuoc
            // 
            this.txtThuoc.Location = new System.Drawing.Point(547, 70);
            this.txtThuoc.Name = "txtThuoc";
            this.txtThuoc.Size = new System.Drawing.Size(227, 34);
            this.txtThuoc.TabIndex = 31;
            // 
            // dateTimePickerNgayDieuTri
            // 
            this.dateTimePickerNgayDieuTri.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayDieuTri.Location = new System.Drawing.Point(167, 165);
            this.dateTimePickerNgayDieuTri.Name = "dateTimePickerNgayDieuTri";
            this.dateTimePickerNgayDieuTri.Size = new System.Drawing.Size(141, 34);
            this.dateTimePickerNgayDieuTri.TabIndex = 32;
            // 
            // txtPhuongPhap
            // 
            this.txtPhuongPhap.Location = new System.Drawing.Point(547, 26);
            this.txtPhuongPhap.Name = "txtPhuongPhap";
            this.txtPhuongPhap.Size = new System.Drawing.Size(227, 34);
            this.txtPhuongPhap.TabIndex = 30;
            // 
            // labThuoc
            // 
            this.labThuoc.AutoSize = true;
            this.labThuoc.Location = new System.Drawing.Point(435, 74);
            this.labThuoc.Name = "labThuoc";
            this.labThuoc.Size = new System.Drawing.Size(78, 26);
            this.labThuoc.TabIndex = 23;
            this.labThuoc.Text = "Thuốc:";
            // 
            // labKQ
            // 
            this.labKQ.AutoSize = true;
            this.labKQ.Location = new System.Drawing.Point(435, 158);
            this.labKQ.Name = "labKQ";
            this.labKQ.Size = new System.Drawing.Size(90, 26);
            this.labKQ.TabIndex = 26;
            this.labKQ.Text = "Kết quả:";
            // 
            // labPhuongPhap
            // 
            this.labPhuongPhap.AutoSize = true;
            this.labPhuongPhap.Location = new System.Drawing.Point(435, 30);
            this.labPhuongPhap.Name = "labPhuongPhap";
            this.labPhuongPhap.Size = new System.Drawing.Size(142, 26);
            this.labPhuongPhap.TabIndex = 22;
            this.labPhuongPhap.Text = "Phương pháp:";
            // 
            // txtIDBacSi
            // 
            this.txtIDBacSi.Location = new System.Drawing.Point(149, 113);
            this.txtIDBacSi.Name = "txtIDBacSi";
            this.txtIDBacSi.Size = new System.Drawing.Size(227, 34);
            this.txtIDBacSi.TabIndex = 29;
            // 
            // txtIDDieuTri
            // 
            this.txtIDDieuTri.Location = new System.Drawing.Point(149, 26);
            this.txtIDDieuTri.Name = "txtIDDieuTri";
            this.txtIDDieuTri.Size = new System.Drawing.Size(227, 34);
            this.txtIDDieuTri.TabIndex = 27;
            // 
            // labChiPhi
            // 
            this.labChiPhi.AutoSize = true;
            this.labChiPhi.Location = new System.Drawing.Point(435, 120);
            this.labChiPhi.Name = "labChiPhi";
            this.labChiPhi.Size = new System.Drawing.Size(87, 26);
            this.labChiPhi.TabIndex = 24;
            this.labChiPhi.Text = "Chi phí:";
            // 
            // labIDHoSo
            // 
            this.labIDHoSo.AutoSize = true;
            this.labIDHoSo.Location = new System.Drawing.Point(44, 74);
            this.labIDHoSo.Name = "labIDHoSo";
            this.labIDHoSo.Size = new System.Drawing.Size(106, 26);
            this.labIDHoSo.TabIndex = 21;
            this.labIDHoSo.Text = "ID Hồ Sơ:";
            // 
            // labDDieuTri
            // 
            this.labDDieuTri.AutoSize = true;
            this.labDDieuTri.Location = new System.Drawing.Point(44, 30);
            this.labDDieuTri.Name = "labDDieuTri";
            this.labDDieuTri.Size = new System.Drawing.Size(114, 26);
            this.labDDieuTri.TabIndex = 20;
            this.labDDieuTri.Text = "ID điều trị:";
            // 
            // txtTim
            // 
            this.txtTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTim.Location = new System.Drawing.Point(746, 309);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(295, 30);
            this.txtTim.TabIndex = 54;
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.ForeColor = System.Drawing.Color.Green;
            this.btnTim.Location = new System.Drawing.Point(1047, 311);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(79, 27);
            this.btnTim.TabIndex = 53;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // Form_Therapeutic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1156, 608);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.groupBoxDieuTri);
            this.Controls.Add(this.panelNhomNut);
            this.Controls.Add(this.DgViewDieuTri);
            this.Controls.Add(this.labDanhSachDieuTri);
            this.Controls.Add(this.labQuanLyDieuTri);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Therapeutic";
            this.Text = "QUẢN LÝ ĐIỀU TRỊ ";
            this.Load += new System.EventHandler(this.Form_Therapeutic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewDieuTri)).EndInit();
            this.panelNhomNut.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxDieuTri.ResumeLayout(false);
            this.groupBoxDieuTri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView DgViewDieuTri;
        private System.Windows.Forms.Label labDanhSachDieuTri;
        private System.Windows.Forms.Label labQuanLyDieuTri;
        private System.Windows.Forms.Panel panelNhomNut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBoxDieuTri;
        private System.Windows.Forms.TextBox txtChiPhi;
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
        private System.Windows.Forms.TextBox txtIDDieuTri;
        private System.Windows.Forms.Label labChiPhi;
        private System.Windows.Forms.Label labIDHoSo;
        private System.Windows.Forms.Label labDDieuTri;
        private System.Windows.Forms.TextBox txtIDHoSo;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDieuTriID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoSoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBacSiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDieuTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhuongPhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChiPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKetQua;
    }
}