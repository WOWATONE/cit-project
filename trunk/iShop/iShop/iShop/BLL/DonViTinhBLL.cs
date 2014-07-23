using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using iShop.DAL;

namespace iShop.BLL
{
    class DonViTinhBLL
    {
        //Select
        public DataTable SelectAll_DVT_BLL()
        {
            DonViTinhDAL dv = new DonViTinhDAL();
            return dv.SelectAll_DVT();
        }

        //Insert
        public void InsertDVT_BLL(DonViTinh dv)
        {
            DonViTinhDAL dvt = new DonViTinhDAL();
            dvt.Insert_DVT(dv);
        }
        
        //Update
        public void UpdateDVT_BLL(string id, string ten, string ghichu)
        {
            DonViTinhDAL dvt = new DonViTinhDAL();
            dvt.Update_DVT(id, ten, ghichu);
        }
        
        //Delete
        public void DeleteDVT_BLL(string id)
        {
            DonViTinhDAL dv = new DonViTinhDAL();
            dv.Delete_DVT(id);
        }
    }
}
