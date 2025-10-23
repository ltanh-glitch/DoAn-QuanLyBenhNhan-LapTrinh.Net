namespace QLBenhNhan
{
    partial class Form_Loading
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
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.lblNameDoAn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Location = new System.Drawing.Point(112, 184);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(322, 23);
            this.progressBarLoading.TabIndex = 1;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoading.ForeColor = System.Drawing.Color.Lime;
            this.lblLoading.Location = new System.Drawing.Point(260, 210);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(32, 19);
            this.lblLoading.TabIndex = 2;
            this.lblLoading.Text = "0%";
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Image = global::QLBenhNhan.Properties.Resources.picture_Loading;
            this.pictureBoxLoading.Location = new System.Drawing.Point(-1, -1);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(553, 261);
            this.pictureBoxLoading.TabIndex = 0;
            this.pictureBoxLoading.TabStop = false;
            // 
            // lblNameDoAn
            // 
            this.lblNameDoAn.AutoSize = true;
            this.lblNameDoAn.BackColor = System.Drawing.Color.Transparent;
            this.lblNameDoAn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameDoAn.ForeColor = System.Drawing.Color.Black;
            this.lblNameDoAn.Location = new System.Drawing.Point(71, 139);
            this.lblNameDoAn.Name = "lblNameDoAn";
            this.lblNameDoAn.Size = new System.Drawing.Size(404, 32);
            this.lblNameDoAn.TabIndex = 3;
            this.lblNameDoAn.Text = "Phần Mềm Quản Lý Bệnh Nhân";
            // 
            // Form_Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 258);
            this.Controls.Add(this.lblNameDoAn);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.progressBarLoading);
            this.Controls.Add(this.pictureBoxLoading);
            this.Name = "Form_Loading";
            this.Text = "HỆ THỐNG";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.ProgressBar progressBarLoading;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblNameDoAn;
    }
}