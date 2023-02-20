using Samvad_App.Server.Data;
using Samvad_App.Server.Models;
using Microsoft.EntityFrameworkCore;
namespace Samvad_App.Server.Repository
{
    public class EmployeeRepository : IRepository<Employee>
    {
        ApplicationDbContext _dbContext;
        public EmployeeRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public async Task<Employee> CreateAsync(Employee _object)
        {
            var obj = await _dbContext.Employees.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }
        public async Task UpdateAsync(Employee _object)
        {
            _dbContext.Employees.Update(_object);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Employee>> GetAllAsync()
        {
            return await _dbContext.Employees.ToListAsync();
        }
        public async Task<Employee> GetByIdAsync(int Id)
        {
            return await _dbContext.Employees.FirstOrDefaultAsync(x => x.Id == Id);
        }
        public async Task DeleteAsync(int id)
        {
            var data = _dbContext.Employees.FirstOrDefault(x => x.Id == id);
            _dbContext.Remove(data);
            await _dbContext.SaveChangesAsync();
        }

        public Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetAllAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetByIdAsync(long postid)
        {
            throw new NotImplementedException();
        }

        Task<Employee> IRepository<Employee>.GetByIdAsync(long postid)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetAllPostByUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetByPostIdAsync(long postid, string userlikescomments)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetAllAsync(int page, int size)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateAsync(Employee _object, int inc, string countType)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetById(long postid, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetById(long postid)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetByPostId(long postid, string userId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
