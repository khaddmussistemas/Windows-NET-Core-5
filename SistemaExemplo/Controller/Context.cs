using Microsoft.EntityFrameworkCore;
using SistemaExemplo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaExemplo.Controller
{
    public class Context :DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Empresa> Empresa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-O28CVM7; Initial Catalog =SistemaExemplo; User ID =sa ; Password=123 ");
        }
    }
}
