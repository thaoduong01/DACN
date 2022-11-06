using System;
using System.Collections.Generic;

namespace DACN_WEBQLNH.Models
{
    public partial class DoanhNghiep
    {
        public DoanhNghiep()
        {
            HoSoVayDoanhNghieps = new HashSet<HoSoVayDoanhNghiep>();
        }

        public string TenDoanhNghiep { get; set; } = null!;
        public string DiaChi { get; set; } = null!;
        public string Sdt { get; set; } = null!;
        public string TenNguoiDaiDien { get; set; } = null!;
        public string CmndCccd { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string IdKhachHang { get; set; } = null!;

        public virtual KhachHang IdKhachHangNavigation { get; set; } = null!;
        public virtual ICollection<HoSoVayDoanhNghiep> HoSoVayDoanhNghieps { get; set; }
    }
}
