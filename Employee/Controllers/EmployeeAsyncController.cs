using Employee.Services.Interface;
using Employee.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class EmployeeAsyncController : ControllerBase
    {
        readonly IEmployeeService _employeeService;
        public EmployeeAsyncController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
     
        [HttpGet(Name = "GetEmployessAsync")]
        public async Task<List<Employees>> GetEmployessAsync()
        {
            return await _employeeService.GetEmployeesAsync();
        }
    }
}