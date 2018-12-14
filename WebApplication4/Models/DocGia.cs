using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class DocGia : User
    {
        [Key]
        public int MaKH { get; set; }
        public int SoSachMuon { get; set; }
        public int LoaiDG { get; set; }
        public int GioiHanSach { get; set; }
        public int GioiHanTG { get; set; }
    }
}
