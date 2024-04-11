using EmployeeCRUDBlazor.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUDBlazor.Context
{
    public class ApplicationDbContext:DbContext
    {
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Employee>Employees { get; set; }
    }
}
