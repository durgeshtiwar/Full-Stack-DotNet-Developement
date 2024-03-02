using ITExpertseraEmployeeinfo.Models;
using Microsoft.EntityFrameworkCore;

namespace ITExpertseraEmployeeinfo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
