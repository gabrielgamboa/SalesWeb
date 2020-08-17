using SalesWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWeb.Services
{
    public class DepartmentService
    {
        private readonly SalesWebContext _context;

        public DepartmentService (SalesWebContext context)
        {
            _context = context;
        }

        public List<Department> findAll()
        {
            return _context.Department.OrderBy(dep => dep.Name).ToList();
        }
    }
}
