namespace _3_GUI.View
{
	partial class FrmSanPhamChiTiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSanPhamChiTiet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_KM = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_SLT = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgrid_SPCT = new System.Windows.Forms.DataGridView();
            this.btn_Clear = new _3_GUI.RJControls.RJButton();
            this.btn_Xoa = new _3_GUI.RJControls.RJButton();
            this.btn_Sua = new _3_GUI.RJControls.RJButton();
            this.btn_Them = new _3_GUI.RJControls.RJButton();
            this.btn_QR = new _3_GUI.RJControls.RJButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ptb_QR = new System.Windows.Forms.PictureBox();
            this.cmb_NCC = new System.Windows.Forms.ComboBox();
            this.cmb_Loai = new System.Windows.Forms.ComboBox();
            this.cmb_MS = new System.Windows.Forms.ComboBox();
            this.cmb_SZ = new System.Windows.Forms.ComboBox();
            this.cmb_TSP = new System.Windows.Forms.ComboBox();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_HH = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chk_CH = new System.Windows.Forms.CheckBox();
            this.txt_GiaNhap = new System.Windows.Forms.TextBox();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.txt_GiaBan = new System.Windows.Forms.TextBox();
            this.cmb_NSX = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_SPCT)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_QR)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 99);
            this.panel1.TabIndex = 14;
            // 
            // cmb_KM
            // 
            this.cmb_KM.FormattingEnabled = true;
            this.cmb_KM.Location = new System.Drawing.Point(101, 329);
            this.cmb_KM.Name = "cmb_KM";
            this.cmb_KM.Size = new System.Drawing.Size(162, 31);
            this.cmb_KM.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 332);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 23);
            this.label13.TabIndex = 28;
            this.label13.Text = "Khuyến mãi:";
            // 
            // txt_SLT
            // 
            this.txt_SLT.Location = new System.Drawing.Point(57, 285);
            this.txt_SLT.Name = "txt_SLT";
            this.txt_SLT.Size = new System.Drawing.Size(205, 30);
            this.txt_SLT.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 495);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 27);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgrid_SPCT
            // 
            this.dgrid_SPCT.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgrid_SPCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_SPCT.Location = new System.Drawing.Point(0, 521);
            this.dgrid_SPCT.Name = "dgrid_SPCT";
            this.dgrid_SPCT.RowHeadersWidth = 51;
            this.dgrid_SPCT.RowTemplate.Height = 29;
            this.dgrid_SPCT.Size = new System.Drawing.Size(1069, 210);
            this.dgrid_SPCT.TabIndex = 10;
            this.dgrid_SPCT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_SPCT_CellClick);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clear.Image")));
            this.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clear.Location = new System.Drawing.Point(37, 201);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(150, 37);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(37, 141);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(150, 37);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(33, 85);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(150, 37);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(33, 29);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(150, 37);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_QR
            // 
            this.btn_QR.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_QR.FlatAppearance.BorderSize = 0;
            this.btn_QR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QR.ForeColor = System.Drawing.Color.White;
            this.btn_QR.Location = new System.Drawing.Point(626, 488);
            this.btn_QR.Name = "btn_QR";
            this.btn_QR.Size = new System.Drawing.Size(150, 32);
            this.btn_QR.TabIndex = 13;
            this.btn_QR.Text = "Lấy mã QR";
            this.btn_QR.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Clear);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(855, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 383);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // ptb_QR
            // 
            this.ptb_QR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_QR.Location = new System.Drawing.Point(571, 96);
            this.ptb_QR.Name = "ptb_QR";
            this.ptb_QR.Size = new System.Drawing.Size(272, 281);
            this.ptb_QR.TabIndex = 26;
            this.ptb_QR.TabStop = false;
            this.ptb_QR.Click += new System.EventHandler(this.ptb_QR_Click);
            // 
            // cmb_NCC
            // 
            this.cmb_NCC.FormattingEnabled = true;
            this.cmb_NCC.Location = new System.Drawing.Point(59, 249);
            this.cmb_NCC.Name = "cmb_NCC";
            this.cmb_NCC.Size = new System.Drawing.Size(203, 31);
            this.cmb_NCC.TabIndex = 18;
            // 
            // cmb_Loai
            // 
            this.cmb_Loai.FormattingEnabled = true;
            this.cmb_Loai.Location = new System.Drawing.Point(66, 173);
            this.cmb_Loai.Name = "cmb_Loai";
            this.cmb_Loai.Size = new System.Drawing.Size(196, 31);
            this.cmb_Loai.TabIndex = 16;
            // 
            // cmb_MS
            // 
            this.cmb_MS.FormattingEnabled = true;
            this.cmb_MS.Location = new System.Drawing.Point(83, 136);
            this.cmb_MS.Name = "cmb_MS";
            this.cmb_MS.Size = new System.Drawing.Size(179, 31);
            this.cmb_MS.TabIndex = 15;
            // 
            // cmb_SZ
            // 
            this.cmb_SZ.FormattingEnabled = true;
            this.cmb_SZ.Location = new System.Drawing.Point(57, 96);
            this.cmb_SZ.Name = "cmb_SZ";
            this.cmb_SZ.Size = new System.Drawing.Size(205, 31);
            this.cmb_SZ.TabIndex = 14;
            // 
            // cmb_TSP
            // 
            this.cmb_TSP.FormattingEnabled = true;
            this.cmb_TSP.Location = new System.Drawing.Point(74, 59);
            this.cmb_TSP.Name = "cmb_TSP";
            this.cmb_TSP.Size = new System.Drawing.Size(188, 31);
            this.cmb_TSP.TabIndex = 13;
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(54, 19);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(207, 30);
            this.txt_Ma.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(571, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 23);
            this.label12.TabIndex = 11;
            this.label12.Text = "Trạng thái:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_KM);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_SLT);
            this.groupBox1.Controls.Add(this.ptb_QR);
            this.groupBox1.Controls.Add(this.chk_HH);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.chk_CH);
            this.groupBox1.Controls.Add(this.txt_GiaNhap);
            this.groupBox1.Controls.Add(this.txt_MoTa);
            this.groupBox1.Controls.Add(this.txt_GiaBan);
            this.groupBox1.Controls.Add(this.cmb_NCC);
            this.groupBox1.Controls.Add(this.cmb_NSX);
            this.groupBox1.Controls.Add(this.cmb_Loai);
            this.groupBox1.Controls.Add(this.cmb_MS);
            this.groupBox1.Controls.Add(this.cmb_SZ);
            this.groupBox1.Controls.Add(this.cmb_TSP);
            this.groupBox1.Controls.Add(this.txt_Ma);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 383);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản Phẩm Chi Tiết";
            // 
            // chk_HH
            // 
            this.chk_HH.AutoSize = true;
            this.chk_HH.Location = new System.Drawing.Point(667, 75);
            this.chk_HH.Name = "chk_HH";
            this.chk_HH.Size = new System.Drawing.Size(104, 27);
            this.chk_HH.TabIndex = 24;
            this.chk_HH.Text = "Hết hàng";
            this.chk_HH.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(332, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 290);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // chk_CH
            // 
            this.chk_CH.AutoSize = true;
            this.chk_CH.Location = new System.Drawing.Point(669, 51);
            this.chk_CH.Name = "chk_CH";
            this.chk_CH.Size = new System.Drawing.Size(107, 27);
            this.chk_CH.TabIndex = 23;
            this.chk_CH.Text = "Còn hàng";
            this.chk_CH.UseVisualStyleBackColor = true;
            // 
            // txt_GiaNhap
            // 
            this.txt_GiaNhap.Location = new System.Drawing.Point(655, 15);
            this.txt_GiaNhap.Name = "txt_GiaNhap";
            this.txt_GiaNhap.Size = new System.Drawing.Size(194, 30);
            this.txt_GiaNhap.TabIndex = 22;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Location = new System.Drawing.Point(368, 60);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(198, 30);
            this.txt_MoTa.TabIndex = 21;
            // 
            // txt_GiaBan
            // 
            this.txt_GiaBan.Location = new System.Drawing.Point(371, 13);
            this.txt_GiaBan.Name = "txt_GiaBan";
            this.txt_GiaBan.Size = new System.Drawing.Size(195, 30);
            this.txt_GiaBan.TabIndex = 20;
            // 
            // cmb_NSX
            // 
            this.cmb_NSX.FormattingEnabled = true;
            this.cmb_NSX.Location = new System.Drawing.Point(61, 211);
            this.cmb_NSX.Name = "cmb_NSX";
            this.cmb_NSX.Size = new System.Drawing.Size(201, 31);
            this.cmb_NSX.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(296, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "Mô tả:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(571, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Giá nhập:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Giá bán:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "SLT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "NCC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "NSX:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Màu sắc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên SP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã:";
            // 
            // FrmSanPhamChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1069, 743);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgrid_SPCT);
            this.Controls.Add(this.btn_QR);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSanPhamChiTiet";
            this.Text = "FrmSanPhamChiTiet";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_SPCT)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_QR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_KM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_SLT;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgrid_SPCT;
        private RJControls.RJButton btn_Clear;
        private RJControls.RJButton btn_Xoa;
        private RJControls.RJButton btn_Sua;
        private RJControls.RJButton btn_Them;
        private RJControls.RJButton btn_QR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox ptb_QR;
        private System.Windows.Forms.ComboBox cmb_NCC;
        private System.Windows.Forms.ComboBox cmb_Loai;
        private System.Windows.Forms.ComboBox cmb_MS;
        private System.Windows.Forms.ComboBox cmb_SZ;
        private System.Windows.Forms.ComboBox cmb_TSP;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_HH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chk_CH;
        private System.Windows.Forms.TextBox txt_GiaNhap;
        private System.Windows.Forms.TextBox txt_MoTa;
        private System.Windows.Forms.TextBox txt_GiaBan;
        private System.Windows.Forms.ComboBox cmb_NSX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}