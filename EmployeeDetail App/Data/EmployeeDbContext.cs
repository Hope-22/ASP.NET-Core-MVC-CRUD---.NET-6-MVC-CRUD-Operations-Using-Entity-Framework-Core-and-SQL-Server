using EmployeeDetail_App.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDetail_App.Data
{
    public class EmployeeDbContext : DbContext 
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
