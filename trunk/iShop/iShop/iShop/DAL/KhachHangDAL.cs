using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using iShop.DTO;

namespace iShop.DAL
{
    class KhachHangDAL
    {
        //Chon toan bo Khach Hang
        public DataTable SelectAllKhachHang()
        {
            iShopEntities shop = new iShopEntities();
            List<KhachHang> kh = (from k in shop.KhachHangs select k).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("TenKhachHang");
            dt.Columns.Add("SoDienThoai");
            dt.Columns.Add("Email");
            dt.Columns.Add("DiaChi");
            dt.Columns.Add("GhiChu");
            foreach (KhachHang k in kh)
            {
                dt.Rows.Add(k.ID, k.TenKhachHang, k.SoDienThoai, k.Email, k.DiaChi, k.GhiChu);
            }
            return dt;
        }

        //INSERT
        public void InsertKhachHang(KhachHang k)
        {
            using (iShopEntities shop = new iShopEntities())
            {
                shop.KhachHangs.AddObject(k);
                shop.SaveChanges();
            }
        }

        //UPDATE
        public void UpdateKhachHang(KhachHangDto k)
        {
            using (iShopEntities en = new iShopEntities())
            {
                var q = (from kh in en.KhachHangs where kh.ID == k.id select kh).First();

                    q.ID = k.id;
                    q.TenKhachHang = k.tenKhachHang;
                    q.SoDienThoai = k.soDienThoai;
                    q.Email = k.email;
                    q.DiaChi = k.diaChi;
                    q.GhiChu = k.ghiChu;
                    en.SaveChanges();
            }
        }

        //DELETE
        public void DeleteKhachHang(string id)
        {
            using (iShopEntities shop = new iShopEntities())
            {
                var q = (from k in shop.KhachHangs where k.ID == id select k).FirstOrDefault();
                if (q != null)
                {
                    shop.KhachHangs.DeleteObject(q);
                    shop.SaveChanges();
                }
            }
        }
    }
}
