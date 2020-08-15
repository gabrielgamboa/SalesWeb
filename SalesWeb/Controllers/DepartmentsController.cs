using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWeb.Models;

namespace SalesWeb.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index ( )
        {
            List<Department> list = new List<Department>();
            list.Add(new Department() { Id = 1, Name = "Eletronics" });
            list.Add(new Department() { Id = 2, Name = "Fashion" });


            return View(list);
        }
    }
}
