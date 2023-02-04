using Microsoft.EntityFrameworkCore;
using Samvad_App.Server.Data;
using Samvad_App.Server.Models;

namespace Samvad_App.Server.Repository
{
    public class UserRepository : IRepository<ApplicationUser>
    {
        ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public async Task<ApplicationUser> GetByIdAsync(string userId)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == userId);
        }
        public Task<ApplicationUser> CreateAsync(ApplicationUser _object)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ApplicationUser>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<ApplicationUser>> GetAllPostByUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUser> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUser> GetByIdAsync(long postid)
        {
            throw new NotImplementedException();
        }

        public Task<List<ApplicationUser>> GetByPostIdAsync(long postid)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ApplicationUser _object)
        {
            throw new NotImplementedException();
        }

        public Task<List<ApplicationUser>> GetAllAsync(int page, int size)
        {
            throw new NotImplementedException();
        }
    }
}
