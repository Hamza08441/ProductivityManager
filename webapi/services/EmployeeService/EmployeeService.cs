using webapi.Data;
using webapi.Models;
using webapi.ViewModels;

namespace webapi.services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly dbContext _context;
        public EmployeeService(dbContext context) {
        _context = context;
        }
        public Employees addEmployee(EmployeesVM employeesVM)
        {
            if (employeesVM == null)
                return null;
            Employees newEmployee = new Employees()
            {
                id = Guid.NewGuid(),
                first_name = employeesVM.first_name,
                last_name = employeesVM.last_name,
                email = employeesVM.email
            };
            _context.employees.Add(newEmployee);
            _context.SaveChanges();
            return newEmployee;
        }

        public Employees editEmployee(Guid employeeId, EmployeesVM employeesVM)
        {
            if (employeesVM == null || employeeId == null)
                return null;

            Employees existingEmployee = _context.employees.FirstOrDefault(e => e.id == employeeId);
            if (existingEmployee == null)
                return null;

            existingEmployee.first_name = employeesVM.first_name;
            existingEmployee.last_name = employeesVM.last_name;
            existingEmployee.email = employeesVM.email;

            _context.SaveChanges();

            return existingEmployee;
        }


        public EmployeesVM checkEmail(EmployeesVM employeesVM)
        {
            if(_context.employees.Where(x => x.email == employeesVM.email).FirstOrDefault() == null)
                return employeesVM;
            return null;
        }
    }
}
