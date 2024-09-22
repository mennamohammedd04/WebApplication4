using Microsoft.EntityFrameworkCore;
using WebApplication4.DAL.entities;

namespace WebApplication4.DAL.database
{
    public class applicationdbcontext : DbContext


    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=123456;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
        public DbSet<Employee>Employees { get; set; }



    }
}

