using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.DomainMolder;
using _2_BUS.ViewMolder;

namespace _2_BUS.IServices
{
    public interface ISanPhamChiTietServices
    {
		bool addSanPhamChiTiet(ViewSanPhamChiTiet chiTietSP);
		bool updateSanPhamChiTiet(ViewSanPhamChiTiet chiTietSP);
		bool deleteSanPhamChiTiet(Guid idspct);
		List<SanPhamChiTiet> GetChiTietSPs();
		List<ViewSanPhamChiTiet> GetViewChiTietSps();
	}
}
