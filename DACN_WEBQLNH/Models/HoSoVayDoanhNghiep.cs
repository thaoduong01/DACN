using System;
using System.Collections.Generic;

namespace DACN_WEBQLNH.Models
{
    public partial class HoSoVayDoanhNghiep
    {
        public HoSoVayDoanhNghiep()
        {
            BienLaiThuLais = new HashSet<BienLaiThuLai>();
            HoSoBaoCaoTcs = new HashSet<HoSoBaoCaoTc>();
            HoSoPhapLies = new HashSet<HoSoPhapLy>();
            HoSoTaiSanDbs = new HashSet<HoSoTaiSanDb>();
        }

        public string IdHsvay { get; set; } = null!;
        public DateTime NgayBdvay { get; set; }
        public double SoTienVay { get; set; }
        public DateTime NgayKt { get; set; }
        public double LaiSuat { get; set; }
        public string IdNhanVien { get; set; } = null!;
        public string IdKhachHang { get; set; } = null!;

        public virtual DoanhNghiep IdKhachHangNavigation { get; set; } = null!;
        public virtual NhanVien IdNhanVienNavigation { get; set; } = null!;
        public virtual ICollection<BienLaiThuLai> BienLaiThuLais { get; set; }
        public virtual ICollection<HoSoBaoCaoTc> HoSoBaoCaoTcs { get; set; }
        public virtual ICollection<HoSoPhapLy> HoSoPhapLies { get; set; }
        public virtual ICollection<HoSoTaiSanDb> HoSoTaiSanDbs { get; set; }
    }
}
