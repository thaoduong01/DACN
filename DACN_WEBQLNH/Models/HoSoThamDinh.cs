﻿using System;
using System.Collections.Generic;

namespace DACN_WEBQLNH.Models
{
    public partial class HoSoThamDinh
    {
        public string IdHsthamDinh { get; set; } = null!;
        public double SoTienThamDinh { get; set; }
        public DateTime NgayThamDinh { get; set; }
        public DateTime NgayNhanHoSo { get; set; }
        public string BaoCaoThamDinh { get; set; } = null!;
        public string TenNguoiThamDinh { get; set; } = null!;
        public string CmndCccd { get; set; } = null!;
        public string IdCongTy { get; set; } = null!;
        public string IdHsdb { get; set; } = null!;

        public virtual CongTyThamDinh IdCongTyNavigation { get; set; } = null!;
        public virtual HoSoTaiSanDb IdHsdbNavigation { get; set; } = null!;
    }
}
