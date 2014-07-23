using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iShop.DAL;
using iShop.DTO;
using System.Data;

namespace iShop.BLL
{
    class HangHoaBLL
    {
        //----------------------------------------

        //Select HangHoa
        public DataTable SelectAllHangHoa_BLL()
        {
            HangHoa_DAL hDAL = new HangHoa_DAL();
            return hDAL.SelectAll_HangHoa();
        }

        //Insert
        public void InsertHangHoa_BLL(HangHoa hh)
        {
            HangHoa_DAL hDAL = new HangHoa_DAL();
            hDAL.InsertHangHoa(hh);
        }

        //Update
        public void UpdateHangHoa_BLL(HangHoaDto hDto)
        {
            HangHoa_DAL hhDAL = new HangHoa_DAL();
            hhDAL.UpdateHangHoa(hDto);
        }

        //Delete
        public void DeleteHangHoa_BLL(string id)
        {
            HangHoa_DAL hhDAL = new HangHoa_DAL();
            hhDAL.DeleteHangHoa(id);
        }

        //Select DonGiaByTenHangHoa
        public double SelectDonGiaByTenHangHoa_BLL(string tenHang)
        {
            HangHoa_DAL hh = new HangHoa_DAL();
            return hh.SelectDonGiaBayTenHang(tenHang);
        }

        //Select DVT by TenHang
        public string SelectDVTByTenHang_BLL(string tenHang)
        {
            HangHoa_DAL h = new HangHoa_DAL();
            return h.SelectDVTByTenHang(tenHang);
        }

        //Select ID By TenHang
        public string SelectIDByTenHang_BLL(string tenhang)
        {
            HangHoa_DAL h = new HangHoa_DAL();
            return h.SelectIDByTenHang(tenhang);
        }

        //Select SoLuongTon By TenHang
        public int SelectSoLuongTonByTenHH_BLL(string tenHang)
        {
            HangHoa_DAL h = new HangHoa_DAL();
            return h.SelectSoLuongTonByTenHH(tenHang);
        }
    }
}
