using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using iShop.DAL;

namespace iShop.BLL
{
    class BoPhanBLL
    {
        BoPhanDAL bpDAL = new BoPhanDAL(); 

        //select
        public DataTable SelectAllBoPhan_BLL()
        {
            return bpDAL.SelectALL_BoPhan();
        }

        //Insert
        public void InsertBoPhan_BLL(BoPhan bp)
        {
            bpDAL.InsertBoPhan(bp);
        }
        
        //Update
        public void UpdateBoPhan_BLL(string id, string ten, string ghichu)
        {
            bpDAL.UpdateBoPhan(id, ten, ghichu);
        }

        //Delete
        public void DeleteBoPhan_BLL(string id)
        {
            bpDAL.DeleteBoPhan(id);
        }
    }
}
