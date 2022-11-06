using System;
using System.Collections.Generic;

namespace DACN_WEBQLNH.Models
{
    public partial class KhachHangCaNhan
    {
        public KhachHangCaNhan()
        {
            HoSoTinDungs = new HashSet<HoSoTinDung>();
        }

        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; } = null!;
        public bool GioiTinh { get; set; }
        public string Sdt { get; set; } = null!;
        public string CmndCccd { get; set; } = null!;
        public string IdKhachHang { get; set; } = null!;

        public virtual KhachHang IdKhachHangNavigation { get; set; } = null!;
        public virtual ICollection<HoSoTinDung> HoSoTinDungs { get; set; }
    }
}
