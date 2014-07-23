using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using iShop.DAL;


namespace iShop.BLL
{
    class HoaDonBanBLL
    {
        //Insert HoaDonBan
        public void InsertHoaDonBan_BLL(HoaDonBan hdb)
        {
            HoaDonBanDAL hd = new HoaDonBanDAL();
            hd.InsertHoaDonBan(hdb);
        }

        public void InsertChiTietHoaDon_BLL(ChiTietHoaDon ct)
        {
            HoaDonBanDAL hd = new HoaDonBanDAL();
            hd.InsertChiTietHoaDon(ct);
        }

        //Update SoLuongTon
        public void UpdateSoLuongTon_BLL(ChiTietHoaDon ct)
        {
            HoaDonBanDAL hd = new HoaDonBanDAL();
            hd.UpdateSoLuongTon(ct);
        }
    }
}
