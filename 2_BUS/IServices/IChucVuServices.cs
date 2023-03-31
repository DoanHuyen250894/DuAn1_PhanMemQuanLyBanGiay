using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.DomainMolder;

namespace _2_BUS.IServices
{
    public interface IChucVuServices
    {
        bool Add(ChucVu obj);
        bool Update(ChucVu obj);
        bool Delete(ChucVu obj);
        List<ChucVu> GetAll();
        List<ChucVu> GetAll(string input);
    }
}
