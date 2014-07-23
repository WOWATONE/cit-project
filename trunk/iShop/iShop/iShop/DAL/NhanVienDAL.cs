using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using iShop.DTO;

namespace iShop.DAL
{
    class NhanVienDAL
    {
        //Select All
        public DataTable SelectAllNhanVien()
        {
            using (iShopEntities en = new iShopEntities())
            {
                List<NhanVien> nv = (from n in en.NhanViens select n).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("TenNhanVien");
                dt.Columns.Add("NgaySinh");
                dt.Columns.Add("GioiTinh");
                dt.Columns.Add("BoPhan");
                dt.Columns.Add("SoDienThoai");
                dt.Columns.Add("Email");
                dt.Columns.Add("DiaChi");

                foreach (NhanVien n in nv)
                {
                    dt.Rows.Add(n.ID, n.TenNhanVien, n.NgaySinh, n.GioiTinh, n.BoPhan.TenBoPhan, n.SoDienThoai, n.Email, n.DiaChi);
                }
                return dt;
            }
        }

        //Insert
        public void InsertNhanVien(NhanVien nv)
        {
            using (iShopEntities en = new iShopEntities())
            {
                en.NhanViens.AddObject(nv);
                en.SaveChanges();
            }
        }


        //Update
        public void UpdateNhanVien(NhanVienDto nv)
        {
            using (iShopEntities en = new iShopEntities())
            {
                var q = (from n in en.NhanViens where n.ID == nv.id select n).First();
                q.ID = nv.id;
                q.TenNhanVien = nv.tenNhanVien;
                q.GioiTinh = nv.gioiTinh;
                q.NgaySinh = nv.ngaySinh;
                q.SoDienThoai = nv.soDienThoai;
                q.Email = nv.email;
                q.DiaChi = nv.diaChi;
                q.BoPhanID = nv.boPhan;
                en.SaveChanges();
            }
        }

        //Delete
        public void DeleteNhanVien(string id)
        {
            using (iShopEntities en = new iShopEntities())
            {
                var q = (from n in en.NhanViens where n.ID == id select n).First();
                en.NhanViens.DeleteObject(q);
                en.SaveChanges();
            }
        }
    }
}
