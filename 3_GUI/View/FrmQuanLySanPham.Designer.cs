namespace _3_GUI.View
{
    partial class FrmQuanLySanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLySanPham));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýSảnPhẩmChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàSảnXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.màuSắcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hìnhThứcThanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Location = new System.Drawing.Point(4, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1129, 690);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 31);
            this.panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaShell;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSảnPhẩmChiTiếtToolStripMenuItem,
            this.sảnPhẩmToolStripMenuItem,
            this.sizeToolStripMenuItem,
            this.nhàCungCấpToolStripMenuItem,
            this.nhàSảnXuấtToolStripMenuItem,
            this.loạiToolStripMenuItem,
            this.màuSắcToolStripMenuItem,
            this.hìnhThứcThanhToánToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Quản lý sản phẩm chi tiết";
            // 
            // quảnLýSảnPhẩmChiTiếtToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmChiTiếtToolStripMenuItem.Name = "quảnLýSảnPhẩmChiTiếtToolStripMenuItem";
            this.quảnLýSảnPhẩmChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.quảnLýSảnPhẩmChiTiếtToolStripMenuItem.Text = "Quản lý sản phẩm chi tiết";
            this.quảnLýSảnPhẩmChiTiếtToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSảnPhẩmChiTiếtToolStripMenuItem_Click);
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sảnPhẩmToolStripMenuItem.Image")));
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            this.sảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sizeToolStripMenuItem.Image")));
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.sizeToolStripMenuItem.Text = "Size";
            this.sizeToolStripMenuItem.Click += new System.EventHandler(this.sizeToolStripMenuItem_Click);
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nhàCungCấpToolStripMenuItem.Image")));
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            this.nhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.nhàCungCấpToolStripMenuItem_Click);
            // 
            // nhàSảnXuấtToolStripMenuItem
            // 
            this.nhàSảnXuấtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nhàSảnXuấtToolStripMenuItem.Image")));
            this.nhàSảnXuấtToolStripMenuItem.Name = "nhàSảnXuấtToolStripMenuItem";
            this.nhàSảnXuấtToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.nhàSảnXuấtToolStripMenuItem.Text = "Nhà sản xuất";
            this.nhàSảnXuấtToolStripMenuItem.Click += new System.EventHandler(this.nhàSảnXuấtToolStripMenuItem_Click);
            // 
            // loạiToolStripMenuItem
            // 
            this.loạiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loạiToolStripMenuItem.Image")));
            this.loạiToolStripMenuItem.Name = "loạiToolStripMenuItem";
            this.loạiToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.loạiToolStripMenuItem.Text = "Loại";
            this.loạiToolStripMenuItem.Click += new System.EventHandler(this.loạiToolStripMenuItem_Click);
            // 
            // màuSắcToolStripMenuItem
            // 
            this.màuSắcToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("màuSắcToolStripMenuItem.Image")));
            this.màuSắcToolStripMenuItem.Name = "màuSắcToolStripMenuItem";
            this.màuSắcToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.màuSắcToolStripMenuItem.Text = "Màu sắc ";
            this.màuSắcToolStripMenuItem.Click += new System.EventHandler(this.màuSắcToolStripMenuItem_Click);
            // 
            // hìnhThứcThanhToánToolStripMenuItem
            // 
            this.hìnhThứcThanhToánToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hìnhThứcThanhToánToolStripMenuItem.Image")));
            this.hìnhThứcThanhToánToolStripMenuItem.Name = "hìnhThứcThanhToánToolStripMenuItem";
            this.hìnhThứcThanhToánToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.hìnhThứcThanhToánToolStripMenuItem.Text = "Hình thức thanh toán";
            this.hìnhThứcThanhToánToolStripMenuItem.Click += new System.EventHandler(this.hìnhThứcThanhToánToolStripMenuItem_Click);
            // 
            // FrmQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1133, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQuanLySanPham";
            this.Text = "FrmQuanLySanPham";
            this.Load += new System.EventHandler(this.FrmQuanLySanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmChiTiếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàSảnXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem màuSắcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hìnhThứcThanhToánToolStripMenuItem;
    }
}