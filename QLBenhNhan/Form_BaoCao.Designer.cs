namespace QLBenhNhan
{
    partial class Form_BaoCao
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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.lblTongChiPhi = new System.Windows.Forms.Label();
            this.lblTongHoSo = new System.Windows.Forms.Label();
            this.lblTongBacSi = new System.Windows.Forms.Label();
            this.lblTongBenhNhan = new System.Windows.Forms.Label();
            this.labelLoai = new System.Windows.Forms.Label();
            this.cbLoaiBaoCao = new System.Windows.Forms.ComboBox();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.chartBaoCao = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelHeader.Controls.Add(this.btnExport);
            this.panelHeader.Controls.Add(this.btnQuayLai);
            this.panelHeader.Controls.Add(this.lblTongChiPhi);
            this.panelHeader.Controls.Add(this.lblTongHoSo);
            this.panelHeader.Controls.Add(this.lblTongBacSi);
            this.panelHeader.Controls.Add(this.lblTongBenhNhan);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 90);
            this.panelHeader.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExport.BackColor = System.Drawing.Color.ForestGreen;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1050, 25);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 40);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.SteelBlue;
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuayLai.ForeColor = System.Drawing.Color.White;
            this.btnQuayLai.Location = new System.Drawing.Point(20, 25);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(110, 40);
            this.btnQuayLai.TabIndex = 5;
            this.btnQuayLai.Text = "← Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // lblTongChiPhi
            // 
            this.lblTongChiPhi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTongChiPhi.AutoSize = true;
            this.lblTongChiPhi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongChiPhi.Location = new System.Drawing.Point(850, 35);
            this.lblTongChiPhi.Name = "lblTongChiPhi";
            this.lblTongChiPhi.Size = new System.Drawing.Size(172, 23);
            this.lblTongChiPhi.TabIndex = 4;
            this.lblTongChiPhi.Text = "Tổng chi phí: 0 VNĐ";
            // 
            // lblTongHoSo
            // 
            this.lblTongHoSo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTongHoSo.AutoSize = true;
            this.lblTongHoSo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongHoSo.Location = new System.Drawing.Point(600, 35);
            this.lblTongHoSo.Name = "lblTongHoSo";
            this.lblTongHoSo.Size = new System.Drawing.Size(145, 23);
            this.lblTongHoSo.TabIndex = 3;
            this.lblTongHoSo.Text = "Hồ sơ bệnh án: 0";
            // 
            // lblTongBacSi
            // 
            this.lblTongBacSi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTongBacSi.AutoSize = true;
            this.lblTongBacSi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongBacSi.Location = new System.Drawing.Point(380, 35);
            this.lblTongBacSi.Name = "lblTongBacSi";
            this.lblTongBacSi.Size = new System.Drawing.Size(75, 23);
            this.lblTongBacSi.TabIndex = 2;
            this.lblTongBacSi.Text = "Bác sĩ: 0";
            // 
            // lblTongBenhNhan
            // 
            this.lblTongBenhNhan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTongBenhNhan.AutoSize = true;
            this.lblTongBenhNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongBenhNhan.Location = new System.Drawing.Point(200, 35);
            this.lblTongBenhNhan.Name = "lblTongBenhNhan";
            this.lblTongBenhNhan.Size = new System.Drawing.Size(114, 23);
            this.lblTongBenhNhan.TabIndex = 1;
            this.lblTongBenhNhan.Text = "Bệnh nhân: 0";
            // 
            // labelLoai
            // 
            this.labelLoai.AutoSize = true;
            this.labelLoai.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelLoai.Location = new System.Drawing.Point(40, 110);
            this.labelLoai.Name = "labelLoai";
            this.labelLoai.Size = new System.Drawing.Size(139, 25);
            this.labelLoai.TabIndex = 1;
            this.labelLoai.Text = "Chọn báo cáo:";
            // 
            // cbLoaiBaoCao
            // 
            this.cbLoaiBaoCao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiBaoCao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLoaiBaoCao.FormattingEnabled = true;
            this.cbLoaiBaoCao.Location = new System.Drawing.Point(190, 108);
            this.cbLoaiBaoCao.Name = "cbLoaiBaoCao";
            this.cbLoaiBaoCao.Size = new System.Drawing.Size(320, 31);
            this.cbLoaiBaoCao.TabIndex = 2;
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXemBaoCao.Location = new System.Drawing.Point(530, 107);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(156, 33);
            this.btnXemBaoCao.TabIndex = 3;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Location = new System.Drawing.Point(40, 160);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.RowHeadersVisible = false;
            this.dgvBaoCao.RowHeadersWidth = 51;
            this.dgvBaoCao.RowTemplate.Height = 28;
            this.dgvBaoCao.Size = new System.Drawing.Size(550, 500);
            this.dgvBaoCao.TabIndex = 4;
            // 
            // chartBaoCao
            // 
            this.chartBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.chartBaoCao.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBaoCao.Legends.Add(legend1);
            this.chartBaoCao.Location = new System.Drawing.Point(620, 160);
            this.chartBaoCao.Name = "chartBaoCao";
            this.chartBaoCao.Size = new System.Drawing.Size(550, 500);
            this.chartBaoCao.TabIndex = 5;
            this.chartBaoCao.Text = "chart1";
            // 
            // Form_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.chartBaoCao);
            this.Controls.Add(this.dgvBaoCao);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.cbLoaiBaoCao);
            this.Controls.Add(this.labelLoai);
            this.Controls.Add(this.panelHeader);
            this.Name = "Form_BaoCao";
            this.Text = "Báo cáo & Thống kê bệnh viện";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label lblTongChiPhi;
        private System.Windows.Forms.Label lblTongHoSo;
        private System.Windows.Forms.Label lblTongBacSi;
        private System.Windows.Forms.Label lblTongBenhNhan;
        private System.Windows.Forms.Label labelLoai;
        private System.Windows.Forms.ComboBox cbLoaiBaoCao;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBaoCao;
    }
}
