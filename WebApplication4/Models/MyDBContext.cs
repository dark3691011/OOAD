using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class MyDBContext: DbContext
    {
        public DbSet<DocGia> Docgias { get; set; }
        public DbSet<QuanLy> Quanlys { get; set; }
        public DbSet<Sach> Sachs { get; set; }
        public DbSet<ThuThu> ThuThus { get; set; }
        public DbSet<ThuVien> ThuViens { get; set; }
        public MyDBContext(DbContextOptions<MyDBContext>options) 
            : base(options)
        { }
    }
}
