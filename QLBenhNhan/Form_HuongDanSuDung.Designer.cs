namespace QLBenhNhan
{
    partial class Form_HuongDanSuDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HuongDanSuDung));
            this.lblHDSD = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblNoiDungHDSD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHDSD
            // 
            this.lblHDSD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHDSD.AutoSize = true;
            this.lblHDSD.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHDSD.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblHDSD.Location = new System.Drawing.Point(391, 158);
            this.lblHDSD.Name = "lblHDSD";
            this.lblHDSD.Size = new System.Drawing.Size(463, 45);
            this.lblHDSD.TabIndex = 1;
            this.lblHDSD.Text = "HƯỚNG DẪN SỬ DỤNG";
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDong.BackColor = System.Drawing.Color.LightCoral;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDong.Location = new System.Drawing.Point(548, 620);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(149, 50);
            this.btnDong.TabIndex = 18;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lblNoiDungHDSD
            // 
            this.lblNoiDungHDSD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoiDungHDSD.BackColor = System.Drawing.Color.Transparent;
            this.lblNoiDungHDSD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNoiDungHDSD.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblNoiDungHDSD.Location = new System.Drawing.Point(330, 213);
            this.lblNoiDungHDSD.Name = "lblNoiDungHDSD";
            this.lblNoiDungHDSD.Size = new System.Drawing.Size(584, 288);
            this.lblNoiDungHDSD.TabIndex = 19;
            this.lblNoiDungHDSD.Text = resources.GetString("lblNoiDungHDSD.Text");
            // 
            // Form_HuongDanSuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1239, 747);
            this.Controls.Add(this.lblNoiDungHDSD);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lblHDSD);
            this.Name = "Form_HuongDanSuDung";
            this.Text = "HƯỚNG DẪN SỬ DỤNG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHDSD;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lblNoiDungHDSD;
    }
}