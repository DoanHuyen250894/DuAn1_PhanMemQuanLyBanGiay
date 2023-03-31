using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.DomainMolder;

namespace _2_BUS.IServices
{
    public interface ISizeServices
    {
        bool Add(KichThuoc obj);
        bool Update(KichThuoc obj);
        bool Delete(KichThuoc obj);
        List<KichThuoc> GetAll();
        List<KichThuoc> GetAll(string input);
    }
}
