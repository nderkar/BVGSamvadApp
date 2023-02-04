using Samvad_App.Server.Models;
using Samvad_App.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace Samvad_App.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController
    {
        private readonly IEmployeeService _EmployeeService;
        public EmployeeController(IEmployeeService EmployeeService)
        {
            _EmployeeService = EmployeeService;
        }
        [HttpGet]
        public async Task<List<Employee>> GetAll()
        {
            return await _EmployeeService.GetAllEmployees();
        }
        [HttpGet("{id}")]
        public async Task<Employee> Get(int id)
        {
            return await _EmployeeService.GetEmployee(id);
        }
        [HttpPost]
        public async Task<Employee> AddEmployee([FromBody] Employee employee)
        {
            return await _EmployeeService.AddEmployee(employee);
        }
        [HttpDelete("{id}")]
        public async Task<bool> DeleteEmployee(int id)
        {
            await _EmployeeService.DeleteEmployee(id);
            return true;
        }
        [HttpPut("{id}")]
        public async Task<bool> UpdateEmployee(int id, [FromBody] Employee Object)
        {
            await _EmployeeService.UpdateEmployee(id, Object);
            return true;
        }
    }
}
