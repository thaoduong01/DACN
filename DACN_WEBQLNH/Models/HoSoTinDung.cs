using System;
using System.Collections.Generic;

namespace DACN_WEBQLNH.Models
{
    public partial class HoSoTinDung
    {
        public HoSoTinDung()
        {
            TheTinDungs = new HashSet<TheTinDung>();
        }

        public int IdHstinDung { get; set; }
        public DateTime NgayNhanHs { get; set; }
        public double PhiMoThe { get; set; }
        public string ChuKy { get; set; } = null!;
        public string IdNhanVien { get; set; } = null!;
        public string IdKhachHang { get; set; } = null!;

        public virtual KhachHangCaNhan IdKhachHangNavigation { get; set; } = null!;
        public virtual NhanVien IdNhanVienNavigation { get; set; } = null!;
        public virtual ICollection<TheTinDung> TheTinDungs { get; set; }
    }
}
