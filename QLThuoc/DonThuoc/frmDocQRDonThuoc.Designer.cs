﻿namespace QLThuoc.DonThuoc1
{
    partial class frmDocQRDonThuoc
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
            this.components = new System.ComponentModel.Container();
            this.txt_kq = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_star = new System.Windows.Forms.Button();
            this.cmb_camera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_kq
            // 
            this.txt_kq.Location = new System.Drawing.Point(525, 183);
            this.txt_kq.Multiline = true;
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.Size = new System.Drawing.Size(363, 342);
            this.txt_kq.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(112, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 342);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 336);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_star
            // 
            this.btn_star.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_star.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_star.Location = new System.Drawing.Point(525, 98);
            this.btn_star.Name = "btn_star";
            this.btn_star.Size = new System.Drawing.Size(126, 43);
            this.btn_star.TabIndex = 10;
            this.btn_star.Text = "Star";
            this.btn_star.UseVisualStyleBackColor = false;
            this.btn_star.Click += new System.EventHandler(this.btn_star_Click);
            // 
            // cmb_camera
            // 
            this.cmb_camera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_camera.FormattingEnabled = true;
            this.cmb_camera.Location = new System.Drawing.Point(236, 104);
            this.cmb_camera.Name = "cmb_camera";
            this.cmb_camera.Size = new System.Drawing.Size(241, 33);
            this.cmb_camera.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Camera";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(587, 44);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tìm kiếm đơn thuốc theo mã QR";
            // 
            // frmDocQRDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_star);
            this.Controls.Add(this.cmb_camera);
            this.Controls.Add(this.label1);
            this.Name = "frmDocQRDonThuoc";
            this.Text = "frmDocQRThuoc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDocQRThuoc_FormClosing);
            this.Load += new System.EventHandler(this.frmDocQRThuoc_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_kq;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_star;
        private System.Windows.Forms.ComboBox cmb_camera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}