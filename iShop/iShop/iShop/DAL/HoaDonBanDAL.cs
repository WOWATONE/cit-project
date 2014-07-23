using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace iShop.DAL
{
    class HoaDonBanDAL
    {
        //Insert HoaDonBan
        public void InsertHoaDonBan(HoaDonBan hdb)
        {
            using (iShopEntities en = new iShopEntities())
            {
                en.HoaDonBans.AddObject(hdb);
                en.SaveChanges();
            }
        }

        //Insert ChiTietHoaDon
        public void InsertChiTietHoaDon(ChiTietHoaDon ct)
        {
            iShopEntities u = new iShopEntities();
            u.ChiTietHoaDons.AddObject(ct);
            u.SaveChanges();
        }

        //Update SoLuongTon
        public void UpdateSoLuongTon(ChiTietHoaDon ct)
        {
            using(iShopEntities en = new iShopEntities())
            {
               var sl = (from h in en.HangHoas where h.ID == ct.HangHoaID select h.SoLuong).First();
               sl = sl - ct.SoLuong;
               var hh = (from hang in en.HangHoas where hang.ID == ct.HangHoaID select hang).First();
               hh.SoLuong = sl;
               en.SaveChanges();
            }
        }
    }
}
