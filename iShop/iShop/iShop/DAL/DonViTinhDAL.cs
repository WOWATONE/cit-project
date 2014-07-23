using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace iShop.DAL
{
    class DonViTinhDAL
    {
        //Select All
        public DataTable SelectAll_DVT()
        {
            using (iShopEntities en = new iShopEntities())
            {
                List<DonViTinh> dvt = (from d in en.DonViTinhs select d).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("TenDonViTinh");
                dt.Columns.Add("GhiChu");
                foreach (DonViTinh dv in dvt)
                {
                    dt.Rows.Add(dv.ID, dv.TenDonViTinh, dv.GhiChu);
                }

                return dt;
            }
        }

        //INSERT
        #region Insert DVT
        public void Insert_DVT(DonViTinh dv)
        {
            using (iShopEntities en = new iShopEntities())
            {
                en.DonViTinhs.AddObject(dv);
                en.SaveChanges();
            }
        }
        #endregion


        //UPDATE
        #region Update DVT
        public void Update_DVT(string id, string ten, string ghichu)
        {
            using (iShopEntities en = new iShopEntities())
            {
                var q = (from d in en.DonViTinhs where d.ID==id select d).First();
                q.ID = id;
                q.TenDonViTinh = ten;
                q.GhiChu = ghichu;

                en.SaveChanges();
            }
        }
        #endregion


        //DELETE
        #region Delete DVT
        public void Delete_DVT(string id)
        {
            using (iShopEntities en = new iShopEntities())
            {
                var q = (from d in en.DonViTinhs where d.ID == id select d).First();
                en.DonViTinhs.DeleteObject(q);
                en.SaveChanges();
            }
        }
        #endregion


    }
}
