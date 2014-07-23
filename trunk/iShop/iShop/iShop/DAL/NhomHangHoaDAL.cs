
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace iShop.DAL
{
    class NhomHangHoaDAL
    {
        //Select All
        public DataTable SelectAll_DVT()
        {
            using(iShopEntities en = new iShopEntities())
            {
                List<NhomHangHoa> dv = (from n in en.NhomHangHoas select n).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("TenNhomHang");
                dt.Columns.Add("GhiChu");

                foreach (NhomHangHoa d in dv)
                {
                    dt.Rows.Add(d.ID,d.TenNhomHang,d.GhiChu);
                }

                return dt;
            }
        }

        //INSERT
        public void Insert_NhomHH(NhomHangHoa nh)
        {
            using (iShopEntities en = new iShopEntities())
            {
                en.NhomHangHoas.AddObject(nh);
                en.SaveChanges();
            }
        }

        //UPDATE
        public void Update_NhomHH(string id, string ten, string ghichu)
        {
            using (iShopEntities en = new iShopEntities())
            {
                var q = (from n in en.NhomHangHoas where n.ID == id select n).First();
                q.ID = id;
                q.TenNhomHang = ten;
                q.GhiChu = ghichu;

                en.SaveChanges();
            }
        }

        //DELETE
        public void Delete_NhomHH(string id)
        {
            using (iShopEntities en = new iShopEntities())
            {
                var q = (from n in en.NhomHangHoas where n.ID == id select n).First();
                en.DeleteObject(q);
                en.SaveChanges();
            }
        }
    }
}
