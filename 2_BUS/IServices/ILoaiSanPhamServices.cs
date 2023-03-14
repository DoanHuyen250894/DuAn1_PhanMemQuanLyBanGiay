using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.DomainMolder;

namespace _2_BUS.IServices
{
    public interface ILoaiSanPhamServices
    {
        bool Add(LoaiSanPham obj);
        bool Update(LoaiSanPham obj);
        bool Delete(LoaiSanPham obj);
        List<LoaiSanPham> GetAll();
        List<LoaiSanPham> GetAll(string input);
    }
}
