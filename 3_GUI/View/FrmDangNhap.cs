using _2_BUS.IServices;
using _2_BUS.Services;
using Microsoft.Win32;
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
	public partial class FrmDangNhap : Form
	{
		INhanVienServices _INhanVienServices;
		public FrmDangNhap()
		{
			InitializeComponent();
			_INhanVienServices = new NhanVienServices();
		}
		private void label1_Click(object sender, EventArgs e)
		{

		}
		private void label2_Click(object sender, EventArgs e)
		{

		}
		private void label3_Click(object sender, EventArgs e)
		{

		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		public void saveInfor()
		{
			if (checkBox1.Checked == true)
			{
				Properties.Settings.Default.User = tb_use.Text;
				Properties.Settings.Default.Pass = tb_pass.Text;
				Properties.Settings.Default.TKdaLogin = tb_use.Text;
				Properties.Settings.Default.MKdaLogin = tb_pass.Text;
				Properties.Settings.Default.Save();

			}
			else
			{
				Properties.Settings.Default.User = "";
				Properties.Settings.Default.Pass = "";
				Properties.Settings.Default.TKdaLogin = tb_use.Text;
				Properties.Settings.Default.MKdaLogin = tb_pass.Text;
				Properties.Settings.Default.Save();
			}
		}
		private void btn_dangnhap_Click(object sender, EventArgs e)
		{
			var check = _INhanVienServices.GetAllViewNhanVien().Where(p => p.Username == tb_pass.Text && p.MatKhau == tb_use.Text);
			if (check != null)
			{
				saveInfor();
				this.Hide();
				FrmMain frmBanHang = new FrmMain();
				frmBanHang.ShowDialog();
				this.Close();
			}
			else
			{
				MessageBox.Show("Đăng nhập thất bại");
			}
		}

		private void lb_quenmk_Click(object sender, EventArgs e)
		{
			FrmTimKiemTaiKhoan tkm = new FrmTimKiemTaiKhoan();
			tkm.Show();
		}

		private void FrmDangNhap_Load(object sender, EventArgs e)
		{
			tb_use.Text = Properties.Settings.Default.User;
			tb_pass.Text = Properties.Settings.Default.Pass;
			if (Properties.Settings.Default.User != "")
			{
				checkBox1.Checked = true;
			}
		}
	}
}
