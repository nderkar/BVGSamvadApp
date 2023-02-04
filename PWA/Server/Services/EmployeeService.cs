using Samvad_App.Server.Models;
using Samvad_App.Server.Repository;
using System;

namespace Samvad_App.Server.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> _employee;
        public EmployeeService(IRepository<Employee> Employee)
        {
            _employee = Employee;
        }
        public async Task<Employee> AddEmployee(Employee Employee)
        {
            return await _employee.CreateAsync(Employee);
        }
        public async Task<bool> UpdateEmployee(int id, Employee Employee)
        {
            var data = await _employee.GetByIdAsync(id);
            if (data != null)
            {
                data.FirstName = Employee.FirstName;
                data.LastName = Employee.LastName;
                data.Email = Employee.Email;
                data.MobileNo = Employee.MobileNo;
                data.Address = Employee.Address;
                await _employee.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }
        public async Task<bool> DeleteEmployee(int id)
        {
            await _employee.DeleteAsync(id);
            return true;
        }
        public async Task<List<Employee>> GetAllEmployees()
        {
            return await _employee.GetAllAsync();
        }
        public async Task<Employee> GetEmployee(int id)
        {
            return await _employee.GetByIdAsync(id);
        }
    }
}
