using _1_DAL.Dbcontext;
using _1_DAL.DomainMolder;
using _1_DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repository
{
    public class KhachHangRepository : IKhachHangRepository
    {
        private QuanLyBanHangGiayContext _dbContext;
        private List<KhachHang> _lstKhachHang;
        public KhachHangRepository()
        {
            _dbContext = new QuanLyBanHangGiayContext();
            _lstKhachHang = new List<KhachHang>();
            GetKhachHangfromDB();
        }

        public bool Add(KhachHang obj)
        {
            if (obj == null)
                return false;
            obj.ID = Guid.NewGuid();
            _dbContext.KhachHangs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang obj)
        {
            if (obj == null)
                return false;
            var temp = _dbContext.KhachHangs.FirstOrDefault(x => x.ID == obj.ID);
            _dbContext.KhachHangs.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public List<KhachHang> GetKhachHangfromDB()
        {
            _lstKhachHang = _dbContext.KhachHangs.ToList();
            return _lstKhachHang;
        }

        public bool Update(KhachHang obj)
        {
            if (obj == null) return false;
            var temp = _dbContext.KhachHangs.FirstOrDefault(x => x.ID == obj.ID);
            temp.Ho = obj.Ho;
            temp.TenDem= obj.TenDem;
            temp.Ten = obj.Ten;
            temp.Poin = obj.Poin;
            temp.GioiTinh = obj.GioiTinh;
            temp.NgaySinh = obj.NgaySinh;
            temp.SDT = obj.SDT;
            temp.DiaChi= obj.DiaChi;
            temp.ThanhPho = obj.ThanhPho;
            temp.QuocGia = obj.QuocGia;
           
            _dbContext.KhachHangs.Update(temp);
           _dbContext.SaveChanges();

            return true;
        }
    }
}
