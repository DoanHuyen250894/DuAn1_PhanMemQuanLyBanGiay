using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.DomainMolder;
using _1_DAL.IRepository;
using _1_DAL.Repository;
using _2_BUS.IServices;
using _2_BUS.ViewMolder;

namespace _2_BUS.Services
{
    public class KhachHangServices : IKhachHangServices
    {
        private IKhachHangRepository _khachHangRepository;
        public KhachHangServices()
        {
            _khachHangRepository= new KhachHangRepository();
        }
        public string Add(ViewKhachHang obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var KH = new KhachHang() { 
            ID = obj.ID,
                Poin = obj.Poin,
                Ten = obj.Ten,
                Ho = obj.Ho,
                TenDem = obj.TenDem,
                NgaySinh = obj.NgaySinh,
                SDT = obj.SDT,
               
                GioiTinh = obj.GioiTinh,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                QuocGia = obj.QuocGia,
                
            };
            if (_khachHangRepository.Add(KH)) return "Thêm thành công";
            return "Không thành công";

        }

        public string Delete(ViewKhachHang obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var KH = new KhachHang()
            {
                ID = obj.ID,
                Poin = obj.Poin,
                Ten = obj.Ten,
                Ho = obj.Ho,
                TenDem = obj.TenDem,
                NgaySinh = obj.NgaySinh,
                SDT = obj.SDT,
                GioiTinh = obj.GioiTinh,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                QuocGia = obj.QuocGia,
                
            };
            if (_khachHangRepository.Delete(KH)) return "Xóa thành công";
            return "Không thành công";
        }

        public List<ViewKhachHang> GetAll()
        {
            List<ViewKhachHang> lstKH = new List<ViewKhachHang>();
            lstKH = (from n in _khachHangRepository.GetKhachHangfromDB()
                     select new ViewKhachHang
                     {
                         ID = n.ID,
                         Ten = n.Ten,
                         Ho = n.Ho,
                         TenDem = n.TenDem,
                         NgaySinh = n.NgaySinh,
                         SDT = n.SDT,
                         Poin = n.Poin,
                         GioiTinh = n.GioiTinh,
                         DiaChi = n.DiaChi,
                         ThanhPho = n.ThanhPho,
                         QuocGia = n.QuocGia,
                        
                     }).ToList();
            return lstKH;
        }

        public List<ViewKhachHang> GetAll(string input)
        {

            List<ViewKhachHang> lstKH = new List<ViewKhachHang>();
            lstKH = (from n in _khachHangRepository.GetKhachHangfromDB()
                     where n.Ten.Contains(input)  || n.SDT.StartsWith(input)
                     select new ViewKhachHang
                     {
                         ID = n.ID,

                         Ten = n.Ten,
                         Ho = n.Ho,
                         TenDem = n.TenDem,
                         NgaySinh = n.NgaySinh,
                         SDT = n.SDT,
                         Poin = n.Poin,
                         GioiTinh = n.GioiTinh,
                         DiaChi = n.DiaChi,
                         ThanhPho = n.ThanhPho,
                         QuocGia = n.QuocGia,
                       
                     }).ToList();
            return lstKH;
        }

        public string Update(ViewKhachHang obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var KH = new KhachHang()
            {
                ID = obj.ID,
                Poin = obj.Poin,
                Ten = obj.Ten,
                Ho = obj.Ho,
                TenDem = obj.TenDem,
                NgaySinh = obj.NgaySinh,
                SDT = obj.SDT,
                GioiTinh = obj.GioiTinh,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                QuocGia = obj.QuocGia,
                
            };
            if (_khachHangRepository.Update(KH)) return "Sửa thành công";
            return "Không thành công";
        }
    }
}
