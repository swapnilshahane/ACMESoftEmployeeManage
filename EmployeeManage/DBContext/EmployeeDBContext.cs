using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EmployeeManage.DBContext
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions options) : base(options) 
        { 
        }

        public DbSet<PersonModel> Person { get; set; }

        public DbSet<EmployeeModel> Employee { get; set; }

    }
}
