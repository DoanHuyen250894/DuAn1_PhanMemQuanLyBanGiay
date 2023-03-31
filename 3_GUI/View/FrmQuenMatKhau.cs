using _1_DAL.DomainMolder;
using _2_BUS.IServices;
using _2_BUS.Services;
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
    public partial class FrmQuenMatKhau : Form
    {
        public NhanVien _nv;
        INhanVienServices _INhanVienServices;
        public FrmQuenMatKhau()
        {
            InitializeComponent();
            _INhanVienServices = new NhanVienServices();
        }

        private void FrmQuenMatKhau_Load(object sender, EventArgs e)
        {
            lb_loichao.Text = "Xin chao:" + _nv.HoTen;
            tb_ma.Text = _nv.Username;
            tb_ma.Enabled = false;
            tb_email.Text = _nv.Email;
            tb_email.Enabled = false;
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            var a = _INhanVienServices.GetAllViewNhanVien().FirstOrDefault(c => c.Email == tb_email.Text).ID;
            var d = _INhanVienServices.GetAllViewNhanVien().FirstOrDefault(p => p.ID == a);
            d.MatKhau = tb_pass.Text;
            _INhanVienServices.UpdateNhanVien(d);
            MessageBox.Show("Thay doi mat khau thanh cong, Ban se duoc dua tro lai trang dang nhap");
            this.Hide();
            FrmDangNhap frmdn = new FrmDangNhap();
            frmdn.ShowDialog();
        }
    }
}
