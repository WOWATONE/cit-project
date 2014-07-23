using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace iShop.DAL
{
    class BoPhanDAL
    {
        //SELECT
        public DataTable SelectALL_BoPhan()
        {
            using (iShopEntities en = new iShopEntities())
            {
                List<BoPhan> bp = (from b in en.BoPhans select b).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("TenBoPhan");
                dt.Columns.Add("GhiChu");

                foreach (BoPhan b in bp)
                {
                    dt.Rows.Add(b.ID, b.TenBoPhan, b.GhiChu);
                }
                return dt;
            }
        }

        //INSERT
        public void InsertBoPhan(BoPhan bp)
        {
            using (iShopEntities en = new iShopEntities())
            {
                en.BoPhans.AddObject(bp);
                en.SaveChanges();
            }
        }

        //UPDATE
        public void UpdateBoPhan(string id, string ten, string ghichu)
        {
            using (iShopEntities en = new iShopEntities())
            {
                var q = (from b in en.BoPhans where b.ID == id select b).First();
                q.ID = id;
                q.TenBoPhan = ten;
                q.GhiChu = ghichu;
                en.SaveChanges();
            }
        }

        //DELETE
        public void DeleteBoPhan(string id)
        {
            using (iShopEntities en = new iShopEntities())
            {
                var q = (from b in en.BoPhans where b.ID == id select b).First();
                en.BoPhans.DeleteObject(q);
                en.SaveChanges();
            }
        }
    }
}
