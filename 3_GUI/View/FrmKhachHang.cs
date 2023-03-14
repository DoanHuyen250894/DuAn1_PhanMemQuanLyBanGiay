using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewMolder;
using _3_GUI.Utilities;


namespace _3_GUI.View
{
    public partial class FrmKhachHang : Form
    {
        private IKhachHangServices _khachHangServices;
        private Guid _Id;
        private ViewKhachHang vw;
      
        public FrmKhachHang()
        {
            InitializeComponent();
            _khachHangServices = new KhachHangServices();
            rbtn_Nam.Checked = true;
           
            LoadData();

        }
        public void LoadData()
        {
            int stt = 1;
            dgrid_KhachHang.ColumnCount = 7;
            dgrid_KhachHang.Columns[1].Name = "Id";
            dgrid_KhachHang.Columns[2].Name = "Họ và tên";
            dgrid_KhachHang.Columns[3].Name = "Giới tính";
            dgrid_KhachHang.Columns[4].Name = "Ngày sinh";
            dgrid_KhachHang.Columns[5].Name = "SĐT";
            dgrid_KhachHang.Columns[6].Name = "Địa chỉ";
           
          
            dgrid_KhachHang.Rows.Clear();
            foreach (var x in _khachHangServices.GetAll())
            {
                dgrid_KhachHang.Rows.Add(stt++, x.ID, x.Ho + " " + x.TenDem + " " + x.Ten, x.GioiTinh, x.NgaySinh, x.SDT, x.DiaChi + "," + x.ThanhPho + "," + x.QuocGia);
            }
        }
        public void LoadData(string input)
        {
            int stt = 1;
            dgrid_KhachHang.ColumnCount = 7;
            dgrid_KhachHang.Columns[1].Name = "Id";
            dgrid_KhachHang.Columns[2].Name = "Họ và tên";
            dgrid_KhachHang.Columns[3].Name = "Giới tính";
            dgrid_KhachHang.Columns[4].Name = "Ngày sinh";
            dgrid_KhachHang.Columns[5].Name = "SĐT";
            dgrid_KhachHang.Columns[6].Name = "Địa chỉ";

           
            dgrid_KhachHang.Rows.Clear();
            foreach (var x in _khachHangServices.GetAll(input))
            {
                dgrid_KhachHang.Rows.Add(stt++, x.ID, x.Ho + " " + x.TenDem + " " + x.Ten, x.GioiTinh, x.NgaySinh, x.SDT, x.DiaChi + "," + x.ThanhPho + "," + x.QuocGia);
            }
        }
        public void Reset()
        {
            LoadData();
            vw = null;
            txt_ho.Text = "";
            txt_Ten.Text = "";
            txt_TenDem.Text = "";
            txt_SDT.Text = "";
            txt_DiaChi.Text = "";
            txt_QuocGia.Text = "Việt Nam";
            txt_TimKiem.Text = "Tìm Kiếm...";
            txt_ThanhPho.Text = "";
           
            rbtn_Nam.Checked = true;
            rbtn_Nu.Checked = false;


        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public ViewKhachHang GetData()
        {
            ViewKhachHang kh = new ViewKhachHang() { 
                ID = Guid.Empty,
                Ho = txt_ho.Text,
                TenDem = txt_TenDem.Text,
                Ten = txt_Ten.Text,
                GioiTinh = rbtn_Nam.Checked == true ? "Nam" : "Nữ",
                NgaySinh = date.Value,
                SDT = txt_SDT.Text,
                DiaChi= txt_DiaChi.Text,
                ThanhPho = txt_ThanhPho.Text,
                QuocGia = txt_QuocGia.Text,
               
                Poin = 1000,
            };
            return kh;
        }

        public bool checknhap()
        {
            if (txt_Ten.Text == "" || txt_DiaChi.Text == "" || txt_ho.Text == "" || txt_TenDem.Text == "" || txt_SDT.Text == "" || txt_ThanhPho.Text == "") return false;
            return true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
          
            if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            
            else
            {
                DialogResult di = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Thông báo", MessageBoxButtons.YesNo);
                if (di == DialogResult.Yes)
                {
                    MessageBox.Show(_khachHangServices.Add(GetData()));
                    LoadData();
                }
                if (di == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            else
            {
                DialogResult di = MessageBox.Show("Bạn có chắc chắn muốn sửa ko?", "Thông báo", MessageBoxButtons.YesNo);
                if (di == DialogResult.Yes)
                {
                    var temp = GetData();
                    temp.ID = _Id;
                    MessageBox.Show(_khachHangServices.Update(temp));
                    LoadData();
                }
                if (di == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult di = MessageBox.Show("Bạn có chắc chắn muốn xóa ko?", "Thông báo", MessageBoxButtons.YesNo);
            if (di == DialogResult.Yes)
            {
                var temp = GetData();
                temp.ID = _Id;
                MessageBox.Show(_khachHangServices.Delete(temp));
                LoadData();
            }
            if (di == DialogResult.No)
            {
                return;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
           
                Reset();
            
         
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            int stt = 1;
            dgrid_KhachHang.ColumnCount = 7;
            dgrid_KhachHang.Columns[1].Name = "Id";
            dgrid_KhachHang.Columns[2].Name = "Họ và tên";
            dgrid_KhachHang.Columns[3].Name = "Giới tính";
            dgrid_KhachHang.Columns[4].Name = "Ngày sinh";
            dgrid_KhachHang.Columns[5].Name = "SĐT";
            dgrid_KhachHang.Columns[6].Name = "Địa chỉ";

            
            dgrid_KhachHang.Rows.Clear();
            foreach (var x in _khachHangServices.GetAll(txt_TimKiem.Text))
            {
                dgrid_KhachHang.Rows.Add(stt++, x.ID, x.Ho + " " + x.TenDem + " " + x.Ten, x.GioiTinh, x.NgaySinh, x.SDT, x.DiaChi + "," + x.ThanhPho + "," + x.QuocGia );
            }
        }

        private void dgrid_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _Id = Guid.Parse(dgrid_KhachHang.CurrentRow.Cells[1].Value.ToString());
            var KH = _khachHangServices.GetAll().FirstOrDefault(c => c.ID == _Id);
     
            txt_ho.Text = KH.Ho;
            txt_TenDem.Text = KH.TenDem;
            txt_Ten.Text = KH.Ten;
            txt_SDT.Text = KH.SDT;
            txt_ThanhPho.Text = KH.ThanhPho;
           txt_QuocGia.Text = KH.QuocGia;
           txt_DiaChi.Text = KH.DiaChi;
           
            date.Value = KH.NgaySinh;
            if (KH.GioiTinh == "Nam")
            {
                rbtn_Nam.Checked = true;
            }
            rbtn_Nu.Checked = true;
            
        }

        private void txt_ho_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ho_Leave(object sender, EventArgs e)
        {
            txt_ho.Text = Utilities.Utilities.VietHoaChuCaiDau(txt_ho.Text);
          Utilities.Utilities.CheckSo(txt_ho.Text);
        }

        private void txt_TenDem_Leave(object sender, EventArgs e)
        {
            txt_TenDem.Text = Utilities.Utilities.VietHoaChuCaiDau(txt_TenDem.Text);
           Utilities.Utilities.CheckSo(txt_TenDem.Text);
        }

        private void txt_Ten_Leave(object sender, EventArgs e)
        {
            txt_Ten.Text = Utilities.Utilities.VietHoaChuCaiDau(txt_Ten.Text);
          Utilities.Utilities.CheckSo(txt_Ten.Text);
        }

        private void txt_ThanhPho_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void txt_SDT_TextChanged(object sender, EventArgs e)
        {
         //  Utilities.Utilities.CheckSDT(txt_SDT.Text);
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txt_DiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DiaChi_Leave(object sender, EventArgs e)
        {

            
        }

        private void txt_ThanhPho_Leave(object sender, EventArgs e)
        {
            txt_ThanhPho.Text = Utilities.Utilities.VietHoaChuCaiDau(txt_ThanhPho.Text);
            Utilities.Utilities.CheckSo(txt_ThanhPho.Text);
        }
    }
}
