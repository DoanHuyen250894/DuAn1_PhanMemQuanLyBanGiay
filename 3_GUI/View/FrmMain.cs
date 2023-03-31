using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI.View
{
	public partial class FrmMain : Form
	{
		public FrmMain()
		{
			InitializeComponent();
		}

		private void btn_SP_Click(object sender, EventArgs e)
		{
			FrmQuanLySanPham spct = new FrmQuanLySanPham();
			spct.Dock = DockStyle.Fill;
			spct.TopLevel = false;
			spct.TopMost = true;
			this.panel2_Load.Controls.Clear();
			this.panel2_Load.Controls.Add(spct);
			spct.Show();
		}

		private void btn_KH_Click(object sender, EventArgs e)
		{
			FrmKhachHang kh = new FrmKhachHang();
			kh.Dock = DockStyle.Fill;
			kh.TopLevel = false;
			kh.TopMost = true;
			this.panel2_Load.Controls.Clear();
			this.panel2_Load.Controls.Add(kh);
			kh.Show();
		}

		private void btn_NhanVien_Click(object sender, EventArgs e)
		{
			FrmNhanVien nv = new FrmNhanVien();
			nv.Show();
		}

		private void btn_BanHang_Click(object sender, EventArgs e)
		{
			FrmBanHang bh = new FrmBanHang();
			bh.Dock = DockStyle.Fill;
			bh.TopLevel = false;
			bh.TopMost = true;
			this.panel2_Load.Controls.Clear();
			this.panel2_Load.Controls.Add(bh);
			bh.Show();

		}

		private void btn_HD_Click(object sender, EventArgs e)
		{
			FrmHoaDon hd = new FrmHoaDon();
			hd.Show();
		}

		private void btn_TK_Click(object sender, EventArgs e)
		{

		}
	}
}
