using Microsoft.EntityFrameworkCore;
using RDLC_Report.Models;

namespace RDLC_Report.Data
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
      public DbSet<EmployeeSalary> EmployeeSalary { get; set; }
    }

}
