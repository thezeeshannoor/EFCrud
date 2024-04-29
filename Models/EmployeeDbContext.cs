using Microsoft.EntityFrameworkCore;

namespace EntityFrameWork.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions option)  : base(option) { }
        public DbSet<Employee> Employees { get; set; } 

    }
}
