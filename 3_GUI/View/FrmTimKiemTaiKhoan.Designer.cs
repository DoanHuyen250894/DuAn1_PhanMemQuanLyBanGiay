namespace _3_GUI.View
{
    partial class FrmTimKiemTaiKhoan
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
            tb_gmail = new System.Windows.Forms.TextBox();
            tb_ma = new System.Windows.Forms.TextBox();
            btn_xn = new RJControls.RJButton();
            btn_guima = new RJControls.RJButton();
            SuspendLayout();
            // 
            // tb_gmail
            // 
            tb_gmail.Location = new System.Drawing.Point(12, 50);
            tb_gmail.Name = "tb_gmail";
            tb_gmail.Size = new System.Drawing.Size(419, 23);
            tb_gmail.TabIndex = 0;
            // 
            // tb_ma
            // 
            tb_ma.Location = new System.Drawing.Point(138, 89);
            tb_ma.Name = "tb_ma";
            tb_ma.Size = new System.Drawing.Size(167, 23);
            tb_ma.TabIndex = 1;
            // 
            // btn_xn
            // 
            btn_xn.BackColor = System.Drawing.Color.MediumSeaGreen;
            btn_xn.FlatAppearance.BorderSize = 0;
            btn_xn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_xn.ForeColor = System.Drawing.Color.White;
            btn_xn.Location = new System.Drawing.Point(311, 84);
            btn_xn.Name = "btn_xn";
            btn_xn.Size = new System.Drawing.Size(120, 30);
            btn_xn.TabIndex = 2;
            btn_xn.Text = "Xác nhận";
            btn_xn.UseVisualStyleBackColor = false;
            btn_xn.Click += btn_xn_Click;
            // 
            // btn_guima
            // 
            btn_guima.BackColor = System.Drawing.Color.MediumSeaGreen;
            btn_guima.FlatAppearance.BorderSize = 0;
            btn_guima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_guima.ForeColor = System.Drawing.Color.White;
            btn_guima.Location = new System.Drawing.Point(12, 84);
            btn_guima.Name = "btn_guima";
            btn_guima.Size = new System.Drawing.Size(120, 30);
            btn_guima.TabIndex = 3;
            btn_guima.Text = "Gửi mã xác thực";
            btn_guima.UseVisualStyleBackColor = false;
            btn_guima.Click += btn_guima_Click;
            // 
            // FrmTimKiemTaiKhoan
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(460, 149);
            Controls.Add(btn_guima);
            Controls.Add(btn_xn);
            Controls.Add(tb_ma);
            Controls.Add(tb_gmail);
            Name = "FrmTimKiemTaiKhoan";
            Text = "FrmTimKiemTaiKhoan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tb_gmail;
        private System.Windows.Forms.TextBox tb_ma;
        private RJControls.RJButton btn_xn;
        private RJControls.RJButton btn_guima;
    }
}