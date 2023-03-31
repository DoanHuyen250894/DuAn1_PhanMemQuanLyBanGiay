namespace _3_GUI.View
{
    partial class FrmChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChucVu));
            dgrid_CV = new System.Windows.Forms.DataGridView();
            rbtn_KHD = new System.Windows.Forms.RadioButton();
            rbtn_HD = new System.Windows.Forms.RadioButton();
            txt_GhiChu = new System.Windows.Forms.RichTextBox();
            txt_Ten = new System.Windows.Forms.TextBox();
            txt_Ma = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btn_Xoa = new RJControls.RJButton();
            btn_Sua = new RJControls.RJButton();
            btn_Them = new RJControls.RJButton();
            label2 = new System.Windows.Forms.Label();
            btn_Reset = new RJControls.RJButton();
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            txt_TimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgrid_CV).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgrid_CV
            // 
            dgrid_CV.BackgroundColor = System.Drawing.Color.LightCoral;
            dgrid_CV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrid_CV.Location = new System.Drawing.Point(-2, 213);
            dgrid_CV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgrid_CV.Name = "dgrid_CV";
            dgrid_CV.RowHeadersWidth = 51;
            dgrid_CV.RowTemplate.Height = 29;
            dgrid_CV.Size = new System.Drawing.Size(704, 116);
            dgrid_CV.TabIndex = 15;
            dgrid_CV.CellClick += dgrid_CV_CellClick;
            // 
            // rbtn_KHD
            // 
            rbtn_KHD.AutoSize = true;
            rbtn_KHD.Location = new System.Drawing.Point(217, 94);
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
            rbtn_HD.Location = new System.Drawing.Point(99, 94);
            rbtn_HD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            rbtn_HD.Name = "rbtn_HD";
            rbtn_HD.Size = new System.Drawing.Size(94, 23);
            rbtn_HD.TabIndex = 7;
            rbtn_HD.TabStop = true;
            rbtn_HD.Text = "Hoạt động";
            rbtn_HD.UseVisualStyleBackColor = true;
            // 
            // txt_GhiChu
            // 
            txt_GhiChu.Location = new System.Drawing.Point(85, 121);
            txt_GhiChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txt_GhiChu.Name = "txt_GhiChu";
            txt_GhiChu.Size = new System.Drawing.Size(378, 42);
            txt_GhiChu.TabIndex = 6;
            txt_GhiChu.Text = "";
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new System.Drawing.Point(84, 60);
            txt_Ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new System.Drawing.Size(379, 26);
            txt_Ten.TabIndex = 5;
            txt_Ten.TextChanged += txt_Ten_TextChanged;
            // 
            // txt_Ma
            // 
            txt_Ma.Location = new System.Drawing.Point(85, 23);
            txt_Ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txt_Ma.Name = "txt_Ma";
            txt_Ma.Size = new System.Drawing.Size(378, 26);
            txt_Ma.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(10, 128);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(61, 19);
            label4.TabIndex = 3;
            label4.Text = "Ghi chú:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(10, 94);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtn_KHD);
            groupBox1.Controls.Add(rbtn_HD);
            groupBox1.Controls.Add(txt_GhiChu);
            groupBox1.Controls.Add(txt_Ten);
            groupBox1.Controls.Add(txt_Ma);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.ForeColor = System.Drawing.Color.Black;
            groupBox1.Location = new System.Drawing.Point(-3, 8);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Size = new System.Drawing.Size(469, 174);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức vụ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Reset);
            groupBox2.Controls.Add(btn_Xoa);
            groupBox2.Controls.Add(btn_Sua);
            groupBox2.Controls.Add(btn_Them);
            groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox2.Location = new System.Drawing.Point(472, 8);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox2.Size = new System.Drawing.Size(231, 174);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new System.Drawing.Point(7, 186);
            txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new System.Drawing.Size(690, 23);
            txt_TimKiem.TabIndex = 14;
            txt_TimKiem.Text = "Tìm kiếm...";
            txt_TimKiem.MouseClick += txt_TimKiem_MouseClick;
            txt_TimKiem.TextChanged += txt_TimKiem_TextChanged;
            txt_TimKiem.Leave += txt_TimKiem_Leave;
            // 
            // FrmChucVu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightCoral;
            ClientSize = new System.Drawing.Size(700, 338);
            Controls.Add(dgrid_CV);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(txt_TimKiem);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "FrmChucVu";
            Text = "FrmChucVu";
            ((System.ComponentModel.ISupportInitialize)dgrid_CV).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_CV;
        private System.Windows.Forms.RadioButton rbtn_KHD;
        private System.Windows.Forms.RadioButton rbtn_HD;
        private System.Windows.Forms.RichTextBox txt_GhiChu;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private RJControls.RJButton btn_Xoa;
        private RJControls.RJButton btn_Sua;
        private RJControls.RJButton btn_Them;
        private System.Windows.Forms.Label label2;
        private RJControls.RJButton btn_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_TimKiem;
    }
}