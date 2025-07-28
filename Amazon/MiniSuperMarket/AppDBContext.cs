using Microsoft.EntityFrameworkCore;
using MiniSuperMarket.Data;
using MiniSuperMarket.Models;

namespace MiniSuperMarket
{
    public class AppDBContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Users> Users { get; set; }
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {

        }
    }
}
