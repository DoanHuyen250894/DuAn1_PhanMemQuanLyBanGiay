using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.DomainMolder;
using _2_BUS.ViewMolder;

namespace _2_BUS.IServices
{
    public interface IKhachHangServices
    {
        public bool Add(ViewKhachHang obj);
        public bool Update(ViewKhachHang obj);
        public bool Delete(Guid ID);
        public List<KhachHang> GetAll();
        public List<ViewKhachHang> GetAllViewKhachHang();
    }
}
