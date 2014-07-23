using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iShop.DTO
{
    class NhanVienDto
    {
        public string id { get; set; }
        public string tenNhanVien { get; set; }
        public string boPhan { get; set; }
        public bool gioiTinh { get; set; }
        public Nullable<DateTime> ngaySinh { get; set; }
        public string soDienThoai { get; set; }
        public string email { get; set; }
        public string  diaChi { get; set; }

        public string GioiTinh
        {
            get 
            {
                if (gioiTinh)
                {
                    return "Nam";
                }
                else
                {
                    return "Nữ";
                }
            }
        }
    }
}
