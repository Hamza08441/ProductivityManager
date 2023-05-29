using webapi.Models;
using webapi.ViewModels;

namespace webapi.services.EmployeeService
{
    public interface IEmployeeService
    {
        Employees addEmployee(EmployeesVM employeesVM);
        EmployeesVM checkEmail(EmployeesVM employeesVM);
        // EmployeesVM viewBYID(EmployeesVM employeesVM);
        public Employees FindEmployeeById(Guid employeeId);
    }
}
