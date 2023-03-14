using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS.ViewMolder;

namespace _2_BUS.IServices
{
    public interface IKhachHangServices
    {
        public string Add(ViewKhachHang obj);
        public string Update(ViewKhachHang obj);
        public string Delete(ViewKhachHang obj);
        public List<ViewKhachHang> GetAll();
        public List<ViewKhachHang> GetAll(string input);
    }
}
