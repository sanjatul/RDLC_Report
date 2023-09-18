using Microsoft.EntityFrameworkCore;
using RDLC_Report.Data;
using RDLC_Report.Models;

namespace RDLC_Report.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DatabaseContext _databaseContext;
        public EmployeeRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public async Task<IEnumerable<EmployeeSalary>> GetSalary()
        {
            return await _databaseContext.EmployeeSalary.ToListAsync();
        }
    }
}
