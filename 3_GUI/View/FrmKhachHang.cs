using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewMolder;
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

namespace _3_GUI.View
{
    public partial class FrmKhachHang : Form
    {
        IKhachHangServices _IKhachHangServices;
        public Guid ID;
        List<ViewKhachHang> _lstViewKhachHang;
        public FrmKhachHang()
        {
            InitializeComponent();
            _IKhachHangServices = new KhachHangServices();
            _lstViewKhachHang = new List<ViewKhachHang>();
            LoadData();
        }

        public void LoadData()
        {
            dtg_show.Rows.Clear();
            dtg_show.ColumnCount = 5;
            dtg_show.Columns[0].Name = "ID";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "Ho va Ten";
            dtg_show.Columns[2].Name = "So dien thoai";
            dtg_show.Columns[3].Name = "Point";
            dtg_show.Columns[4].Name = "Trang thai";
            _lstViewKhachHang = _IKhachHangServices.GetAllViewKhachHang();
            if (tb_timkiem.Text != "")
            {
                _lstViewKhachHang.Where(c => c.HovaTen.Contains(tb_hoten.Text) || c.SDT.StartsWith(tb_sdt.Text)).ToList();
            }
            foreach(var a in _lstViewKhachHang)
            {
                dtg_show.Rows.Add(a.ID, a.HovaTen, a.SDT, a.Poin, a.TrangThai == 0?"Khách vãng lai":"Khách quen");
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ViewKhachHang kh = new ViewKhachHang()
            {
                HovaTen = tb_hoten.Text,
                Poin = Convert.ToInt32(tb_point.Text),
                SDT = tb_sdt.Text,
                TrangThai = rd_khachvanglai.Checked == false ? 1 : 0,
            };
            _IKhachHangServices.Add(kh);
            LoadData();
            MessageBox.Show("Them khach hang thanh cong");
        }

        private void tb_sua_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Ban co muon sua khach hang khong????");
            if (dg == DialogResult.OK)
            {
                ViewKhachHang kh = new ViewKhachHang()
                {
                    ID = ID,
                    HovaTen = tb_hoten.Text,
                    Poin = Convert.ToInt32(tb_point.Text),
                    SDT = tb_sdt.Text,
                    TrangThai = rd_khachvanglai.Checked == false ? 1 : 0,
                };
                _IKhachHangServices.Update(kh);
                LoadData();
                MessageBox.Show("Sua khach hang thanh cong");
            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa khach hang không?", "Chú ý", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                _IKhachHangServices.Delete(ID);
                MessageBox.Show("Xoa khach hang thanh cong");
                LoadData();
            }
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_show.Rows[e.RowIndex];
                ID = Guid.Parse(dtg_show.Rows[e.RowIndex].Cells[0].Value.ToString());
                var kh = _IKhachHangServices.GetAllViewKhachHang().FirstOrDefault(x=>x.ID == ID);
                tb_hoten.Text = kh.HovaTen;
                tb_point.Text = Convert.ToString(kh.Poin);
                tb_sdt.Text = Convert.ToString(kh.SDT);
                rd_khachvanglai.Checked = (kh.TrangThai == 1)? true: false;
                rd_khachquen.Checked = (kh.TrangThai != 1) ? true : false;
            }
        }
    }
}
