using Microsoft.AspNetCore.Mvc;
using Employee.Services.Interface;
using Employee.ViewModel;
using Microsoft.AspNetCore.Authorization;

namespace Employee.Controller
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet(Name = "GetEmployees")]
        public List<Employees> GetEmployess()
        {
            return _employeeService.GetEmployees();
        }
       
    }
}
