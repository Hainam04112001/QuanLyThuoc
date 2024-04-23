namespace QLThuoc.Thuoc1
{
    partial class frmXemThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXemThuoc));
            this.btn_trolai = new Guna.UI2.WinForms.Guna2Button();
            this.cb_ncc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_dvt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_giaban = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_soluong = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tenthuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_tenloaithuoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mathuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_trolai
            // 
            this.btn_trolai.BorderRadius = 19;
            this.btn_trolai.BorderThickness = 1;
            this.btn_trolai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_trolai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_trolai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_trolai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_trolai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trolai.ForeColor = System.Drawing.Color.White;
            this.btn_trolai.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_trolai.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_trolai.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_trolai.Image = ((System.Drawing.Image)(resources.GetObject("btn_trolai.Image")));
            this.btn_trolai.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_trolai.Location = new System.Drawing.Point(32, 13);
            this.btn_trolai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_trolai.Name = "btn_trolai";
            this.btn_trolai.Size = new System.Drawing.Size(102, 41);
            this.btn_trolai.TabIndex = 39;
            this.btn_trolai.Click += new System.EventHandler(this.btn_trolai_Click);
            // 
            // cb_ncc
            // 
            this.cb_ncc.BackColor = System.Drawing.Color.Transparent;
            this.cb_ncc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_ncc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ncc.Enabled = false;
            this.cb_ncc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_ncc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_ncc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_ncc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_ncc.ItemHeight = 30;
            this.cb_ncc.Location = new System.Drawing.Point(411, 143);
            this.cb_ncc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_ncc.Name = "cb_ncc";
            this.cb_ncc.Size = new System.Drawing.Size(339, 36);
            this.cb_ncc.TabIndex = 38;
            this.cb_ncc.SelectedIndexChanged += new System.EventHandler(this.cb_ncc_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(408, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 23);
            this.label9.TabIndex = 37;
            this.label9.Text = "Tên Nhà Cung Cấp";
            // 
            // txt_dvt
            // 
            this.txt_dvt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dvt.DefaultText = "";
            this.txt_dvt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_dvt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_dvt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dvt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dvt.Enabled = false;
            this.txt_dvt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dvt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_dvt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dvt.Location = new System.Drawing.Point(410, 384);
            this.txt_dvt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_dvt.Name = "txt_dvt";
            this.txt_dvt.PasswordChar = '\0';
            this.txt_dvt.PlaceholderText = "";
            this.txt_dvt.SelectedText = "";
            this.txt_dvt.Size = new System.Drawing.Size(340, 38);
            this.txt_dvt.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(408, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 23);
            this.label6.TabIndex = 35;
            this.label6.Text = "Đơn Vị Tính";
            // 
            // txt_giaban
            // 
            this.txt_giaban.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_giaban.DefaultText = "";
            this.txt_giaban.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_giaban.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_giaban.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_giaban.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_giaban.Enabled = false;
            this.txt_giaban.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_giaban.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_giaban.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_giaban.Location = new System.Drawing.Point(410, 258);
            this.txt_giaban.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_giaban.Name = "txt_giaban";
            this.txt_giaban.PasswordChar = '\0';
            this.txt_giaban.PlaceholderText = "";
            this.txt_giaban.SelectedText = "";
            this.txt_giaban.Size = new System.Drawing.Size(340, 49);
            this.txt_giaban.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(408, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 23);
            this.label7.TabIndex = 33;
            this.label7.Text = "Giá Bán";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_soluong.DefaultText = "";
            this.txt_soluong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_soluong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_soluong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_soluong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_soluong.Enabled = false;
            this.txt_soluong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_soluong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_soluong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_soluong.Location = new System.Drawing.Point(36, 484);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.PasswordChar = '\0';
            this.txt_soluong.PlaceholderText = "";
            this.txt_soluong.SelectedText = "";
            this.txt_soluong.Size = new System.Drawing.Size(344, 41);
            this.txt_soluong.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Số Lượng";
            // 
            // txt_tenthuoc
            // 
            this.txt_tenthuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenthuoc.DefaultText = "";
            this.txt_tenthuoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tenthuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tenthuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenthuoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenthuoc.Enabled = false;
            this.txt_tenthuoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenthuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tenthuoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenthuoc.Location = new System.Drawing.Point(35, 258);
            this.txt_tenthuoc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_tenthuoc.Name = "txt_tenthuoc";
            this.txt_tenthuoc.PasswordChar = '\0';
            this.txt_tenthuoc.PlaceholderText = "";
            this.txt_tenthuoc.SelectedText = "";
            this.txt_tenthuoc.Size = new System.Drawing.Size(344, 49);
            this.txt_tenthuoc.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Tên Thuốc";
            // 
            // cb_tenloaithuoc
            // 
            this.cb_tenloaithuoc.BackColor = System.Drawing.Color.Transparent;
            this.cb_tenloaithuoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_tenloaithuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tenloaithuoc.Enabled = false;
            this.cb_tenloaithuoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_tenloaithuoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_tenloaithuoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_tenloaithuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_tenloaithuoc.ItemHeight = 30;
            this.cb_tenloaithuoc.Location = new System.Drawing.Point(35, 386);
            this.cb_tenloaithuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_tenloaithuoc.Name = "cb_tenloaithuoc";
            this.cb_tenloaithuoc.Size = new System.Drawing.Size(344, 36);
            this.cb_tenloaithuoc.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(32, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên Loại Thuốc";
            // 
            // txt_mathuoc
            // 
            this.txt_mathuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mathuoc.DefaultText = "";
            this.txt_mathuoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_mathuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_mathuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mathuoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mathuoc.Enabled = false;
            this.txt_mathuoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mathuoc.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mathuoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mathuoc.Location = new System.Drawing.Point(35, 143);
            this.txt_mathuoc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_mathuoc.Name = "txt_mathuoc";
            this.txt_mathuoc.PasswordChar = '\0';
            this.txt_mathuoc.PlaceholderText = "";
            this.txt_mathuoc.SelectedText = "";
            this.txt_mathuoc.Size = new System.Drawing.Size(344, 36);
            this.txt_mathuoc.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã Thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 44);
            this.label1.TabIndex = 22;
            this.label1.Text = "Thông Tin Chi Tiết";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(781, 143);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 208);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 19;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button1.Location = new System.Drawing.Point(781, 358);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 56;
            this.guna2Button1.Text = "Tải Mã QR";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // frmXemThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 651);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_trolai);
            this.Controls.Add(this.cb_ncc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_dvt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_giaban);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tenthuoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_tenloaithuoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_mathuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Chiller", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmXemThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXemThuoc";
            this.Load += new System.EventHandler(this.frmXemThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_trolai;
        private Guna.UI2.WinForms.Guna2ComboBox cb_ncc;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txt_dvt;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_giaban;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_soluong;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_tenthuoc;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cb_tenloaithuoc;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_mathuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}