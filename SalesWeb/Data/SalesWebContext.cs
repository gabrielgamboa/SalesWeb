using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWeb.Models
{
    public class SalesWebContext : DbContext
    {
        public SalesWebContext (DbContextOptions<SalesWebContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWeb.Models.Department> Department { get; set; }
    }
}
