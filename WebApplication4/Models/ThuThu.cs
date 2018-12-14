using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class ThuThu : User
    {
        [Key]
        public int MaTT { get; set; }
        public int MaChiNhanh { get; set; }

        [ForeignKey("MaChiNhanh")]
        public ThuVien ThuVien { get; set; }
    }
}
