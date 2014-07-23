using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using iShop.DAL;
using iShop.DTO;

namespace iShop.BLL
{
    class KhachHangBLL
    {
        //Select All
        public DataTable SelectAllKhachHangBLL()
        {
            KhachHangDAL kh = new KhachHangDAL();
            return kh.SelectAllKhachHang();
        }

        //INSERT
        public void InsertKhachHangBLL(KhachHang kh)
        {
            KhachHangDAL k = new KhachHangDAL();
            k.InsertKhachHang(kh);
        }

        //UPDATE
        public void UpdateKhachHangBLL(KhachHangDto k)
        {
            KhachHangDAL kh = new KhachHangDAL();
            kh.UpdateKhachHang(k);
        }

        //DELETE
        public void DeleteKhachHangBLL(string id)
        {
            KhachHangDAL k = new KhachHangDAL();
            k.DeleteKhachHang(id);
        }
    }
}
