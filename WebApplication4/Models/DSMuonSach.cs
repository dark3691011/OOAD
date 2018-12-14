using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class DSMuonSach
    {
        [Key]
        public int MaMuon { get; set; }
        public string MaKH { get; set; }
        public string MaSach { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayPhaiTra { get; set; }
        public bool TinhTrang { get; set; }

        [ForeignKey("MaKH")]
        public DocGia DocGia { get; set; }
        [ForeignKey("MaSach")]
        public Sach Sach { get; set; }
    }
}
