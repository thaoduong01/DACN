using System;
using System.Collections.Generic;

namespace DACN_WEBQLNH.Models
{
    public partial class HoSoPhuongAnVay
    {
        public string IdHspavay { get; set; } = null!;
        public string PhuongAnKd { get; set; } = null!;
        public string KeHoachTraNo { get; set; } = null!;
        public DateTime NgayNhanHs { get; set; }
    }
}
