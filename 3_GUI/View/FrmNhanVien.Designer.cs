namespace _3_GUI.View
{
    partial class FrmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            groupBox1 = new System.Windows.Forms.GroupBox();
            panel1 = new System.Windows.Forms.Panel();
            rbtn_KHD = new System.Windows.Forms.RadioButton();
            label10 = new System.Windows.Forms.Label();
            rbtn_HD = new System.Windows.Forms.RadioButton();
            cmb_CV = new System.Windows.Forms.ComboBox();
            label12 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            rbtn_Nu = new System.Windows.Forms.RadioButton();
            rbtn_Nam = new System.Windows.Forms.RadioButton();
            date = new System.Windows.Forms.DateTimePicker();
            txt_GhiChu = new System.Windows.Forms.TextBox();
            txt_MatKhau = new System.Windows.Forms.TextBox();
            txt_DC = new System.Windows.Forms.TextBox();
            txt_CCCD = new System.Windows.Forms.TextBox();
            txt_SDT = new System.Windows.Forms.TextBox();
            txt_Email = new System.Windows.Forms.TextBox();
            txt_HoTen = new System.Windows.Forms.TextBox();
            txt_user = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btn_Clear = new RJControls.RJButton();
            btn_Xoa = new RJControls.RJButton();
            btn_Sua = new RJControls.RJButton();
            btn_Them = new RJControls.RJButton();
            dgrid_NhanVien = new System.Windows.Forms.DataGridView();
            txt_TimKiem = new System.Windows.Forms.TextBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_NhanVien).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(cmb_CV);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(rbtn_Nu);
            groupBox1.Controls.Add(rbtn_Nam);
            groupBox1.Controls.Add(date);
            groupBox1.Controls.Add(txt_GhiChu);
            groupBox1.Controls.Add(txt_MatKhau);
            groupBox1.Controls.Add(txt_DC);
            groupBox1.Controls.Add(txt_CCCD);
            groupBox1.Controls.Add(txt_SDT);
            groupBox1.Controls.Add(txt_Email);
            groupBox1.Controls.Add(txt_HoTen);
            groupBox1.Controls.Add(txt_user);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(5, 3);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Size = new System.Drawing.Size(531, 290);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // panel1
            // 
            panel1.Controls.Add(rbtn_KHD);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(rbtn_HD);
            panel1.Location = new System.Drawing.Point(262, 47);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(263, 36);
            panel1.TabIndex = 27;
            // 
            // rbtn_KHD
            // 
            rbtn_KHD.AutoSize = true;
            rbtn_KHD.Location = new System.Drawing.Point(176, 11);
            rbtn_KHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            rbtn_KHD.Name = "rbtn_KHD";
            rbtn_KHD.Size = new System.Drawing.Size(87, 23);
            rbtn_KHD.TabIndex = 23;
            rbtn_KHD.TabStop = true;
            rbtn_KHD.Text = "Nghỉ việc";
            rbtn_KHD.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(12, 11);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(75, 19);
            label10.TabIndex = 9;
            label10.Text = "Trạng thái:";
            // 
            // rbtn_HD
            // 
            rbtn_HD.AutoSize = true;
            rbtn_HD.Location = new System.Drawing.Point(86, 10);
            rbtn_HD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            rbtn_HD.Name = "rbtn_HD";
            rbtn_HD.Size = new System.Drawing.Size(87, 23);
            rbtn_HD.TabIndex = 22;
            rbtn_HD.TabStop = true;
            rbtn_HD.Text = "Đang làm";
            rbtn_HD.UseVisualStyleBackColor = true;
            // 
            // cmb_CV
            // 
            cmb_CV.FormattingEnabled = true;
            cmb_CV.Location = new System.Drawing.Point(83, 253);
            cmb_CV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cmb_CV.Name = "cmb_CV";
            cmb_CV.Size = new System.Drawing.Size(173, 27);
            cmb_CV.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(4, 258);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(64, 19);
            label12.TabIndex = 25;
            label12.Text = "Chức vụ:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pictureBox1.Location = new System.Drawing.Point(274, 151);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(251, 135);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // rbtn_Nu
            // 
            rbtn_Nu.AutoSize = true;
            rbtn_Nu.Location = new System.Drawing.Point(168, 120);
            rbtn_Nu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            rbtn_Nu.Name = "rbtn_Nu";
            rbtn_Nu.Size = new System.Drawing.Size(47, 23);
            rbtn_Nu.TabIndex = 21;
            rbtn_Nu.TabStop = true;
            rbtn_Nu.Text = "Nữ";
            rbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // rbtn_Nam
            // 
            rbtn_Nam.AutoSize = true;
            rbtn_Nam.Location = new System.Drawing.Point(84, 116);
            rbtn_Nam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            rbtn_Nam.Name = "rbtn_Nam";
            rbtn_Nam.Size = new System.Drawing.Size(57, 23);
            rbtn_Nam.TabIndex = 20;
            rbtn_Nam.TabStop = true;
            rbtn_Nam.Text = "Nam";
            rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // date
            // 
            date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            date.Location = new System.Drawing.Point(87, 86);
            date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            date.Name = "date";
            date.Size = new System.Drawing.Size(169, 26);
            date.TabIndex = 19;
            // 
            // txt_GhiChu
            // 
            txt_GhiChu.Location = new System.Drawing.Point(347, 112);
            txt_GhiChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txt_GhiChu.Name = "txt_GhiChu";
            txt_GhiChu.Size = new System.Drawing.Size(178, 26);
            txt_GhiChu.TabIndex = 18;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new System.Drawing.Point(348, 79);
            txt_MatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new System.Drawing.Size(177, 26);
            txt_MatKhau.TabIndex = 17;
            // 
            // txt_DC
            // 
            txt_DC.Location = new System.Drawing.Point(347, 17);
            txt_DC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txt_DC.Name = "txt_DC";
            txt_DC.Size = new System.Drawing.Size(178, 26);
            txt_DC.TabIndex = 16;
            // 
            // txt_CCCD
            // 
            txt_CCCD.Location = new System.Drawing.Point(84, 219);
            txt_CCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txt_CCCD.Name = "txt_CCCD";
            txt_CCCD.Size = new System.Drawing.Size(172, 26);
            txt_CCCD.TabIndex = 15;
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new System.Drawing.Point(84, 185);
            txt_SDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new System.Drawing.Size(172, 26);
            txt_SDT.TabIndex = 14;
            // 
            // txt_Email
            // 
            txt_Email.Location = new System.Drawing.Point(85, 151);
            txt_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new System.Drawing.Size(171, 26);
            txt_Email.TabIndex = 13;
            // 
            // txt_HoTen
            // 
            txt_HoTen.Location = new System.Drawing.Point(85, 52);
            txt_HoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.Size = new System.Drawing.Size(171, 26);
            txt_HoTen.TabIndex = 12;
            // 
            // txt_user
            // 
            txt_user.Location = new System.Drawing.Point(86, 18);
            txt_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txt_user.Name = "txt_user";
            txt_user.Size = new System.Drawing.Size(170, 26);
            txt_user.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(274, 119);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(61, 19);
            label11.TabIndex = 10;
            label11.Text = "Ghi chú:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(274, 20);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(56, 19);
            label9.TabIndex = 8;
            label9.Text = "Địa chỉ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(274, 86);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(71, 19);
            label8.TabIndex = 7;
            label8.Text = "Mật khẩu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 224);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(49, 19);
            label7.TabIndex = 6;
            label7.Text = "CCCD:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(10, 190);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(38, 19);
            label6.TabIndex = 5;
            label6.Text = "SĐT:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(10, 156);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(46, 19);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(5, 122);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(68, 19);
            label4.TabIndex = 3;
            label4.Text = "Giới tính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(4, 88);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(75, 19);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(5, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 19);
            label2.TabIndex = 1;
            label2.Text = "Họ tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 19);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Clear);
            groupBox2.Controls.Add(btn_Xoa);
            groupBox2.Controls.Add(btn_Sua);
            groupBox2.Controls.Add(btn_Them);
            groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox2.Location = new System.Drawing.Point(542, 3);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox2.Size = new System.Drawing.Size(158, 290);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = System.Drawing.Color.MediumSeaGreen;
            btn_Clear.FlatAppearance.BorderSize = 0;
            btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Clear.ForeColor = System.Drawing.Color.White;
            btn_Clear.Image = (System.Drawing.Image)resources.GetObject("btn_Clear.Image");
            btn_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_Clear.Location = new System.Drawing.Point(17, 235);
            btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new System.Drawing.Size(131, 28);
            btn_Clear.TabIndex = 3;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.BackColor = System.Drawing.Color.MediumSeaGreen;
            btn_Xoa.FlatAppearance.BorderSize = 0;
            btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Xoa.ForeColor = System.Drawing.Color.White;
            btn_Xoa.Image = (System.Drawing.Image)resources.GetObject("btn_Xoa.Image");
            btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_Xoa.Location = new System.Drawing.Point(17, 164);
            btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new System.Drawing.Size(131, 28);
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
            btn_Sua.Location = new System.Drawing.Point(17, 93);
            btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new System.Drawing.Size(131, 28);
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
            btn_Them.Location = new System.Drawing.Point(17, 22);
            btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new System.Drawing.Size(131, 28);
            btn_Them.TabIndex = 0;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = false;
            btn_Them.Click += btn_Them_Click;
            // 
            // dgrid_NhanVien
            // 
            dgrid_NhanVien.BackgroundColor = System.Drawing.Color.LightCoral;
            dgrid_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrid_NhanVien.Location = new System.Drawing.Point(4, 324);
            dgrid_NhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgrid_NhanVien.Name = "dgrid_NhanVien";
            dgrid_NhanVien.RowHeadersWidth = 51;
            dgrid_NhanVien.RowTemplate.Height = 29;
            dgrid_NhanVien.Size = new System.Drawing.Size(695, 100);
            dgrid_NhanVien.TabIndex = 2;
            dgrid_NhanVien.CellClick += dgrid_NhanVien_CellClick;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new System.Drawing.Point(4, 297);
            txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new System.Drawing.Size(695, 23);
            txt_TimKiem.TabIndex = 3;
            txt_TimKiem.TextChanged += txt_TimKiem_TextChanged;
            // 
            // FrmNhanVien
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightCoral;
            ClientSize = new System.Drawing.Size(700, 435);
            Controls.Add(txt_TimKiem);
            Controls.Add(dgrid_NhanVien);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "FrmNhanVien";
            Text = "FrmNhanVien";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrid_NhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrid_NhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtn_KHD;
        private System.Windows.Forms.RadioButton rbtn_HD;
        private System.Windows.Forms.RadioButton rbtn_Nu;
        private System.Windows.Forms.RadioButton rbtn_Nam;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_DC;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private RJControls.RJButton btn_Clear;
        private RJControls.RJButton btn_Xoa;
        private RJControls.RJButton btn_Sua;
        private RJControls.RJButton btn_Them;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb_CV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
    }
}