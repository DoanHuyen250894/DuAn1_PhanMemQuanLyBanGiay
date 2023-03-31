﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.DomainMolder;

namespace _2_BUS.IServices
{
    public interface INSXServices
    {
        bool Add(NSX obj);
        bool Update(NSX obj);
        bool Delete(NSX obj);
        List<NSX> GetAll();
        List<NSX> GetAll(string input);
    }
}
