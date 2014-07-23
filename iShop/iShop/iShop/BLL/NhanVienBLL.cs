using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using iShop.DAL;
using iShop.DTO;

namespace iShop.BLL
{
    class NhanVienBLL
    {
        //Select
        public DataTable SelectNhanVienBLL()
        {
            NhanVienDAL nvDAL = new NhanVienDAL();
            return nvDAL.SelectAllNhanVien();
        }

        //Insert
        public void InsertNhanVien_BLL(NhanVien n)
        {
            NhanVienDAL nDAL = new NhanVienDAL();
            nDAL.InsertNhanVien(n);
        }

        //Update
        public void UpdateNhanVien_BLL(NhanVienDto nDto)
        {
            NhanVienDAL nDAL = new NhanVienDAL();
            nDAL.UpdateNhanVien(nDto);
        }

        //Delete
        public void DeteleNhanVien_BLL(string id)
        {
            NhanVienDAL nDAL = new NhanVienDAL();
            nDAL.DeleteNhanVien(id);
        }
    }
}
