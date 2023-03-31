namespace _3_GUI.View
{
	partial class FrmHoaDon
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDon));
			dtg_hd = new System.Windows.Forms.DataGridView();
			groupBox1 = new System.Windows.Forms.GroupBox();
			btn_Xoa = new RJControls.RJButton();
			btn_TimKiem = new RJControls.RJButton();
			textBox1 = new System.Windows.Forms.TextBox();
			groupBox2 = new System.Windows.Forms.GroupBox();
			dtg_hdct = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)dtg_hd).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dtg_hdct).BeginInit();
			SuspendLayout();
			// 
			// dtg_hd
			// 
			dtg_hd.BackgroundColor = System.Drawing.Color.LightCoral;
			dtg_hd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtg_hd.Location = new System.Drawing.Point(0, 60);
			dtg_hd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			dtg_hd.Name = "dtg_hd";
			dtg_hd.RowHeadersWidth = 51;
			dtg_hd.RowTemplate.Height = 29;
			dtg_hd.Size = new System.Drawing.Size(1066, 291);
			dtg_hd.TabIndex = 0;
			dtg_hd.CellClick += dtg_hd_CellClick;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btn_Xoa);
			groupBox1.Controls.Add(btn_TimKiem);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Controls.Add(dtg_hd);
			groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			groupBox1.Location = new System.Drawing.Point(12, 11);
			groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			groupBox1.Size = new System.Drawing.Size(1071, 355);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "Hóa đơn";
			// 
			// btn_Xoa
			// 
			btn_Xoa.BackColor = System.Drawing.Color.MediumSeaGreen;
			btn_Xoa.FlatAppearance.BorderSize = 0;
			btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btn_Xoa.ForeColor = System.Drawing.Color.White;
			btn_Xoa.Image = (System.Drawing.Image)resources.GetObject("btn_Xoa.Image");
			btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			btn_Xoa.Location = new System.Drawing.Point(381, 24);
			btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			btn_Xoa.Name = "btn_Xoa";
			btn_Xoa.Size = new System.Drawing.Size(131, 28);
			btn_Xoa.TabIndex = 3;
			btn_Xoa.Text = "Xóa";
			btn_Xoa.UseVisualStyleBackColor = false;
			// 
			// btn_TimKiem
			// 
			btn_TimKiem.BackColor = System.Drawing.Color.MediumSeaGreen;
			btn_TimKiem.FlatAppearance.BorderSize = 0;
			btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btn_TimKiem.ForeColor = System.Drawing.Color.White;
			btn_TimKiem.Image = (System.Drawing.Image)resources.GetObject("btn_TimKiem.Image");
			btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			btn_TimKiem.Location = new System.Drawing.Point(244, 25);
			btn_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			btn_TimKiem.Name = "btn_TimKiem";
			btn_TimKiem.Size = new System.Drawing.Size(131, 28);
			btn_TimKiem.TabIndex = 2;
			btn_TimKiem.Text = "Tìm kiếm";
			btn_TimKiem.UseVisualStyleBackColor = false;
			// 
			// textBox1
			// 
			textBox1.Location = new System.Drawing.Point(0, 27);
			textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			textBox1.Name = "textBox1";
			textBox1.Size = new System.Drawing.Size(239, 29);
			textBox1.TabIndex = 1;
			textBox1.Text = "Tìm kiếm...";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(dtg_hdct);
			groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			groupBox2.Location = new System.Drawing.Point(12, 370);
			groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			groupBox2.Size = new System.Drawing.Size(1072, 345);
			groupBox2.TabIndex = 3;
			groupBox2.TabStop = false;
			groupBox2.Text = "Hóa đơn chi tiết";
			// 
			// dtg_hdct
			// 
			dtg_hdct.BackgroundColor = System.Drawing.Color.LightCoral;
			dtg_hdct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtg_hdct.Location = new System.Drawing.Point(6, 26);
			dtg_hdct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			dtg_hdct.Name = "dtg_hdct";
			dtg_hdct.RowHeadersWidth = 51;
			dtg_hdct.RowTemplate.Height = 29;
			dtg_hdct.Size = new System.Drawing.Size(1060, 315);
			dtg_hdct.TabIndex = 0;
			// 
			// FrmHoaDon
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1095, 722);
			Controls.Add(groupBox1);
			Controls.Add(groupBox2);
			Name = "FrmHoaDon";
			Text = "FrmHoaDon";
			((System.ComponentModel.ISupportInitialize)dtg_hd).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dtg_hdct).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.DataGridView dtg_hd;
		private System.Windows.Forms.GroupBox groupBox1;
		private RJControls.RJButton btn_Xoa;
		private RJControls.RJButton btn_TimKiem;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dtg_hdct;
	}
}