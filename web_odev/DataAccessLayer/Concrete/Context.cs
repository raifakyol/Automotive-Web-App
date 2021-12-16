using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-GJPOVRTV; database=akyol_otomotiv; integrated security=true;");
        }
        public DbSet<Arac> Cars { get; set; }
        public DbSet<Opsiyonlar> Options { get; set; }
        public DbSet<Gallery> Gallerys { get; set; }
        public DbSet<Kullanici> Users { get; set; }


    }
}
