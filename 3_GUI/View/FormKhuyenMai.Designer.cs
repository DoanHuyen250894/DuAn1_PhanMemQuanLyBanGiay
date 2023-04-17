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
            this.dgrid_KM = new System.Windows.Forms.DataGridView();
            this.rbtn_KHD = new System.Windows.Forms.RadioButton();
            this.rbtn_HD = new System.Windows.Forms.RadioButton();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Xoa = new _3_GUI.RJControls.RJButton();
            this.btn_Sua = new _3_GUI.RJControls.RJButton();
            this.btn_Them = new _3_GUI.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Reset = new _3_GUI.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.txt_hinhthuc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_KM)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrid_KM
            // 
            this.dgrid_KM.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgrid_KM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_KM.Location = new System.Drawing.Point(-2, 357);
            this.dgrid_KM.Name = "dgrid_KM";
            this.dgrid_KM.RowHeadersWidth = 51;
            this.dgrid_KM.RowTemplate.Height = 29;
            this.dgrid_KM.Size = new System.Drawing.Size(786, 155);
            this.dgrid_KM.TabIndex = 7;
            this.dgrid_KM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_KM_CellContentClick_1);
            // 
            // rbtn_KHD
            // 
            this.rbtn_KHD.AutoSize = true;
            this.rbtn_KHD.Location = new System.Drawing.Point(245, 271);
            this.rbtn_KHD.Name = "rbtn_KHD";
            this.rbtn_KHD.Size = new System.Drawing.Size(166, 27);
            this.rbtn_KHD.TabIndex = 8;
            this.rbtn_KHD.TabStop = true;
            this.rbtn_KHD.Text = "Không hoạt động";
            this.rbtn_KHD.UseVisualStyleBackColor = true;
            // 
            // rbtn_HD
            // 
            this.rbtn_HD.AutoSize = true;
            this.rbtn_HD.Location = new System.Drawing.Point(103, 269);
            this.rbtn_HD.Name = "rbtn_HD";
            this.rbtn_HD.Size = new System.Drawing.Size(114, 27);
            this.rbtn_HD.TabIndex = 7;
            this.rbtn_HD.TabStop = true;
            this.rbtn_HD.Text = "Hoạt động";
            this.rbtn_HD.UseVisualStyleBackColor = true;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(137, 80);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(250, 30);
            this.txt_Ten.TabIndex = 5;
            this.txt_Ten.TextChanged += new System.EventHandler(this.txt_Ten_TextChanged_1);
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(138, 31);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(249, 30);
            this.txt_Ma.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng thái:";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(37, 125);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(195, 41);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click_1);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(37, 77);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(195, 43);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click_1);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(35, 29);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(197, 43);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Reset);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(520, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 316);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reset.Image")));
            this.btn_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reset.Location = new System.Drawing.Point(37, 173);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(197, 43);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(-2, 325);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(300, 27);
            this.txt_TimKiem.TabIndex = 6;
            this.txt_TimKiem.Text = "Tìm kiếm...";
            this.txt_TimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_TimKiem_MouseClick_1);
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged_1);
            this.txt_TimKiem.Leave += new System.EventHandler(this.txt_TimKiem_Leave_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date2);
            this.groupBox1.Controls.Add(this.date1);
            this.groupBox1.Controls.Add(this.txt_hinhthuc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rbtn_KHD);
            this.groupBox1.Controls.Add(this.rbtn_HD);
            this.groupBox1.Controls.Add(this.txt_Ten);
            this.groupBox1.Controls.Add(this.txt_Ma);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(-3, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 317);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khuyến mại";
            // 
            // date2
            // 
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(137, 232);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(250, 30);
            this.date2.TabIndex = 14;
            // 
            // date1
            // 
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(137, 176);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(250, 30);
            this.date1.TabIndex = 13;
            // 
            // txt_hinhthuc
            // 
            this.txt_hinhthuc.Location = new System.Drawing.Point(137, 131);
            this.txt_hinhthuc.Name = "txt_hinhthuc";
            this.txt_hinhthuc.Size = new System.Drawing.Size(250, 30);
            this.txt_hinhthuc.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngày kết thúc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày bắt đầu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hình thức:";
            // 
            // FrmKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(789, 515);
            this.Controls.Add(this.dgrid_KM);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKhuyenMai";
            this.Text = "FormKhuyenMai";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_KM)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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