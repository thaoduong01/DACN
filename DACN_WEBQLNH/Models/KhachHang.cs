using System;
using System.Collections.Generic;

namespace DACN_WEBQLNH.Models
{
    public partial class KhachHang
    {
        public string IdKhachHang { get; set; } = null!;
        public string? MaSoThue { get; set; }

        public virtual DoanhNghiep? DoanhNghiep { get; set; }
        public virtual KhachHangCaNhan? KhachHangCaNhan { get; set; }
    }
}
