namespace RDLC_Report.Models
{
    public class EmployeeSalary
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public int GrossSalary { get; set; }

    }
}
