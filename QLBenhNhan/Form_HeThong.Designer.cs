namespace QLBenhNhan
{
    partial class Form_HeThong
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
            this.lblDangXuat = new System.Windows.Forms.Label();
            this.lblTroVe = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.picTroVe = new System.Windows.Forms.PictureBox();
            this.picThoat = new System.Windows.Forms.PictureBox();
            this.picDangXuat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTroVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDangXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDangXuat
            // 
            this.lblDangXuat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDangXuat.BackColor = System.Drawing.Color.White;
            this.lblDangXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDangXuat.Location = new System.Drawing.Point(319, 223);
            this.lblDangXuat.Name = "lblDangXuat";
            this.lblDangXuat.Size = new System.Drawing.Size(173, 30);
            this.lblDangXuat.TabIndex = 3;
            this.lblDangXuat.Text = "Đăng Xuất";
            this.lblDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDangXuat.Click += new System.EventHandler(this.lblDangXuat_Click);
            // 
            // lblTroVe
            // 
            this.lblTroVe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTroVe.BackColor = System.Drawing.Color.White;
            this.lblTroVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTroVe.Location = new System.Drawing.Point(677, 223);
            this.lblTroVe.Name = "lblTroVe";
            this.lblTroVe.Size = new System.Drawing.Size(173, 30);
            this.lblTroVe.TabIndex = 5;
            this.lblTroVe.Text = "Trở Về";
            this.lblTroVe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTroVe.Click += new System.EventHandler(this.lblTroVe_Click);
            // 
            // lblExit
            // 
            this.lblExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExit.BackColor = System.Drawing.Color.White;
            this.lblExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblExit.Location = new System.Drawing.Point(498, 223);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(173, 30);
            this.lblExit.TabIndex = 6;
            this.lblExit.Text = "Exit";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // picTroVe
            // 
            this.picTroVe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picTroVe.Image = global::QLBenhNhan.Properties.Resources.Undo;
            this.picTroVe.Location = new System.Drawing.Point(677, 44);
            this.picTroVe.Name = "picTroVe";
            this.picTroVe.Size = new System.Drawing.Size(173, 176);
            this.picTroVe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTroVe.TabIndex = 2;
            this.picTroVe.TabStop = false;
            this.picTroVe.Click += new System.EventHandler(this.picTroVe_Click);
            // 
            // picThoat
            // 
            this.picThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picThoat.Image = global::QLBenhNhan.Properties.Resources.Thoat;
            this.picThoat.Location = new System.Drawing.Point(498, 44);
            this.picThoat.Name = "picThoat";
            this.picThoat.Size = new System.Drawing.Size(173, 176);
            this.picThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picThoat.TabIndex = 1;
            this.picThoat.TabStop = false;
            this.picThoat.Click += new System.EventHandler(this.picThoat_Click);
            // 
            // picDangXuat
            // 
            this.picDangXuat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picDangXuat.Image = global::QLBenhNhan.Properties.Resources.DangXuat;
            this.picDangXuat.Location = new System.Drawing.Point(319, 44);
            this.picDangXuat.Name = "picDangXuat";
            this.picDangXuat.Size = new System.Drawing.Size(173, 176);
            this.picDangXuat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDangXuat.TabIndex = 0;
            this.picDangXuat.TabStop = false;
            this.picDangXuat.Click += new System.EventHandler(this.picDangXuat_Click);
            // 
            // Form_HeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 661);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblTroVe);
            this.Controls.Add(this.lblDangXuat);
            this.Controls.Add(this.picTroVe);
            this.Controls.Add(this.picThoat);
            this.Controls.Add(this.picDangXuat);
            this.Name = "Form_HeThong";
            this.Text = "HỆ THỐNG";
            ((System.ComponentModel.ISupportInitialize)(this.picTroVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDangXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDangXuat;
        private System.Windows.Forms.PictureBox picThoat;
        private System.Windows.Forms.PictureBox picTroVe;
        private System.Windows.Forms.Label lblDangXuat;
        private System.Windows.Forms.Label lblTroVe;
        private System.Windows.Forms.Label lblExit;
    }
}