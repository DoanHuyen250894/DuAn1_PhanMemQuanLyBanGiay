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
            this.btn_guima = new _3_GUI.RJControls.RJButton();
            this.btn_xn = new _3_GUI.RJControls.RJButton();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.tb_gmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_guima
            // 
            this.btn_guima.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_guima.FlatAppearance.BorderSize = 0;
            this.btn_guima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guima.ForeColor = System.Drawing.Color.White;
            this.btn_guima.Location = new System.Drawing.Point(24, 102);
            this.btn_guima.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_guima.Name = "btn_guima";
            this.btn_guima.Size = new System.Drawing.Size(137, 40);
            this.btn_guima.TabIndex = 7;
            this.btn_guima.Text = "Gửi mã xác thực";
            this.btn_guima.UseVisualStyleBackColor = false;
            this.btn_guima.UseWaitCursor = true;
            this.btn_guima.Click += new System.EventHandler(this.btn_guima_Click_1);
            // 
            // btn_xn
            // 
            this.btn_xn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_xn.FlatAppearance.BorderSize = 0;
            this.btn_xn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xn.ForeColor = System.Drawing.Color.White;
            this.btn_xn.Location = new System.Drawing.Point(365, 102);
            this.btn_xn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xn.Name = "btn_xn";
            this.btn_xn.Size = new System.Drawing.Size(137, 40);
            this.btn_xn.TabIndex = 6;
            this.btn_xn.Text = "Xác nhận";
            this.btn_xn.UseVisualStyleBackColor = false;
            this.btn_xn.UseWaitCursor = true;
            this.btn_xn.Click += new System.EventHandler(this.btn_xn_Click_1);
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(168, 109);
            this.tb_ma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(190, 27);
            this.tb_ma.TabIndex = 5;
            this.tb_ma.UseWaitCursor = true;
            // 
            // tb_gmail
            // 
            this.tb_gmail.Location = new System.Drawing.Point(24, 57);
            this.tb_gmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_gmail.Name = "tb_gmail";
            this.tb_gmail.PlaceholderText = "Nhập gmail đã đăng kí tài khoản";
            this.tb_gmail.Size = new System.Drawing.Size(478, 27);
            this.tb_gmail.TabIndex = 4;
            this.tb_gmail.UseWaitCursor = true;
            // 
            // FrmTimKiemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(526, 199);
            this.Controls.Add(this.btn_guima);
            this.Controls.Add(this.btn_xn);
            this.Controls.Add(this.tb_ma);
            this.Controls.Add(this.tb_gmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTimKiemTaiKhoan";
            this.Text = "FrmTimKiemTaiKhoan";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJControls.RJButton btn_guima;
        private RJControls.RJButton btn_xn;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.TextBox tb_gmail;
    }
}