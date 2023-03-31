namespace _3_GUI.View
{
    partial class FrmKhachHang
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            rd_khachquen = new System.Windows.Forms.RadioButton();
            rd_khachvanglai = new System.Windows.Forms.RadioButton();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tb_point = new System.Windows.Forms.TextBox();
            tb_sdt = new System.Windows.Forms.TextBox();
            tb_hoten = new System.Windows.Forms.TextBox();
            tb_timkiem = new System.Windows.Forms.TextBox();
            dtg_show = new System.Windows.Forms.DataGridView();
            groupBox2 = new System.Windows.Forms.GroupBox();
            rjButton4 = new RJControls.RJButton();
            rjButton3 = new RJControls.RJButton();
            tb_sua = new RJControls.RJButton();
            btn_them = new RJControls.RJButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_show).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rd_khachquen);
            groupBox1.Controls.Add(rd_khachvanglai);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tb_point);
            groupBox1.Controls.Add(tb_sdt);
            groupBox1.Controls.Add(tb_hoten);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(385, 214);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // rd_khachquen
            // 
            rd_khachquen.AutoSize = true;
            rd_khachquen.Location = new System.Drawing.Point(255, 174);
            rd_khachquen.Name = "rd_khachquen";
            rd_khachquen.Size = new System.Drawing.Size(88, 19);
            rd_khachquen.TabIndex = 9;
            rd_khachquen.TabStop = true;
            rd_khachquen.Text = "Khách quen";
            rd_khachquen.UseVisualStyleBackColor = true;
            // 
            // rd_khachvanglai
            // 
            rd_khachvanglai.AutoSize = true;
            rd_khachvanglai.Location = new System.Drawing.Point(124, 174);
            rd_khachvanglai.Name = "rd_khachvanglai";
            rd_khachvanglai.Size = new System.Drawing.Size(102, 19);
            rd_khachvanglai.TabIndex = 8;
            rd_khachvanglai.TabStop = true;
            rd_khachvanglai.Text = "Khách vãng lai";
            rd_khachvanglai.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 178);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 15);
            label4.TabIndex = 7;
            label4.Text = "Trạng thái";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 90);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 15);
            label3.TabIndex = 6;
            label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 134);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 15);
            label2.TabIndex = 5;
            label2.Text = "Point";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 15);
            label1.TabIndex = 4;
            label1.Text = "Họ và tên";
            // 
            // tb_point
            // 
            tb_point.Location = new System.Drawing.Point(124, 126);
            tb_point.Name = "tb_point";
            tb_point.Size = new System.Drawing.Size(225, 23);
            tb_point.TabIndex = 2;
            // 
            // tb_sdt
            // 
            tb_sdt.Location = new System.Drawing.Point(124, 82);
            tb_sdt.Name = "tb_sdt";
            tb_sdt.Size = new System.Drawing.Size(225, 23);
            tb_sdt.TabIndex = 1;
            // 
            // tb_hoten
            // 
            tb_hoten.Location = new System.Drawing.Point(124, 38);
            tb_hoten.Name = "tb_hoten";
            tb_hoten.Size = new System.Drawing.Size(225, 23);
            tb_hoten.TabIndex = 0;
            // 
            // tb_timkiem
            // 
            tb_timkiem.Location = new System.Drawing.Point(12, 232);
            tb_timkiem.Name = "tb_timkiem";
            tb_timkiem.Size = new System.Drawing.Size(385, 23);
            tb_timkiem.TabIndex = 8;
            // 
            // dtg_show
            // 
            dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_show.Location = new System.Drawing.Point(12, 261);
            dtg_show.Name = "dtg_show";
            dtg_show.RowTemplate.Height = 25;
            dtg_show.Size = new System.Drawing.Size(591, 139);
            dtg_show.TabIndex = 9;
            dtg_show.CellClick += dtg_show_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rjButton4);
            groupBox2.Controls.Add(rjButton3);
            groupBox2.Controls.Add(tb_sua);
            groupBox2.Controls.Add(btn_them);
            groupBox2.Location = new System.Drawing.Point(402, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(200, 238);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // rjButton4
            // 
            rjButton4.BackColor = System.Drawing.Color.MediumSeaGreen;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton4.ForeColor = System.Drawing.Color.White;
            rjButton4.Location = new System.Drawing.Point(48, 187);
            rjButton4.Name = "rjButton4";
            rjButton4.Size = new System.Drawing.Size(120, 30);
            rjButton4.TabIndex = 3;
            rjButton4.Text = "Clear";
            rjButton4.UseVisualStyleBackColor = false;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = System.Drawing.Color.MediumSeaGreen;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton3.ForeColor = System.Drawing.Color.White;
            rjButton3.Location = new System.Drawing.Point(48, 135);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new System.Drawing.Size(120, 30);
            rjButton3.TabIndex = 2;
            rjButton3.Text = "Xóa khách hàng";
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += rjButton3_Click;
            // 
            // tb_sua
            // 
            tb_sua.BackColor = System.Drawing.Color.MediumSeaGreen;
            tb_sua.FlatAppearance.BorderSize = 0;
            tb_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            tb_sua.ForeColor = System.Drawing.Color.White;
            tb_sua.Location = new System.Drawing.Point(48, 83);
            tb_sua.Name = "tb_sua";
            tb_sua.Size = new System.Drawing.Size(120, 30);
            tb_sua.TabIndex = 1;
            tb_sua.Text = "Sửa khách hàng";
            tb_sua.UseVisualStyleBackColor = false;
            tb_sua.Click += tb_sua_Click;
            // 
            // btn_them
            // 
            btn_them.BackColor = System.Drawing.Color.MediumSeaGreen;
            btn_them.FlatAppearance.BorderSize = 0;
            btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_them.ForeColor = System.Drawing.Color.White;
            btn_them.Location = new System.Drawing.Point(48, 31);
            btn_them.Name = "btn_them";
            btn_them.Size = new System.Drawing.Size(120, 30);
            btn_them.TabIndex = 0;
            btn_them.Text = "Thêm khách hàng";
            btn_them.UseVisualStyleBackColor = false;
            btn_them.Click += btn_them_Click;
            // 
            // FrmKhachHang
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(614, 412);
            Controls.Add(groupBox2);
            Controls.Add(dtg_show);
            Controls.Add(tb_timkiem);
            Controls.Add(groupBox1);
            Name = "FrmKhachHang";
            Text = "FrmKhachHang";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_show).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_point;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.TextBox tb_hoten;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.RadioButton rd_khachquen;
        private System.Windows.Forms.RadioButton rd_khachvanglai;
        private System.Windows.Forms.DataGridView dtg_show;
        private System.Windows.Forms.GroupBox groupBox2;
        private RJControls.RJButton rjButton4;
        private RJControls.RJButton rjButton3;
        private RJControls.RJButton tb_sua;
        private RJControls.RJButton btn_them;
    }
}