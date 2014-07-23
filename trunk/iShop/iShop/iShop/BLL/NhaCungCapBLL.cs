using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using iShop.DAL;
using iShop.DTO;

namespace iShop.BLL
{
    class NhaCungCapBLL
    {
        NhaCungCapDAL nccDAL = new NhaCungCapDAL();

        //Select all
        public DataTable SelectAll_NCC_Bll()
        {
            return nccDAL.SelectAll_NCC();
        }

        //Insert
        public void InsertNCC_BLL(NhaCungCap n)
        {
            nccDAL.Insert_NhaCungCap(n);   
        }

        //Update
        public void UpdateNCC_BLL(NhaCungCapDto nDto)
        {
            nccDAL.Update_NhaCungCap(nDto);
        }

        //Delete
        public void DeleteNCC_BLL(string id)
        {
            nccDAL.Delete_NhaCungCap(id);
        }
    }
}
