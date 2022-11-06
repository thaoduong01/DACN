using System;
using System.Collections.Generic;

namespace DACN_WEBQLNH.Models
{
    public partial class HoSoBaoCaoTc
    {
        public string IdBctc { get; set; } = null!;
        public string? ToVat { get; set; }
        public string? HopDongSdld { get; set; }
        public string? HopDongMuaBan { get; set; }
        public string SaoKeTknh { get; set; } = null!;
        public DateTime NgayNhanHs { get; set; }
        public string BctaiChinh { get; set; } = null!;
        public string IdHsvay { get; set; } = null!;

        public virtual HoSoVayDoanhNghiep IdHsvayNavigation { get; set; } = null!;
    }
}
