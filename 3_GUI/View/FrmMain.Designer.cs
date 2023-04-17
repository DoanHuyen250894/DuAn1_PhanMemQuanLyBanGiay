namespace _3_GUI.View
{
	partial class FrmMain
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
            System.Windows.Forms.Button btn_SP;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2_Load = new System.Windows.Forms.Panel();
            this.btn_DMK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_TK = new System.Windows.Forms.Button();
            this.btn_HD = new System.Windows.Forms.Button();
            this.btn_BanHang = new System.Windows.Forms.Button();
            this.btn_KH = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            btn_SP = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SP
            // 
            btn_SP.BackColor = System.Drawing.Color.SeaShell;
            btn_SP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_SP.ForeColor = System.Drawing.Color.Black;
            btn_SP.Image = ((System.Drawing.Image)(resources.GetObject("btn_SP.Image")));
            btn_SP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_SP.Location = new System.Drawing.Point(0, 147);
            btn_SP.Name = "btn_SP";
            btn_SP.Size = new System.Drawing.Size(212, 58);
            btn_SP.TabIndex = 1;
            btn_SP.Text = "Sản phẩm";
            btn_SP.UseVisualStyleBackColor = false;
            btn_SP.Click += new System.EventHandler(this.btn_SP_Click);
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.BackColor = System.Drawing.Color.SeaShell;
            this.btn_NhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_NhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhanVien.Image")));
            this.btn_NhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhanVien.Location = new System.Drawing.Point(0, 272);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Size = new System.Drawing.Size(212, 57);
            this.btn_NhanVien.TabIndex = 3;
            this.btn_NhanVien.Text = "Nhân viên";
            this.btn_NhanVien.UseVisualStyleBackColor = false;
            this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.panel2_Load);
            this.panel1.Controls.Add(this.btn_DMK);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_TK);
            this.panel1.Controls.Add(this.btn_HD);
            this.panel1.Controls.Add(this.btn_BanHang);
            this.panel1.Controls.Add(this.btn_NhanVien);
            this.panel1.Controls.Add(this.btn_KH);
            this.panel1.Controls.Add(btn_SP);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 969);
            this.panel1.TabIndex = 3;
            // 
            // panel2_Load
            // 
            this.panel2_Load.BackColor = System.Drawing.Color.SeaShell;
            this.panel2_Load.Location = new System.Drawing.Point(217, 110);
            this.panel2_Load.Name = "panel2_Load";
            this.panel2_Load.Size = new System.Drawing.Size(1358, 674);
            this.panel2_Load.TabIndex = 1;
            // 
            // btn_DMK
            // 
            this.btn_DMK.BackColor = System.Drawing.Color.SeaShell;
            this.btn_DMK.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DMK.Image = ((System.Drawing.Image)(resources.GetObject("btn_DMK.Image")));
            this.btn_DMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DMK.Location = new System.Drawing.Point(3, 860);
            this.btn_DMK.Name = "btn_DMK";
            this.btn_DMK.Size = new System.Drawing.Size(212, 50);
            this.btn_DMK.TabIndex = 8;
            this.btn_DMK.Text = "Tài khoản";
            this.btn_DMK.UseVisualStyleBackColor = false;
            this.btn_DMK.Click += new System.EventHandler(this.btn_DMK_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 916);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Đăng xuất";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_TK
            // 
            this.btn_TK.BackColor = System.Drawing.Color.SeaShell;
            this.btn_TK.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TK.Image = ((System.Drawing.Image)(resources.GetObject("btn_TK.Image")));
            this.btn_TK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TK.Location = new System.Drawing.Point(0, 456);
            this.btn_TK.Name = "btn_TK";
            this.btn_TK.Size = new System.Drawing.Size(211, 57);
            this.btn_TK.TabIndex = 6;
            this.btn_TK.Text = "Thống kê";
            this.btn_TK.UseVisualStyleBackColor = false;
            this.btn_TK.Click += new System.EventHandler(this.btn_TK_Click);
            // 
            // btn_HD
            // 
            this.btn_HD.BackColor = System.Drawing.Color.SeaShell;
            this.btn_HD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_HD.Image = ((System.Drawing.Image)(resources.GetObject("btn_HD.Image")));
            this.btn_HD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HD.Location = new System.Drawing.Point(1, 396);
            this.btn_HD.Name = "btn_HD";
            this.btn_HD.Size = new System.Drawing.Size(211, 54);
            this.btn_HD.TabIndex = 5;
            this.btn_HD.Text = "Hóa đơn";
            this.btn_HD.UseVisualStyleBackColor = false;
            this.btn_HD.Click += new System.EventHandler(this.btn_HD_Click);
            // 
            // btn_BanHang
            // 
            this.btn_BanHang.BackColor = System.Drawing.Color.SeaShell;
            this.btn_BanHang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BanHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_BanHang.Image")));
            this.btn_BanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BanHang.Location = new System.Drawing.Point(0, 335);
            this.btn_BanHang.Name = "btn_BanHang";
            this.btn_BanHang.Size = new System.Drawing.Size(212, 55);
            this.btn_BanHang.TabIndex = 4;
            this.btn_BanHang.Text = "Bán hàng";
            this.btn_BanHang.UseVisualStyleBackColor = false;
            this.btn_BanHang.Click += new System.EventHandler(this.btn_BanHang_Click);
            // 
            // btn_KH
            // 
            this.btn_KH.BackColor = System.Drawing.Color.SeaShell;
            this.btn_KH.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_KH.Image = ((System.Drawing.Image)(resources.GetObject("btn_KH.Image")));
            this.btn_KH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KH.Location = new System.Drawing.Point(0, 211);
            this.btn_KH.Name = "btn_KH";
            this.btn_KH.Size = new System.Drawing.Size(212, 55);
            this.btn_KH.TabIndex = 2;
            this.btn_KH.Text = "Khách hàng";
            this.btn_KH.UseVisualStyleBackColor = false;
            this.btn_KH.Click += new System.EventHandler(this.btn_KH_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 141);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.Location = new System.Drawing.Point(229, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1363, 969);
            this.panel3.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 973);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Button btn_NhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2_Load;
        private System.Windows.Forms.Button btn_DMK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_TK;
        private System.Windows.Forms.Button btn_HD;
        private System.Windows.Forms.Button btn_BanHang;
        private System.Windows.Forms.Button btn_KH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
    }
}