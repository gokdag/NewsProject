using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace NewsProject.data.Models
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS; database=NewsProject; integrated security=true;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Report> Reports { get; set; }
        public DbSet<Category> Categories { get; set; }

        internal object Where(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
