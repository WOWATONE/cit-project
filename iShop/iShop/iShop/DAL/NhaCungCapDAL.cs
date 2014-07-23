using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using iShop.DTO;

namespace iShop.DAL
{
    class NhaCungCapDAL
    {
        //Select All
        public DataTable SelectAll_NCC()
        {
            iShopEntities sh = new iShopEntities();
            List<NhaCungCap> ncc = (from n in sh.NhaCungCaps select n).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("TenNhaCungCap");
            dt.Columns.Add("SoDienThoai");
            dt.Columns.Add("Email");
            dt.Columns.Add("DiaChi");
            dt.Columns.Add("NguoiDaiDien");
            dt.Columns.Add("SoTaiKhoan");
            dt.Columns.Add("NganHang");
            dt.Columns.Add("GhiChu");

            foreach (NhaCungCap n in ncc)
            {
                dt.Rows.Add(n.ID, n.TenNhaCungCap, n.SoDienThoai, n.Email,
                            n.DiaChi, n.NguoiDaiDien, n.SoTaiKhoan, n.NganHang, n.GhiChu);
            }
            return dt;
        }

        //INSERT
        #region INSERT NhaCungCap
        public void Insert_NhaCungCap(NhaCungCap ncc)
        {
            using (iShopEntities shop = new iShopEntities())
            {
                shop.NhaCungCaps.AddObject(ncc);
                shop.SaveChanges();
            }
        }
        #endregion

        //UPDATE
        #region UPDATE NhaCungCap
        public void Update_NhaCungCap(NhaCungCapDto ncc)
        {
            using (iShopEntities en = new iShopEntities())
            {
                var q = (from n in en.NhaCungCaps where n.ID == ncc.id select n).First();

                q.ID = ncc.id;
                q.TenNhaCungCap = ncc.tenNhaCungCap;
                q.SoDienThoai = ncc.soDienThoai;
                q.Email = ncc.email;
                q.DiaChi = ncc.diaChi;
                q.NguoiDaiDien = ncc.nguoiDaiDien;
                q.SoTaiKhoan = ncc.soTaiKhoan;
                q.NganHang = ncc.nganHang;
                q.GhiChu = ncc.ghiChu;
                en.SaveChanges();
            }
        }
        #endregion

        //DELETE
        #region DELETE NhaCungCap
        public void Delete_NhaCungCap(string id)
        {
            using (iShopEntities en = new iShopEntities())
            {
                var q = (from n in en.NhaCungCaps where n.ID == id select n).First();
                en.DeleteObject(q);
                en.SaveChanges();
            }
        }
        #endregion
    }
}
