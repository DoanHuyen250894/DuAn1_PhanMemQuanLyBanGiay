﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.DomainMolder;
using _2_BUS.ViewMolder;

namespace _2_BUS.IServices
{
    public interface INhanVienServices
    {
        bool AddNhanVien(ViewNhanVien nhanVien);
        bool UpdateNhanVien(ViewNhanVien nhanVien);
        bool DeleteNhanVien(Guid ID);
        public List<NhanVien> GetAllNhanVien();
        //public List<NhanVien> GetAllNhanVien(string gmail);
        public List<ViewNhanVien> GetAllViewNhanVien();
    }
}
