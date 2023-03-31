namespace _3_GUI.View
{
    partial class FrmQuenMatKhau
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
            tb_ma = new System.Windows.Forms.TextBox();
            tb_email = new System.Windows.Forms.TextBox();
            lb_loichao = new System.Windows.Forms.Label();
            tb_pass = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btn_xacnhan = new RJControls.RJButton();
            SuspendLayout();
            // 
            // tb_ma
            // 
            tb_ma.Location = new System.Drawing.Point(207, 42);
            tb_ma.Name = "tb_ma";
            tb_ma.Size = new System.Drawing.Size(350, 23);
            tb_ma.TabIndex = 0;
            // 
            // tb_email
            // 
            tb_email.Location = new System.Drawing.Point(207, 83);
            tb_email.Name = "tb_email";
            tb_email.Size = new System.Drawing.Size(350, 23);
            tb_email.TabIndex = 1;
            // 
            // lb_loichao
            // 
            lb_loichao.AutoSize = true;
            lb_loichao.Location = new System.Drawing.Point(207, 9);
            lb_loichao.Name = "lb_loichao";
            lb_loichao.Size = new System.Drawing.Size(38, 15);
            lb_loichao.TabIndex = 2;
            lb_loichao.Text = "label1";
            // 
            // tb_pass
            // 
            tb_pass.Location = new System.Drawing.Point(207, 124);
            tb_pass.Name = "tb_pass";
            tb_pass.Size = new System.Drawing.Size(350, 23);
            tb_pass.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(105, 132);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 15);
            label1.TabIndex = 4;
            label1.Text = "Mat khau moi";
            // 
            // btn_xacnhan
            // 
            btn_xacnhan.BackColor = System.Drawing.Color.MediumSeaGreen;
            btn_xacnhan.FlatAppearance.BorderSize = 0;
            btn_xacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_xacnhan.ForeColor = System.Drawing.Color.White;
            btn_xacnhan.Location = new System.Drawing.Point(437, 153);
            btn_xacnhan.Name = "btn_xacnhan";
            btn_xacnhan.Size = new System.Drawing.Size(120, 30);
            btn_xacnhan.TabIndex = 5;
            btn_xacnhan.Text = "Xac nhan";
            btn_xacnhan.UseVisualStyleBackColor = false;
            btn_xacnhan.Click += btn_xacnhan_Click;
            // 
            // FrmQuenMatKhau
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(578, 193);
            Controls.Add(btn_xacnhan);
            Controls.Add(label1);
            Controls.Add(tb_pass);
            Controls.Add(lb_loichao);
            Controls.Add(tb_email);
            Controls.Add(tb_ma);
            Name = "FrmQuenMatKhau";
            Text = "FrmQuenMatKhau";
            Load += FrmQuenMatKhau_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_loichao;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label label1;
        private RJControls.RJButton btn_xacnhan;
    }
}