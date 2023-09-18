using RDLC_Report.Models;

namespace RDLC_Report.Services
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeSalary>> GetSalary();
    }
}
