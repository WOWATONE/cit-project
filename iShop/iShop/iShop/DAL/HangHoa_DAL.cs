using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using iShop.DTO;

namespace iShop.DAL
{
    class HangHoa_DAL
    {
        //Select all
        public DataTable SelectAll_HangHoa()
        {
            using (iShopEntities en = new iShopEntities())
            {
                List<HangHoa> hh = (from h in en.HangHoas select h).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("TenHangHoa");
                dt.Columns.Add("DonViTinh");
                dt.Columns.Add("DonGiaNhap");
                dt.Columns.Add("DonGiaBan");
                dt.Columns.Add("NhomHangHoa");
                dt.Columns.Add("SoLuong");
                dt.Columns.Add("ChatLieu");
                dt.Columns.Add("KichCo");
                dt.Columns.Add("MauSac");
                dt.Columns.Add("XuatXu");
                dt.Columns.Add("GhiChu");

                foreach (HangHoa h in hh)
                {
                    dt.Rows.Add(h.ID, h.TenHangHoa, h.DonViTinh.TenDonViTinh, 
                        h.DonGiaNhap, h.DonGiaBan, h.NhomHangHoa.TenNhomHang,
                        h.SoLuong, h.ChatLieu, h.KichCo, h.MauSac, h.XuatXu, h.GhiChu);
                }
                return dt;
            }
        }

        //INSERT
        public void InsertHangHoa(HangHoa hh)
        {
            using (iShopEntities en = new iShopEntities())
            {
                en.HangHoas.AddObject(hh);
                en.SaveChanges();
            }
        }

        //UPDATE
        public void UpdateHangHoa(HangHoaDto h)
        {
            using (iShopEntities en = new iShopEntities())
            {
                var q = (from hh in en.HangHoas where hh.ID == h.id select hh).First();
                q.ID = h.id;
                q.TenHangHoa = h.tenHangHoa;
                q.DonViTinhID = h.donViTinh;
                q.NhomHangHoaID = h.nhomHangHoa;
                q.DonGiaNhap = h.donGiaNhap;
                q.DonGiaBan = h.donGiaBan;
                q.SoLuong = h.soLuong;
                q.KichCo = h.kichCo;
                q.ChatLieu = h.chatLieu;
                q.MauSac = h.mauSac;
                q.XuatXu = h.xuatXu;
                q.GhiChu = h.ghiChu;
                en.SaveChanges();
            }
        }

        //DELETE
        public void DeleteHangHoa(string id)
        {
            using (iShopEntities en = new iShopEntities())
            {
                var q = (from h in en.HangHoas where h.ID == id select h).First();
                en.HangHoas.DeleteObject(q);
                en.SaveChanges();
            }
        }

        //Select DonGiaByTenHang
        public double SelectDonGiaBayTenHang(string tenHang)
        {
            using (iShopEntities en = new iShopEntities())
            {
                var q = (from h in en.HangHoas where h.TenHangHoa == tenHang select h.DonGiaBan).First();
                return q;
            }
        }


        //Select DonViTinhByTenHang
        public string SelectDVTByTenHang(string tenHang)
        {
            using (iShopEntities en = new iShopEntities())
            {
                var q = (from h in en.HangHoas where h.TenHangHoa == tenHang select h.DonViTinhID).ToString();
                return q;
            }
        }

        //Select ID By TenHang
        public string SelectIDByTenHang(string tenHang)
        {
            using (iShopEntities en = new iShopEntities())
            {
                var q = (from h in en.HangHoas where h.TenHangHoa == tenHang select h.ID).First();
                return q;
            }
        }

        //Select SoLuongTonHangHoa By TenHangHoa
        public int SelectSoLuongTonByTenHH(string tenHang)
        {
            using (iShopEntities en = new iShopEntities())
            {
                var q = Convert.ToInt32((from h in en.HangHoas where h.TenHangHoa == tenHang select h.SoLuong).First());
                return q;
            }
        }
    }
}
