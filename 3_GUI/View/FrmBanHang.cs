using _1_DAL.DomainMolder;
using _1_DAL.IRepository;
using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewMolder;
using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace _3_GUI.View
{
	public partial class FrmBanHang : Form
	{
		ISanPhamChiTietServices _ISanPhamChiTietServices;
		IHinhThucThanhToanServices _IHTTTServices;
		IKhachHangServices _IKhachHangServices;
		INhanVienServices _INhanVienServices;
		IHoaDonServices _IHoaDonServices;
		IHoaDonChiTietServices _IHoaDonChiTietServices;
		List<ViewSanPhamChiTiet> _lstViewSpct;
		List<ViewHoaDonCT> _lstViewHDct;
		List<ViewHoaDon> _lstViewHD;
		ViewSanPhamChiTiet _vspct;
		FilterInfoCollection FilterInfoCollection;
		VideoCaptureDevice VideoCaptureDevice;
		private double tongtien = 0;
		private bool isFound = false;
		public Guid _ID;
		public Guid _ID2;
		public Guid _ID3;
		public Guid _ID4;
		public Guid _ID5;
		public string _Ma;
		public string _Images;
		public FrmBanHang()
		{
			InitializeComponent();
			_INhanVienServices = new NhanVienServices();
			_IHoaDonServices = new HoaDonServices();
			_lstViewHD = new List<ViewHoaDon>();
			_vspct = new ViewSanPhamChiTiet();
			_IHTTTServices = new HinhThucThanhToanServices();
			_lstViewHDct = new List<ViewHoaDonCT>();
			_ISanPhamChiTietServices = new SanPhamChiTietServices();
			_lstViewSpct = new List<ViewSanPhamChiTiet>();
			_IKhachHangServices = new KhachHangServices();
			_IHoaDonChiTietServices = new HoaDonChiTietServices();
			FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
			LoadDataSp();
			LoadHTTT();
			loadCam();
			LoadGioHang();
			LoadHoaDonChuaThanhToan();
			LoadCheckBox();
			tb_tongiatri.Enabled = false;
			tb_tensp.Enabled = false;
			tb_loaisp.Enabled = false;
			tb_size.Enabled = false;
			tb_mausac.Enabled = false;
			tb_nsx.Enabled = false;
			tb_ncc.Enabled = false;
			tb_khuyenmai.Enabled = false;
			tb_soluongton.Enabled = false;
			tb_gianhap.Enabled = false;
			tb_giaban.Enabled = false;
			tb_mota.Enabled = false;
			rd_conhang.Enabled = false;
			tb_giatrigiohang.Enabled = false;
			rd_hethang.Enabled = false;
			tb_pont.Enabled = false;
			tb_ma.Enabled = false;
			dtg_giohang.AllowUserToAddRows = false;
			dtg_sanpham.AllowUserToAddRows = false;
			dtg_hd.AllowUserToAddRows = false;
			dtg_sanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dtg_giohang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dtg_hd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dtg_hdct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}
		public void Clear()
		{
			_vspct = null;
			tb_tensp.Text = "";
			tb_loaisp.Text = "";
			tb_size.Text = "";
			tb_mausac.Text = "";
			tb_nsx.Text = "";
			tb_ncc.Text = "";
			tb_khuyenmai.Text = "";
			tb_soluongton.Text = "";
			tb_gianhap.Text = "";
			tb_giaban.Text = "";
			tb_mota.Text = "";
			rd_conhang.Checked = false;
			rd_hethang.Checked = false;
			ptb_imagesSp.Image = null;
		}
		public void loadCam()
		{
			foreach (FilterInfo item in FilterInfoCollection)
			{
				cbb_cam.Items.Add(item.Name);
			}
			cbb_cam.SelectedIndex = 0;
		}
		public void LoadDataSp()
		{
			dtg_sanpham.Rows.Clear();
			dtg_sanpham.ColumnCount = 14;
			dtg_sanpham.Columns[0].Name = "ID";
			dtg_sanpham.Columns[0].Visible = false;
			dtg_sanpham.Columns[1].Name = "Tên sản phẩm";
			dtg_sanpham.Columns[2].Name = "Loại sản phẩm";
			dtg_sanpham.Columns[3].Name = "Size";
			dtg_sanpham.Columns[4].Name = "Màu sắc";
			dtg_sanpham.Columns[5].Name = "Nhà sản xuất";
			dtg_sanpham.Columns[6].Name = "Nhà cung cấp";
			dtg_sanpham.Columns[7].Name = "Khuyến mại";
			dtg_sanpham.Columns[8].Name = "Số lượng tồn";
			dtg_sanpham.Columns[9].Name = "Giá nhập";
			dtg_sanpham.Columns[10].Name = "Giá bán";
			dtg_sanpham.Columns[11].Name = "Mô tả";
			dtg_sanpham.Columns[12].Name = "Trạng thái";
			dtg_sanpham.Columns[13].Name = "Images";
			_lstViewSpct = _ISanPhamChiTietServices.GetViewChiTietSps();
			if (tb_timkiem.Text != "")
			{
				_lstViewSpct = _lstViewSpct.Where(c => c.TenSP.Contains(tb_timkiem.Text)).ToList();
			}
			foreach (var a in _lstViewSpct)
			{
				dtg_sanpham.Rows.Add(a.ID, a.TenSP, a.TenLOAI, a.TenSZ, a.TenMS, a.TenNSX, a.TenNCC, a.TenKM, a.SoLuongTon, a.GiaBan, a.GiaNhap, a.MoTa, a.TrangThai, a.HinhAnh);
			}
		}
		public void LoadHTTT()
		{
			foreach (var a in _IHTTTServices.GetAll())
			{
				cbb_httt.Items.Add(a.Ten);
			}
		}
		public void LoadGioHang()
		{
			dtg_giohang.Rows.Clear();
			dtg_giohang.ColumnCount = 3;
			dtg_giohang.Columns[0].Name = "ID";
			dtg_giohang.Columns[0].Visible = false;
			dtg_giohang.Columns[1].Name = "Mã";
			dtg_giohang.Columns[1].Visible = false;
			dtg_giohang.Columns[2].Name = "Tên sản phẩm";
			dtg_giohang.Columns.Add("SoLuong", "Số lượng");
			dtg_giohang.Columns.Add("DonGia", "Đơn giá");
			foreach (var a in _lstViewHDct)
			{
				dtg_giohang.Rows.Add(a.ID, a.Ma, a.TenSP, a.SoLuong, a.DonGia);
			}
		}
		private void dtg_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow r = dtg_sanpham.Rows[e.RowIndex];
				_ID = Guid.Parse(dtg_sanpham.Rows[e.RowIndex].Cells[0].Value.ToString());
				var _wspct = _ISanPhamChiTietServices.GetViewChiTietSps().FirstOrDefault(c => c.ID == _ID);
				tb_tensp.Text = _wspct.TenSP;
				tb_loaisp.Text = _wspct.TenLOAI;
				tb_size.Text = _wspct.TenSZ;
				tb_mausac.Text = _wspct.TenMS;
				tb_nsx.Text = _wspct.TenNSX;
				tb_ncc.Text = _wspct.TenNCC;
				tb_khuyenmai.Text = _wspct.TenKM;
				tb_soluongton.Text = Convert.ToString(_wspct.SoLuongTon);
				tb_gianhap.Text = Convert.ToString(_wspct.GiaNhap);
				tb_giaban.Text = Convert.ToString(_wspct.GiaBan);
				tb_mota.Text = _wspct.MoTa;
				if (_wspct.TrangThai == 1)
				{
					rd_conhang.Checked = true;
				}
				else
				{
					rd_hethang.Checked = true;
				}
				_Images = _wspct.HinhAnh;
				if (_Images != null && File.Exists(_Images))
				{
					ptb_imagesSp.Image = Image.FromFile(_Images);
					ptb_imagesSp.SizeMode = PictureBoxSizeMode.StretchImage;
				}
			}
		}
		private void tb_timkiem_TextChanged(object sender, EventArgs e)
		{
			LoadDataSp();
		}
		private void ptb_Qr_Paint(object sender, PaintEventArgs e)
		{
			//VideoCaptureDevice = new VideoCaptureDevice(FilterInfoCollection[ptb_Qr.SelectedIndex].MonikerString);
			//VideoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
			//VideoCaptureDevice.Start();
			//timer1.Start();
		}
		private void btn_themgiohang_Click(object sender, EventArgs e)
		{
			var p = _ISanPhamChiTietServices.GetViewChiTietSps().FirstOrDefault(x => x.ID == _ID);
			var data = _lstViewHDct.FirstOrDefault(x => x.ID == p.ID);
			if (data == null)
			{
				ViewHoaDonCT vhdct = new ViewHoaDonCT()
				{
					ID = p.ID,
					TenSP = p.TenSP,
					DonGia = p.GiaBan,
					SoLuong = 1,
					Ma = p.Ma,
				};
				tongtien = 0; // Đặt tổng giá trị về 0
				tb_giatrigiohang.Text = "0"; // Cập nhật giá trị hiển thị trên textbox
				_lstViewHDct.Add(vhdct);
			}
			else
			{
				if (data.SoLuong == p.SoLuongTon)
				{
					MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
				}
				else
				{
					data.SoLuong++;
				}
			}
			LoadGioHang();
			LoadCheckBox();
		}
		private void dtg_hd_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow r = dtg_hd.Rows[e.RowIndex];
				var selectedHd = _lstViewHD.FirstOrDefault(c => c.ID == _ID4);
				_ID4 = Guid.Parse(dtg_hd.Rows[e.RowIndex].Cells[0].Value.ToString());
				tb_ma.Text = r.Cells[1].Value.ToString();
				tb_tongiatri.Text = r.Cells[7].Value.ToString();
				loadHDCT(_ID4);
			}
		}
		private void tb_tientralai_TextChanged(object sender, EventArgs e)
		{
		}
		private void tb_tienkhachtra_TextChanged(object sender, EventArgs e)
		{
			double tienKhachDua;
			if (!double.TryParse(tb_tienkhachtra.Text, out tienKhachDua))
			{
				MessageBox.Show("Giá trị không hợp lệ");
				tb_tienkhachtra.Text = "0";
				return;
			}
			double tienCanTra = Convert.ToDouble(tb_tongiatri.Text);
			double tienThoiLai = tienKhachDua - tienCanTra;
			tb_tientralai.Text = tienThoiLai.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
		}
		private void tb_tongiatri_TextChanged(object sender, EventArgs e)
		{
			//decimal gia;
			//if (decimal.TryParse(tb_tongiatri.Text, out gia))
			//{
			//	tb_tongiatri.Text = gia.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
			//}
		}
		private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
		{
			pictureCam.Image = (Bitmap)eventArgs.Frame.Clone();
		}
		private void btn_qr_Click(object sender, EventArgs e)
		{
			VideoCaptureDevice = new VideoCaptureDevice(FilterInfoCollection[cbb_cam.SelectedIndex].MonikerString);
			VideoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame; ;
			VideoCaptureDevice.Start();
			//timer1.Start();
		}
		private void LoadCheckBox()
		{
			// Tạo ra một đối tượng checkbox
			DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
			checkBoxColumn.Name = "chk_SelectProduct";
			checkBoxColumn.HeaderText = "Chọn";
			checkBoxColumn.Width = 50;
			// Thêm checkbox vào DataGridView
			dtg_giohang.Columns.Add(checkBoxColumn);
		}
		private void ClearGioHang()
		{
			if (_lstViewHDct.Any())
			{
				/*_lstViewHDct.Clear();*/ // Xóa hết các sản phẩm trong danh sách
				tongtien = 0; // Đặt tổng giá trị về 0
				tb_giatrigiohang.Text = "0"; // Cập nhật giá trị hiển thị trên textbox
				tb_sodienthoai.Text = "";
				tb_hotenkhachang.Text = "";
				tb_pont.Text = "";
				tb_mahdchuathanhtoan.Text = "";
				LoadGioHang();
			}
			else
			{
				MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
			}
		}
		public void ClearThanhToan()
		{
			if (_lstViewHD.Any())
			{
				_lstViewHD.Clear();
				tb_ma.Text = "";
				tb_tongiatri.Text = "";
				tb_tienkhachtra.Text = "";
				tb_tientralai.Text = "";
				cbb_httt.Text = "";
				cbb_pgg.Text = "";
				tb_diem.Text = "";
				LoadHoaDonChuaThanhToan();
			}
			else
			{
				MessageBox.Show("Chua chon hoa don nao de thanh toan");
			}
		}
		private void dtg_giohang_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dtg_giohang.Columns[e.ColumnIndex].Name == "chk_SelectProduct")
			{
				double price = Convert.ToDouble(dtg_giohang.Rows[e.RowIndex].Cells["DonGia"].Value);
				int quantity = Convert.ToInt32(dtg_giohang.Rows[e.RowIndex].Cells["SoLuong"].Value);
				double total = price * quantity * -1;
				DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)dtg_giohang.Rows[e.RowIndex].Cells["chk_SelectProduct"];
				bool isChecked = Convert.ToBoolean(checkBox.Value);
				if (isChecked)
				{
					tongtien += total;
				}
				else
				{
					tongtien -= total;
				}
				checkBox.Value = !isChecked;
				tb_giatrigiohang.Text = tongtien.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
			}
		}
		private void tb_sodienthoai_TextChanged(object sender, EventArgs e)
		{
			if (int.TryParse(tb_sodienthoai.Text, out int x))
			{
				var a = _IKhachHangServices.GetAllViewKhachHang().FirstOrDefault(c => c.SDT == tb_sodienthoai.Text);
				if (a != null)
				{
					tb_hotenkhachang.Text = a.HovaTen;
					tb_pont.Text = Convert.ToString(a.Poin);
					isFound = true; // Đã tìm thấy khách hàng
				}
				else
				{
					tb_hotenkhachang.Text = "";
					isFound = false; // Khách hàng không tồn tại
				}
			}
			if (!isFound) // Nếu chưa tìm thấy khách hàng
			{
				tb_hotenkhachang.Enabled = true;
			}
			else // Nếu đã tìm thấy khách hàng
			{
				tb_hotenkhachang.Enabled = false;
			}
		}
		private void btn_clickall_Click(object sender, EventArgs e)
		{
			//foreach (DataGridViewRow row in dtg_giohang.Rows)
			//{
			//	DataGridViewCheckBoxCell checkBoxCell = row.Cells["chk_SelectProduct"] as DataGridViewCheckBoxCell;
			//	if (checkBoxCell != null)
			//	{
			//		checkBoxCell.Value = true;
			//	}
			//}
		}
		private void btn_cleargiohang_Click(object sender, EventArgs e)
		{
			ClearGioHang();
		}
		private void btn_xoatheoclick_Click(object sender, EventArgs e)
		{
			if (_lstViewHDct.Any())
			{
				var item = _lstViewHDct.FirstOrDefault(x => x.IDSPCT == _ID2);
				tongtien = 0; // Đặt tổng giá trị về 0
				tb_giatrigiohang.Text = "0"; // Cập nhật giá trị hiển thị trên textbox
				_lstViewHDct.Remove(item);
				LoadGioHang();
			}
			else
			{
				MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
			}
		}
		private void btn_clear_Click(object sender, EventArgs e)
		{
			Clear();
		}
		private void btn_clearclickhd_Click(object sender, EventArgs e)
		{

		}
		private void LoadHoaDonChuaThanhToan()
		{
			dtg_hd.Rows.Clear();
			dtg_hd.ColumnCount = 9;
			dtg_hd.Columns[0].Name = "ID";
			dtg_hd.Columns[0].Visible = false;
			dtg_hd.Columns[1].Name = "Ma";
			dtg_hd.Columns[2].Name = "NV";
			dtg_hd.Columns[3].Name = "KH";
			dtg_hd.Columns[4].Name = "Ngay Tao";
			dtg_hd.Columns[5].Name = "Ngay Thanh Toan";
			dtg_hd.Columns[6].Name = "So Dien Thoai";
			dtg_hd.Columns[7].Name = "Thanh Tien";
			dtg_hd.Columns[8].Name = "Trang Thai";
			foreach (var a in _lstViewHD)
			{
				dtg_hd.Rows.Add(a.ID, a.Ma, a.TenNV, a.TenKH, a.NgayTao, a.NgayThanhToan, a.SDT, a.ThanhTien, a.TrangThai);
			}
		}
		public void TaoHoaDon()
		{
			var check = _IHoaDonServices.GetAll().FirstOrDefault(c => c.Ma == tb_mahdchuathanhtoan.Text);
			if (tb_mahdchuathanhtoan.Text == "")
			{
				MessageBox.Show("Khong duoc de trong ma hoa don chua thanh toan");
			}
			else if (check != null)
			{
				MessageBox.Show("Ma hoa don da ton tai");
			}
			else
			{
				var username = Properties.Settings.Default.User;
				var nhanviens = _INhanVienServices.GetAllViewNhanVien();
				_ID3 = _INhanVienServices.GetAllViewNhanVien().FirstOrDefault(x => x.Username == username).ID;
				var kh = _IKhachHangServices.GetAllViewKhachHang().FirstOrDefault(c => c.SDT == tb_sodienthoai.Text);
				ViewHoaDon wHd = new ViewHoaDon()
				{
					ID = Guid.NewGuid(),
					Ma = tb_mahdchuathanhtoan.Text,
					IDNV = _ID3,
					IDKH = kh.ID,
					TrangThai = 0,
					NgayTao = DateTime.Now,
					NgayThanhToan = DateTime.Now,
					SDT = tb_sodienthoai.Text,
					TenKH = tb_hotenkhachang.Text,
					ThanhTien = Convert.ToDecimal(tongtien)
				};

				_lstViewHD.Add(wHd);

				List<ViewHoaDonCT> tempList = new List<ViewHoaDonCT>();
				foreach (var item in _lstViewHDct)
				{
					ViewHoaDonCT whdct = new ViewHoaDonCT()
					{
						ID = new Guid(),
						IDHD = wHd.ID,
						IDSPCT = item.IDSPCT,
						DonGia = item.DonGia,
						SoLuong = item.SoLuong,
					};
					tempList.Add(whdct);
				}
				foreach (var item in tempList)
				{
					_lstViewHDct.Add(item);
				}
				var t = _lstViewHDct;
				MessageBox.Show($"Đã tạo hóa đơn có mã là [{wHd.Ma}]");
				LoadDataSp();
				LoadGioHang();
				LoadHoaDonChuaThanhToan();
				ClearGioHang();
			}
		}
		private void btn_addhoadon_Click(object sender, EventArgs e)
		{
			var checkkh = _IKhachHangServices.GetAllViewKhachHang().FirstOrDefault(c => c.SDT == tb_sodienthoai.Text);
			if (checkkh != null)
			{
				TaoHoaDon();
			}
			else
			{
				MessageBox.Show("Khách hàng này chưa tồn tại trong cửa hàng");
				DialogResult dg = MessageBox.Show("Nếu muốn thêm thông tin của khách hàng thì chọn (Yes), Nếu chọn (No) thì khách hàng này sẽ mặc định là(Khách vãng lai)!!", "Thong bao", MessageBoxButtons.YesNo);
				if (dg == DialogResult.Yes)
				{
					ViewKhachHang vkh = new ViewKhachHang()
					{
						ID = new Guid(),
						HovaTen = tb_hotenkhachang.Text,
						SDT = tb_sodienthoai.Text,
						TrangThai = 1,
						Poin = 0
					};
					_IKhachHangServices.Add(vkh);
					MessageBox.Show("Thông tin khách hàng đã được thêm vào mục quản lý!! Hãy tiếp tục hành động của mình");
					TaoHoaDon();
				}
				else
				{
					//ViewKhachHang vkh = new ViewKhachHang()
					//{
					//	ID = new Guid(),
					//	HovaTen = "Khách vãng lai",
					//	SDT = "0",
					//	TrangThai = 0,
					//	Poin = 0
					//};
					//_IKhachHangServices.Add(vkh);
					//MessageBox.Show("Thông tin khách hàng đã được quy về khách vãng lai mục quản lý!! Hãy tiếp tục hành động của mình");
					//_ID3 = _INhanVienServices.GetAllViewNhanVien().Find(x => x.Username == Properties.Settings.Default.User).ID;
					//var kh = _IKhachHangServices.GetAllViewKhachHang().FirstOrDefault(c => c.SDT == "0000000000");
					//ViewHoaDon lstHd = new ViewHoaDon()
					//{
					//	ID = Guid.NewGuid(),
					//	Ma = tb_mahdchuathanhtoan.Text,
					//	IDNV = _ID3,
					//	IDKH = kh.ID,
					//	TrangThai = 0,
					//	NgayTao = DateTime.Now,
					//	NgayThanhToan = DateTime.Now,
					//	SDT = tb_sodienthoai.Text,
					//	TenKH = tb_hotenkhachang.Text,
					//	ThanhTien = Convert.ToDecimal(tongtien)
					//};
					//_lstViewHD.Add(lstHd);
					//List<ViewHoaDonCT> temp = new List<ViewHoaDonCT>();
					//foreach (var hdct in _lstViewHDct)
					//{
					//	ViewHoaDonCT viewHoaDonCT = new ViewHoaDonCT()
					//	{
					//		ID = lstHd.ID,
					//		IDSPCT = hdct.IDSPCT,
					//		DonGia = hdct.DonGia,
					//		SoLuong = hdct.SoLuong,
					//	};
					//	temp.Add(viewHoaDonCT);
					//}
					//_lstViewHDct.AddRange(temp);
					//MessageBox.Show($"Đã tạo hóa đơn có mã là [{lstHd.Ma}]");
					//LoadDataSp();
					//LoadGioHang();
					//LoadHoaDonChuaThanhToan();
					//ClearGioHang();
					////TaoHoaDon();
				}
			}
		}

		private void btn_thanhtoan_Click(object sender, EventArgs e)
		{
			if (_lstViewHD.Count == 0)
			{
				MessageBox.Show("Khong co hoa don de thanh toan");
			}
			else
			{
				var selectedHd = _lstViewHD.FirstOrDefault(c => c.Ma == tb_ma.Text);
				if (selectedHd == null)
				{
					MessageBox.Show("Khong tim thay hoa don");
				}
				else
				{
					selectedHd.TrangThai = 1;
					selectedHd.NgayThanhToan = DateTime.Now;
					selectedHd.ThanhTien = Convert.ToDecimal(tb_tienkhachtra.Text);
					string tenHTTT = cbb_httt.SelectedItem.ToString();
					HinhThucThanhToan hinhThucThanhToan = _IHTTTServices.GetAll().FirstOrDefault(httt => httt.Ten == tenHTTT);
					if (hinhThucThanhToan != null)
					{
						selectedHd.IDHTTT = hinhThucThanhToan.ID;
					}
					_IHoaDonServices.Add(selectedHd);
					foreach (var hdct in _lstViewHDct)
					{
						ViewHoaDonCT viewHoaDonCT = new ViewHoaDonCT()
						{
							IDHD = selectedHd.ID,
							IDSPCT = hdct.IDSPCT,
							DonGia = hdct.DonGia,
							SoLuong = hdct.SoLuong,

						};
						_IHoaDonChiTietServices.Add(viewHoaDonCT);
						var sp = _ISanPhamChiTietServices.GetViewChiTietSps().FirstOrDefault(c => c.ID == hdct.IDSPCT);
						sp.SoLuongTon = sp.SoLuongTon - hdct.SoLuong;
						_ISanPhamChiTietServices.updateSanPhamChiTiet(sp);
						MessageBox.Show("Da update lai so luong");
					}
					MessageBox.Show($"Thanh toan hoa don {selectedHd.Ma} thanh cong");
				}

			}
		}
		public void loadHDCT(Guid id)
		{
			_ID5 = id;
			dtg_hdct.Rows.Clear();
			dtg_hdct.ColumnCount = 5;
			dtg_hdct.Columns[0].Name = "ID";
			dtg_hdct.Columns[0].Visible = false;
			dtg_hdct.Columns[1].Name = "IDSPCT";
			dtg_hdct.Columns[2].Name = "TenSp";
			dtg_hdct.Columns[3].Name = "So Luong";
			dtg_hdct.Columns[4].Name = "Don Gia";
			var lst = _lstViewHDct.Where(item => item.IDHD == id).ToList();

			foreach (var item in lst)
			{
				dtg_hdct.Rows.Add(item.ID, item.IDSPCT, item.TenSP, item.SoLuong, item.DonGia);
			}
		}
	}
}

