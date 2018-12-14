using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class ThuVien
    {
        [Key]
        public int MaChiNhanh { get; set; }
        public string TenChiNhanh { get; set; }
        public string DiaChi { get; set; }
    }
}
