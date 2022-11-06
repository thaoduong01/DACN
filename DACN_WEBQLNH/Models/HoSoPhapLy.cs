using System;
using System.Collections.Generic;

namespace DACN_WEBQLNH.Models
{
    public partial class HoSoPhapLy
    {
        public string IdPhapLy { get; set; } = null!;
        public string Gdkkd { get; set; } = null!;
        public string DieuLeCty { get; set; } = null!;
        public string BbhopHd { get; set; } = null!;
        public string TenKttruong { get; set; } = null!;
        public string CmndCccdKtt { get; set; } = null!;
        public DateTime NgayNhanHs { get; set; }
        public string Gcndkthue { get; set; } = null!;
        public string IdHsvay { get; set; } = null!;

        public virtual HoSoVayDoanhNghiep IdHsvayNavigation { get; set; } = null!;
    }
}
