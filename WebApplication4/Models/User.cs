using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class User
    {
        protected string Username { get; set; }
        protected string Password { get; set; }
        protected string HoTen { get; set; }
        protected DateTime NgaySinh { get; set; }
        protected int GT { get; set; }
        protected string DiaChi { get; set; }
        protected string Email { get; set; }
        protected string SDT { get; set; }
    }
}
