using System;
using System.Collections.Generic;

namespace DACN_WEBQLNH.Models
{
    public partial class TaiKhoan
    {
        public int Id { get; set; }
        public string? HoTen { get; set; }
        public string? Sdt { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Salt { get; set; }
        public bool Active { get; set; }
        public int? RoleId { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
