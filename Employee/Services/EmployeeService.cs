using Microsoft.EntityFrameworkCore;
using Employee.Interface;
using Employee.Models;
using Employee.Services.Interface;
using Employee.ViewModel;

namespace Employee.Services
{
    public class EmployeeService : IEmployeeService
    {
        readonly IApplicationDbContext _applicationDbContext;
        public EmployeeService(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public List<Employees> GetEmployees()
        {
            return AdaptEmployee(_applicationDbContext.Employee.ToList<EmployeeEntity>());
        }

        public async Task<List<Employees>> GetEmployeesAsync()
        {
            return AdaptEmployee(await _applicationDbContext.Employee.ToListAsync<EmployeeEntity>());
        }

        private static List<Employees> AdaptEmployee(List<EmployeeEntity> employeeEntityList)
        {
            List<Employees> employeeList = new();
            Employees? employee;
            foreach (EmployeeEntity item in employeeEntityList)
            {
                employee = new()
                {
                    Id = item.Id,
                    LastName = item.LastName,
                };
                employeeList.Add(employee);
            }
            return employeeList;
        }
    }
}
