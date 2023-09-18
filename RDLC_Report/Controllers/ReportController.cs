using AspNetCore.Reporting;
using Microsoft.AspNetCore.Mvc;
using RDLC_Report.Services;

namespace RDLC_Report.Controllers
{
    public class ReportController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IEmployeeRepository _employeeRepository;

        public ReportController(IWebHostEnvironment webHostEnvironment, IEmployeeRepository employeeRepository)
        {
            _webHostEnvironment = webHostEnvironment;
            _employeeRepository = employeeRepository;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Print()
        {
            string mimtype = "";
            int extention = 1;
            var path = $"{_webHostEnvironment.WebRootPath}\\Reports\\Report.rdlc";
            Dictionary<string,string> parameters = new Dictionary<string,string>();
            //parameters.Add("rp1","Report");
            
            var products = await _employeeRepository.GetSalary();
            LocalReport localReport=new LocalReport(path);
            localReport.AddDataSource("Employee", products);
            var result = localReport.Execute(RenderType.Pdf,extention,parameters,mimtype);

            return File(result.MainStream,"application/pdf");
        }
    }
}
