using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using iShop.DAL;

namespace iShop.BLL
{
    class DS_HoaDonBanBLL
    {
        //Select All
        public DataTable SelectAll_HoaDonBanBLL()
        {
            DS_HoaDonBanDAL ds = new DS_HoaDonBanDAL();
            return ds.SelectAllHoaDonBan();
        }

        //Delete
        public void Delete_DSHoaDon_BLL(string id)
        {
            DS_HoaDonBanDAL ds = new DS_HoaDonBanDAL();
            ds.Delete_DSHoaDon(id);
        }
    }
}
