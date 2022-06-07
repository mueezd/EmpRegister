using Microsoft.EntityFrameworkCore;

namespace EmpRegister.Models
{
    public class empDbContext : DbContext
    {
        public empDbContext(DbContextOptions<empDbContext> options) : base(options)
        {



        }

        public DbSet<Employee> Employees { get; set; }
    }
}
