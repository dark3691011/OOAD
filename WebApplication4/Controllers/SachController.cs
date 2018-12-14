using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class SachController : Controller
    {
        private readonly MyDBContext db;
        public SachController(MyDBContext context)
        {
            db = context;
        }
        public IActionResult Index(int? id)
        {
            List<Sach> dsSach = new List<Sach>();
            if (id.HasValue)
            {
                dsSach = db.Sachs.Where(p => p.MaSach == id)
                    .ToList();
            }
            else
            {
                dsSach = db.Sachs.ToList();
            }
            return View(dsSach.Select(p => new SachViewModel
            {
                MaSach = p.MaSach,
                TuaSach = p.TuaSach,
                TacGia = p.TacGia,
                Hinh = p.Hinh,
                GioiThieu = p.GioiThieu
            }));
        }
        public IActionResult ChiTiet(int? id)
        {
            if (!id.HasValue)
            {
                return RedirectToAction("Index", "Sach");
            }

            Sach s = db.Sachs.SingleOrDefault(p => p.MaSach == id);
            if (s != null)
            {
                return View(s);
            }
            return RedirectToAction("Index", "Sach");
        }
    }
}