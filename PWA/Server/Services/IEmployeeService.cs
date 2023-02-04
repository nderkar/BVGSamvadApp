using Samvad_App.Server.Models;

namespace Samvad_App.Server.Services
{
    public interface IEmployeeService
    {
        Task<Employee> AddEmployee(Employee Employee);
        Task<bool> UpdateEmployee(int id, Employee Employee);
        Task<bool> DeleteEmployee(int id);
        Task<List<Employee>> GetAllEmployees();
        Task<Employee> GetEmployee(int id);
    }
}
