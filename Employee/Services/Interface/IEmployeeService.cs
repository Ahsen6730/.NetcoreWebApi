using Employee.ViewModel;

namespace Employee.Services.Interface
{
    public interface IEmployeeService
    {
        List<Employees> GetEmployees();
        Task<List<Employees>> GetEmployeesAsync();
    }
}
