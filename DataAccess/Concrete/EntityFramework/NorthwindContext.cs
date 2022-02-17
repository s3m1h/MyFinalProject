using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    // context nesnesi db tabloları ile proje classlarını bağlamak
    public class NorthwindContext:DbContext
    {
        // projemiz hangi veritabanı ile ilişkilendirecek onu belirteceğiz
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
            //base.OnConfiguring(optionsBuilder);
        }
        // hangi class hangi tabloya karşılık gelecek burada bunu belirtiyoruz
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        
    }

}
