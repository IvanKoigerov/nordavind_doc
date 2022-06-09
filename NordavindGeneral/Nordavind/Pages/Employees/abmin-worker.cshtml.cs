using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NordavindGeneral.Services;
using NordavindGeneral.Models;
namespace Nordavind.Pages.Employees
{
    public class abmin_workerModel : PageModel
    {
        private readonly IEmployeeRepository _db;
        public abmin_workerModel(IEmployeeRepository db)
        {
            _db = db;
        }
        public IEnumerable<Employee> Employees { get; set; }
        public void OnGet()
        {
            Employees = _db.GetAllEmployees();
        }
    }
}
