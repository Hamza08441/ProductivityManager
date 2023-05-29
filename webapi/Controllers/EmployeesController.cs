using Microsoft.AspNetCore.Mvc;
using webapi.Models;
using webapi.services.EmployeeService;
using webapi.ViewModels;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpPost(nameof(add))]
        public IActionResult add(EmployeesVM employees)
        {
            return Ok(_employeeService.addEmployee(_employeeService.checkEmail(employees)));
        }
        [HttpPost(nameof(find))]
        public IActionResult find(Guid employeeId) {
            return Ok(_employeeService.FindEmployeeById(employeeId));
        
        }
    }
}
