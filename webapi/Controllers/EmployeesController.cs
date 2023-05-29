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
<<<<<<< HEAD

        [HttpPut(nameof(edit))]
        public IActionResult edit(EmployeesVM employees, Guid id)
        {
            return Ok(_employeeService.editEmployee(id, _employeeService.checkEmail(employees)));
=======
        [HttpPost(nameof(find))]
        public IActionResult find(Guid employeeId) {
            return Ok(_employeeService.FindEmployeeById(employeeId));
        
>>>>>>> 2ad5f4f4cc6ff4eeca6bcc06244352556b07bb9a
        }
    }
}
