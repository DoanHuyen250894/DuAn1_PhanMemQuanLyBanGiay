using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;

namespace _3_GUI.View
{
	partial class FrmDangNhap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
			tb_use = new TextBox();
			tb_pass = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			pictureBox1 = new PictureBox();
			btn_dangnhap = new RJControls.RJButton();
			checkBox1 = new CheckBox();
			lb_quenmk = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// tb_use
			// 
			tb_use.Location = new System.Drawing.Point(156, 65);
			tb_use.Name = "tb_use";
			tb_use.Size = new System.Drawing.Size(237, 23);
			tb_use.TabIndex = 1;
			// 
			// tb_pass
			// 
			tb_pass.Location = new System.Drawing.Point(156, 94);
			tb_pass.Name = "tb_pass";
			tb_pass.PasswordChar = '♥';
			tb_pass.Size = new System.Drawing.Size(237, 23);
			tb_pass.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = System.Drawing.Color.Transparent;
			label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			label1.Location = new System.Drawing.Point(34, 65);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(111, 19);
			label1.TabIndex = 3;
			label1.Text = "Tên đăng nhập:";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = System.Drawing.Color.Transparent;
			label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			label2.Location = new System.Drawing.Point(34, 94);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(75, 19);
			label2.TabIndex = 4;
			label2.Text = "Mật khẩu:";
			label2.Click += label2_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(196, 22);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(0, 15);
			label3.TabIndex = 6;
			label3.Click += label3_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = System.Drawing.Color.Transparent;
			label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			label4.Location = new System.Drawing.Point(167, 12);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(82, 31);
			label4.TabIndex = 7;
			label4.Text = "Login";
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = System.Drawing.Color.Transparent;
			pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new System.Drawing.Point(385, 2);
			pictureBox1.Margin = new Padding(3, 2, 3, 2);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(19, 15);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 8;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// btn_dangnhap
			// 
			btn_dangnhap.BackColor = System.Drawing.Color.MediumSeaGreen;
			btn_dangnhap.FlatAppearance.BorderSize = 0;
			btn_dangnhap.FlatStyle = FlatStyle.Flat;
			btn_dangnhap.ForeColor = System.Drawing.Color.White;
			btn_dangnhap.Location = new System.Drawing.Point(262, 120);
			btn_dangnhap.Margin = new Padding(3, 2, 3, 2);
			btn_dangnhap.Name = "btn_dangnhap";
			btn_dangnhap.Size = new System.Drawing.Size(131, 39);
			btn_dangnhap.TabIndex = 9;
			btn_dangnhap.Text = "Đăng nhập";
			btn_dangnhap.UseVisualStyleBackColor = false;
			btn_dangnhap.Click += btn_dangnhap_Click;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.BackColor = System.Drawing.Color.Transparent;
			checkBox1.Location = new System.Drawing.Point(34, 120);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new System.Drawing.Size(125, 19);
			checkBox1.TabIndex = 10;
			checkBox1.Text = "Ghi nhớ thông tin?";
			checkBox1.UseVisualStyleBackColor = false;
			// 
			// lb_quenmk
			// 
			lb_quenmk.AutoSize = true;
			lb_quenmk.Location = new System.Drawing.Point(211, 170);
			lb_quenmk.Name = "lb_quenmk";
			lb_quenmk.Size = new System.Drawing.Size(89, 15);
			lb_quenmk.TabIndex = 11;
			lb_quenmk.Text = "Quen mat khau";
			lb_quenmk.Click += lb_quenmk_Click;
			// 
			// FrmDangNhap
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new System.Drawing.Size(405, 242);
			Controls.Add(lb_quenmk);
			Controls.Add(checkBox1);
			Controls.Add(btn_dangnhap);
			Controls.Add(pictureBox1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(tb_pass);
			Controls.Add(tb_use);
			FormBorderStyle = FormBorderStyle.None;
			Name = "FrmDangNhap";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ĐĂNG NHẬP";
			Load += FrmDangNhap_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox tb_use;
		private TextBox tb_pass;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private PictureBox pictureBox1;
		private RJControls.RJButton btn_dangnhap;
		private CheckBox checkBox1;
		private Label lb_quenmk;
	}
}