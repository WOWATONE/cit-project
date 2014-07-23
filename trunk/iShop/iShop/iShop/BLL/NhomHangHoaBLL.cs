using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using iShop.DAL;

namespace iShop.BLL
{
    class NhomHangHoaBLL
    {
        //Select 
        public DataTable SelectNhomHH_BLL()
        {
            NhomHangHoaDAL n = new NhomHangHoaDAL();
            return n.SelectAll_DVT();
        }

        //Insert
        public void InsertNhomHH_BLL(NhomHangHoa nh)
        {
            NhomHangHoaDAL n = new NhomHangHoaDAL();
            n.Insert_NhomHH(nh);
        }

        //Update
        public void UpdateNhomHH_BLL(string id, string ten, string ghichu)
        {
            NhomHangHoaDAL n = new NhomHangHoaDAL();
            n.Update_NhomHH(id,ten,ghichu);
        }

        //Delete
        public void DeleteNhomHH_BLL(string id)
        {
            NhomHangHoaDAL n = new NhomHangHoaDAL();
            n.Delete_NhomHH(id);
        }
    }
}
