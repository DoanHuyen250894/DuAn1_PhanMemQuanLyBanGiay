using _2_BUS.IServices;
using _2_BUS.Services;
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
	public partial class FrmHoaDon : Form
	{
		IHoaDonChiTietServices _IHDCTServices;
		IHoaDonServices _IHDServices;
		ISanPhamChiTietServices _ISPServices;
		public Guid _ID;
		public FrmHoaDon()
		{
			InitializeComponent();
			_IHDCTServices = new HoaDonChiTietServices();
			_IHDServices = new HoaDonServices();
			_ISPServices = new SanPhamChiTietServices();
			dtg_hd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dtg_hdct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			loadHD();
		}
		public void loadHD()
		{
			dtg_hd.ColumnCount = 9;
			dtg_hd.Columns[0].Name = " ID";
			dtg_hd.Columns[0].Visible = false;
			dtg_hd.Columns[1].Name = " Mã";
			dtg_hd.Columns[2].Name = " Ngày Tạo";
			dtg_hd.Columns[3].Name = " Ngày Thanh Toan";
			dtg_hd.Columns[4].Name = " Tên Nhan Vien";
			dtg_hd.Columns[5].Name = " Tên Khach Hang";
			dtg_hd.Columns[6].Name = " SDT";
			dtg_hd.Columns[7].Name = " Thành Tiền";
			dtg_hd.Columns[8].Name = " Trạng Thái";
			//dtg_hd.Columns[8].Name = " Ghi chú";
			dtg_hd.Rows.Clear();
			foreach (var item in _IHDServices.GetAll())
			{
				dtg_hd.Rows.Add(item.ID, item.Ma, item.NgayTao, item.NgayThanhToan, item.TenNV, item.TenKH, item.SDT, item.ThanhTien, item.TrangThai == 1 ? "Đã thanh toán" : "Chờ thanh toán");
			}
		}
		public void loadHDCT(Guid id)
		{
			_ID = id;
			dtg_hdct.Rows.Clear();
			dtg_hdct.ColumnCount = 5;
			dtg_hdct.Columns[0].Name = "ID";
			dtg_hdct.Columns[0].Visible = false;
			dtg_hdct.Columns[1].Name = "IDSPCT";
			dtg_hdct.Columns[2].Name = "TenSp";
			dtg_hdct.Columns[3].Name = "So Luong";
			dtg_hdct.Columns[4].Name = "Don Gia";
			foreach (var item in _IHDCTServices.GetAll(id))
			{
				dtg_hdct.Rows.Add(item.ID, item.IDSPCT, item.TenSP, item.SoLuong, item.DonGia);
			}
		}

		private void dtg_hd_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				_ID = Guid.Parse(dtg_hd.Rows[e.RowIndex].Cells[0].Value.ToString());
				loadHDCT(_ID);
			}
		}

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}
