using webapi.Models;
using webapi.ViewModels;

namespace webapi.services.EmployeeService
{
    public interface IEmployeeService
    {
        Employees addEmployee(EmployeesVM employeesVM);
        EmployeesVM checkEmail(EmployeesVM employeesVM);
        Employees editEmployee(Guid employeeId, EmployeesVM employeesVM);
    }
}
