namespace _3_GUI.View
{
	partial class FrmKhuyenMai
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhuyenMai));
			dgrid_KM = new System.Windows.Forms.DataGridView();
			rbtn_KHD = new System.Windows.Forms.RadioButton();
			rbtn_HD = new System.Windows.Forms.RadioButton();
			txt_Ten = new System.Windows.Forms.TextBox();
			txt_Ma = new System.Windows.Forms.TextBox();
			label3 = new System.Windows.Forms.Label();
			btn_Xoa = new RJControls.RJButton();
			btn_Sua = new RJControls.RJButton();
			btn_Them = new RJControls.RJButton();
			label2 = new System.Windows.Forms.Label();
			groupBox2 = new System.Windows.Forms.GroupBox();
			btn_Reset = new RJControls.RJButton();
			label1 = new System.Windows.Forms.Label();
			txt_TimKiem = new System.Windows.Forms.TextBox();
			groupBox1 = new System.Windows.Forms.GroupBox();
			date2 = new System.Windows.Forms.DateTimePicker();
			date1 = new System.Windows.Forms.DateTimePicker();
			txt_hinhthuc = new System.Windows.Forms.TextBox();
			label6 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)dgrid_KM).BeginInit();
			groupBox2.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// dgrid_KM
			// 
			dgrid_KM.BackgroundColor = System.Drawing.Color.LightCoral;
			dgrid_KM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgrid_KM.Location = new System.Drawing.Point(-2, 268);
			dgrid_KM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			dgrid_KM.Name = "dgrid_KM";
			dgrid_KM.RowHeadersWidth = 51;
			dgrid_KM.RowTemplate.Height = 29;
			dgrid_KM.Size = new System.Drawing.Size(688, 116);
			dgrid_KM.TabIndex = 7;
			dgrid_KM.CellContentClick += dgrid_KM_CellContentClick;
			// 
			// rbtn_KHD
			// 
			rbtn_KHD.AutoSize = true;
			rbtn_KHD.Location = new System.Drawing.Point(214, 203);
			rbtn_KHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			rbtn_KHD.Name = "rbtn_KHD";
			rbtn_KHD.Size = new System.Drawing.Size(137, 23);
			rbtn_KHD.TabIndex = 8;
			rbtn_KHD.TabStop = true;
			rbtn_KHD.Text = "Không hoạt động";
			rbtn_KHD.UseVisualStyleBackColor = true;
			// 
			// rbtn_HD
			// 
			rbtn_HD.AutoSize = true;
			rbtn_HD.Location = new System.Drawing.Point(90, 202);
			rbtn_HD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			rbtn_HD.Name = "rbtn_HD";
			rbtn_HD.Size = new System.Drawing.Size(94, 23);
			rbtn_HD.TabIndex = 7;
			rbtn_HD.TabStop = true;
			rbtn_HD.Text = "Hoạt động";
			rbtn_HD.UseVisualStyleBackColor = true;
			// 
			// txt_Ten
			// 
			txt_Ten.Location = new System.Drawing.Point(120, 60);
			txt_Ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			txt_Ten.Name = "txt_Ten";
			txt_Ten.Size = new System.Drawing.Size(219, 26);
			txt_Ten.TabIndex = 5;
			txt_Ten.TextChanged += txt_Ten_TextChanged;
			// 
			// txt_Ma
			// 
			txt_Ma.Location = new System.Drawing.Point(121, 23);
			txt_Ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			txt_Ma.Name = "txt_Ma";
			txt_Ma.Size = new System.Drawing.Size(218, 26);
			txt_Ma.TabIndex = 4;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(13, 202);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(75, 19);
			label3.TabIndex = 2;
			label3.Text = "Trạng thái:";
			// 
			// btn_Xoa
			// 
			btn_Xoa.BackColor = System.Drawing.Color.MediumSeaGreen;
			btn_Xoa.FlatAppearance.BorderSize = 0;
			btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btn_Xoa.ForeColor = System.Drawing.Color.White;
			btn_Xoa.Image = (System.Drawing.Image)resources.GetObject("btn_Xoa.Image");
			btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			btn_Xoa.Location = new System.Drawing.Point(32, 94);
			btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			btn_Xoa.Name = "btn_Xoa";
			btn_Xoa.Size = new System.Drawing.Size(171, 31);
			btn_Xoa.TabIndex = 2;
			btn_Xoa.Text = "Xóa";
			btn_Xoa.UseVisualStyleBackColor = false;
			btn_Xoa.Click += btn_Xoa_Click;
			// 
			// btn_Sua
			// 
			btn_Sua.BackColor = System.Drawing.Color.MediumSeaGreen;
			btn_Sua.FlatAppearance.BorderSize = 0;
			btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btn_Sua.ForeColor = System.Drawing.Color.White;
			btn_Sua.Image = (System.Drawing.Image)resources.GetObject("btn_Sua.Image");
			btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			btn_Sua.Location = new System.Drawing.Point(32, 58);
			btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			btn_Sua.Name = "btn_Sua";
			btn_Sua.Size = new System.Drawing.Size(171, 32);
			btn_Sua.TabIndex = 1;
			btn_Sua.Text = "Sửa";
			btn_Sua.UseVisualStyleBackColor = false;
			btn_Sua.Click += btn_Sua_Click;
			// 
			// btn_Them
			// 
			btn_Them.BackColor = System.Drawing.Color.MediumSeaGreen;
			btn_Them.FlatAppearance.BorderSize = 0;
			btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btn_Them.ForeColor = System.Drawing.Color.White;
			btn_Them.Image = (System.Drawing.Image)resources.GetObject("btn_Them.Image");
			btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			btn_Them.Location = new System.Drawing.Point(31, 22);
			btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			btn_Them.Name = "btn_Them";
			btn_Them.Size = new System.Drawing.Size(172, 32);
			btn_Them.TabIndex = 0;
			btn_Them.Text = "Thêm";
			btn_Them.UseVisualStyleBackColor = false;
			btn_Them.Click += btn_Them_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(10, 28);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(32, 19);
			label2.TabIndex = 1;
			label2.Text = "Mã:";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(btn_Reset);
			groupBox2.Controls.Add(btn_Xoa);
			groupBox2.Controls.Add(btn_Sua);
			groupBox2.Controls.Add(btn_Them);
			groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			groupBox2.Location = new System.Drawing.Point(455, 9);
			groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			groupBox2.Size = new System.Drawing.Size(231, 237);
			groupBox2.TabIndex = 5;
			groupBox2.TabStop = false;
			groupBox2.Text = "Chức năng";
			// 
			// btn_Reset
			// 
			btn_Reset.BackColor = System.Drawing.Color.MediumSeaGreen;
			btn_Reset.FlatAppearance.BorderSize = 0;
			btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btn_Reset.ForeColor = System.Drawing.Color.White;
			btn_Reset.Image = (System.Drawing.Image)resources.GetObject("btn_Reset.Image");
			btn_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			btn_Reset.Location = new System.Drawing.Point(32, 130);
			btn_Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			btn_Reset.Name = "btn_Reset";
			btn_Reset.Size = new System.Drawing.Size(172, 32);
			btn_Reset.TabIndex = 3;
			btn_Reset.Text = "Reset";
			btn_Reset.UseVisualStyleBackColor = false;
			btn_Reset.Click += btn_Reset_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(10, 62);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(34, 19);
			label1.TabIndex = 0;
			label1.Text = "Tên:";
			// 
			// txt_TimKiem
			// 
			txt_TimKiem.Location = new System.Drawing.Point(-2, 244);
			txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			txt_TimKiem.Name = "txt_TimKiem";
			txt_TimKiem.Size = new System.Drawing.Size(263, 23);
			txt_TimKiem.TabIndex = 6;
			txt_TimKiem.Text = "Tìm kiếm...";
			txt_TimKiem.MouseClick += txt_TimKiem_MouseClick;
			txt_TimKiem.TextChanged += txt_TimKiem_TextChanged;
			txt_TimKiem.Leave += txt_TimKiem_Leave;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(date2);
			groupBox1.Controls.Add(date1);
			groupBox1.Controls.Add(txt_hinhthuc);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(rbtn_KHD);
			groupBox1.Controls.Add(rbtn_HD);
			groupBox1.Controls.Add(txt_Ten);
			groupBox1.Controls.Add(txt_Ma);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			groupBox1.ForeColor = System.Drawing.Color.Black;
			groupBox1.Location = new System.Drawing.Point(-3, 8);
			groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			groupBox1.Size = new System.Drawing.Size(452, 238);
			groupBox1.TabIndex = 4;
			groupBox1.TabStop = false;
			groupBox1.Text = "Khuyến mại";
			// 
			// date2
			// 
			date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			date2.Location = new System.Drawing.Point(120, 174);
			date2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			date2.Name = "date2";
			date2.Size = new System.Drawing.Size(219, 26);
			date2.TabIndex = 14;
			// 
			// date1
			// 
			date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			date1.Location = new System.Drawing.Point(120, 132);
			date1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			date1.Name = "date1";
			date1.Size = new System.Drawing.Size(219, 26);
			date1.TabIndex = 13;
			// 
			// txt_hinhthuc
			// 
			txt_hinhthuc.Location = new System.Drawing.Point(120, 98);
			txt_hinhthuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			txt_hinhthuc.Name = "txt_hinhthuc";
			txt_hinhthuc.Size = new System.Drawing.Size(219, 26);
			txt_hinhthuc.TabIndex = 12;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(13, 171);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(100, 19);
			label6.TabIndex = 11;
			label6.Text = "Ngày kết thúc:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(10, 137);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(97, 19);
			label4.TabIndex = 10;
			label4.Text = "Ngày bắt đầu:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(10, 102);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(75, 19);
			label5.TabIndex = 9;
			label5.Text = "Hình thức:";
			label5.Click += label5_Click;
			// 
			// FrmKhuyenMai
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.LightCoral;
			ClientSize = new System.Drawing.Size(690, 386);
			Controls.Add(dgrid_KM);
			Controls.Add(groupBox2);
			Controls.Add(txt_TimKiem);
			Controls.Add(groupBox1);
			Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			Name = "FrmKhuyenMai";
			Text = "FormKhuyenMai";
			((System.ComponentModel.ISupportInitialize)dgrid_KM).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.DataGridView dgrid_KM;
		private System.Windows.Forms.RadioButton rbtn_KHD;
		private System.Windows.Forms.RadioButton rbtn_HD;
		private System.Windows.Forms.TextBox txt_Ten;
		private System.Windows.Forms.TextBox txt_Ma;
		private System.Windows.Forms.Label label3;
		private RJControls.RJButton btn_Xoa;
		private RJControls.RJButton btn_Sua;
		private RJControls.RJButton btn_Them;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private RJControls.RJButton btn_Reset;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_TimKiem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker date2;
		private System.Windows.Forms.DateTimePicker date1;
		private System.Windows.Forms.TextBox txt_hinhthuc;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
	}
}