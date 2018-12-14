using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Sach
    {
        [Key]
        public int MaSach { get; set; }
        public string TuaSach { get; set; }
        public string TacGia { get; set; }
        public string NhaXuatBan { get; set; }
        public string GioiThieu { get; set; }
        public string DanhGia { get; set; }
        public string SoLuong { get; set; }
        public string NamXuatBan { get; set; }
        public int MaChiNhanh { get; set; }
        public string Hinh { get; set; }

        [ForeignKey("MaChiNhanh")]
        public ThuVien ThuVien { get; set; }
    }
}
