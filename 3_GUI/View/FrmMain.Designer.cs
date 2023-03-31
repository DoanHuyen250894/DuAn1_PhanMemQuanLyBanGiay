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
			panel1 = new System.Windows.Forms.Panel();
			btn_DMK = new System.Windows.Forms.Button();
			button1 = new System.Windows.Forms.Button();
			btn_TK = new System.Windows.Forms.Button();
			btn_HD = new System.Windows.Forms.Button();
			btn_BanHang = new System.Windows.Forms.Button();
			btn_NhanVien = new System.Windows.Forms.Button();
			btn_KH = new System.Windows.Forms.Button();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			panel2_Load = new System.Windows.Forms.Panel();
			btn_SP = new System.Windows.Forms.Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// btn_SP
			// 
			btn_SP.BackColor = System.Drawing.Color.SeaShell;
			btn_SP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			btn_SP.ForeColor = System.Drawing.Color.Black;
			btn_SP.Image = (System.Drawing.Image)resources.GetObject("btn_SP.Image");
			btn_SP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			btn_SP.Location = new System.Drawing.Point(0, 143);
			btn_SP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			btn_SP.Name = "btn_SP";
			btn_SP.Size = new System.Drawing.Size(180, 44);
			btn_SP.TabIndex = 1;
			btn_SP.Text = "Sản phẩm";
			btn_SP.UseVisualStyleBackColor = false;
			btn_SP.Click += btn_SP_Click;
			// 
			// panel1
			// 
			panel1.BackColor = System.Drawing.Color.SeaShell;
			panel1.Controls.Add(btn_DMK);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(btn_TK);
			panel1.Controls.Add(btn_HD);
			panel1.Controls.Add(btn_BanHang);
			panel1.Controls.Add(btn_NhanVien);
			panel1.Controls.Add(btn_KH);
			panel1.Controls.Add(btn_SP);
			panel1.Controls.Add(pictureBox1);
			panel1.Location = new System.Drawing.Point(12, 11);
			panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(186, 849);
			panel1.TabIndex = 2;
			// 
			// btn_DMK
			// 
			btn_DMK.BackColor = System.Drawing.Color.SeaShell;
			btn_DMK.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			btn_DMK.Image = (System.Drawing.Image)resources.GetObject("btn_DMK.Image");
			btn_DMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			btn_DMK.Location = new System.Drawing.Point(3, 765);
			btn_DMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			btn_DMK.Name = "btn_DMK";
			btn_DMK.Size = new System.Drawing.Size(180, 38);
			btn_DMK.TabIndex = 8;
			btn_DMK.Text = "Tài khoản";
			btn_DMK.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			button1.BackColor = System.Drawing.Color.SeaShell;
			button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
			button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			button1.Location = new System.Drawing.Point(3, 807);
			button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(180, 37);
			button1.TabIndex = 7;
			button1.Text = "Đăng xuất";
			button1.UseVisualStyleBackColor = false;
			// 
			// btn_TK
			// 
			btn_TK.BackColor = System.Drawing.Color.SeaShell;
			btn_TK.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			btn_TK.Image = (System.Drawing.Image)resources.GetObject("btn_TK.Image");
			btn_TK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			btn_TK.Location = new System.Drawing.Point(0, 375);
			btn_TK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			btn_TK.Name = "btn_TK";
			btn_TK.Size = new System.Drawing.Size(179, 43);
			btn_TK.TabIndex = 6;
			btn_TK.Text = "Thống kê";
			btn_TK.UseVisualStyleBackColor = false;
			btn_TK.Click += btn_TK_Click;
			// 
			// btn_HD
			// 
			btn_HD.BackColor = System.Drawing.Color.SeaShell;
			btn_HD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			btn_HD.Image = (System.Drawing.Image)resources.GetObject("btn_HD.Image");
			btn_HD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			btn_HD.Location = new System.Drawing.Point(1, 330);
			btn_HD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			btn_HD.Name = "btn_HD";
			btn_HD.Size = new System.Drawing.Size(179, 40);
			btn_HD.TabIndex = 5;
			btn_HD.Text = "Hóa đơn";
			btn_HD.UseVisualStyleBackColor = false;
			btn_HD.Click += btn_HD_Click;
			// 
			// btn_BanHang
			// 
			btn_BanHang.BackColor = System.Drawing.Color.SeaShell;
			btn_BanHang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			btn_BanHang.Image = (System.Drawing.Image)resources.GetObject("btn_BanHang.Image");
			btn_BanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			btn_BanHang.Location = new System.Drawing.Point(0, 284);
			btn_BanHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			btn_BanHang.Name = "btn_BanHang";
			btn_BanHang.Size = new System.Drawing.Size(180, 41);
			btn_BanHang.TabIndex = 4;
			btn_BanHang.Text = "Bán hàng";
			btn_BanHang.UseVisualStyleBackColor = false;
			btn_BanHang.Click += btn_BanHang_Click;
			// 
			// btn_NhanVien
			// 
			btn_NhanVien.BackColor = System.Drawing.Color.SeaShell;
			btn_NhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			btn_NhanVien.Image = (System.Drawing.Image)resources.GetObject("btn_NhanVien.Image");
			btn_NhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			btn_NhanVien.Location = new System.Drawing.Point(0, 237);
			btn_NhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			btn_NhanVien.Name = "btn_NhanVien";
			btn_NhanVien.Size = new System.Drawing.Size(180, 43);
			btn_NhanVien.TabIndex = 3;
			btn_NhanVien.Text = "Nhân viên";
			btn_NhanVien.UseVisualStyleBackColor = false;
			btn_NhanVien.Click += btn_NhanVien_Click;
			// 
			// btn_KH
			// 
			btn_KH.BackColor = System.Drawing.Color.SeaShell;
			btn_KH.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			btn_KH.Image = (System.Drawing.Image)resources.GetObject("btn_KH.Image");
			btn_KH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			btn_KH.Location = new System.Drawing.Point(0, 191);
			btn_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			btn_KH.Name = "btn_KH";
			btn_KH.Size = new System.Drawing.Size(180, 41);
			btn_KH.TabIndex = 2;
			btn_KH.Text = "Khách hàng";
			btn_KH.UseVisualStyleBackColor = false;
			btn_KH.Click += btn_KH_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new System.Drawing.Point(30, 2);
			pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(130, 137);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// panel2_Load
			// 
			panel2_Load.Location = new System.Drawing.Point(207, 13);
			panel2_Load.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			panel2_Load.Name = "panel2_Load";
			panel2_Load.Size = new System.Drawing.Size(1230, 847);
			panel2_Load.TabIndex = 3;
			// 
			// FrmMain
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1449, 871);
			Controls.Add(panel1);
			Controls.Add(panel2_Load);
			Name = "FrmMain";
			Text = "FrmMain";
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_DMK;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_TK;
		private System.Windows.Forms.Button btn_HD;
		private System.Windows.Forms.Button btn_BanHang;
		private System.Windows.Forms.Button btn_NhanVien;
		private System.Windows.Forms.Button btn_KH;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2_Load;
	}
}