﻿using System;
using System.Collections.Generic;

namespace DACN_WEBQLNH.Models
{
    public partial class HoSoTaiSanDb
    {
        public HoSoTaiSanDb()
        {
            HoSoThamDinhs = new HashSet<HoSoThamDinh>();
        }

        public string IdHsdb { get; set; } = null!;
        public string DcnsoHuuDat { get; set; } = null!;
        public string HdtaiSan { get; set; } = null!;
        public string SoNhaDat { get; set; } = null!;
        public string TbnopPhiNd { get; set; } = null!;
        public string SoDangKiem { get; set; } = null!;
        public string ChungNhanBaoHiem { get; set; } = null!;
        public DateTime NgayNhanHs { get; set; }
        public int IdLoaiHs { get; set; }
        public string IdHsvay { get; set; } = null!;

        public virtual HoSoVayDoanhNghiep IdHsvayNavigation { get; set; } = null!;
        public virtual LoaiHoSoTsdb IdLoaiHsNavigation { get; set; } = null!;
        public virtual ICollection<HoSoThamDinh> HoSoThamDinhs { get; set; }
    }
}
