using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace iShop.DAL
{
    class DS_HoaDonBanDAL
    {
        //Select All
        public DataTable SelectAllHoaDonBan()
        {
            using(iShopEntities en = new iShopEntities())
            {
                List<HoaDonBan> hd = (from hdb in en.HoaDonBans select hdb).ToList();

                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("NgayLap");
                dt.Columns.Add("NhanVien");
                dt.Columns.Add("KhachHang");
                dt.Columns.Add("ChietKhau");
                dt.Columns.Add("TongTien");
                dt.Columns.Add("GhiChu");
                foreach (HoaDonBan h in hd)
                {
                    dt.Rows.Add(h.ID,h.NgayLap,h.NhanVien.TenNhanVien,
                        h.KhachHang.TenKhachHang,h.ChietKhau,h.TongTien,h.GhiChu);
                }
                return dt;
            }
        }

        //Delete
        public void Delete_DSHoaDon(string id)
        {
            using(iShopEntities en = new iShopEntities())
            {
                var q = (from l in en.HoaDonBans where l.ID == id select l).First();
                List<ChiTietHoaDon> ct = (from cht in en.ChiTietHoaDons select cht).ToList();
                foreach (ChiTietHoaDon c in ct)
                {
                    if (c.HoaDonBanID == q.ID)
                    {
                        DeleteChiTiet(q);
                    }
                }
                en.DeleteObject(q);
                en.SaveChanges();
            }
        }

        //Delete chi tiet hoa don
        public void DeleteChiTiet(HoaDonBan hd)
        {
            using (iShopEntities en = new iShopEntities())
            {
                var c = (from ct in en.ChiTietHoaDons where ct.HoaDonBanID == hd.ID select ct).First();
                en.DeleteObject(c);
                //en.SaveChanges();
            }
        }
    }
}
