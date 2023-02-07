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

        //public List<ApplicationUser> GetByPostId(long postid, int page = 0, int size = 10)
        //{
            
        //}
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

        public async Task<List<ApplicationUser>> GetByPostIdAsync(long postid,string userlikescomments)
        {
            List<ApplicationUser> postUsers = null;
            if(userlikescomments == "userlikes")
            {
                postUsers = await (from postLike in _dbContext.PostLike
                                   join user in _dbContext.Users on postLike.userid equals user.Id
                                   where postLike.postid == postid
                                   select user).ToListAsync();
            }
            else
            {
                postUsers = await (from postComment in _dbContext.PostComment
                                   join user in _dbContext.Users on postComment.userid equals user.Id
                                   where postComment.postid == postid
                                   select user).ToListAsync();
            }
            
            return postUsers;
        }

        public Task UpdateAsync(ApplicationUser _object)
        {
            throw new NotImplementedException();
        }

        public Task<List<ApplicationUser>> GetAllAsync(int page, int size)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUser> UpdateAsync(ApplicationUser _object, int inc, string countType)
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

        public Task<ApplicationUser> GetByPostId(long postid, string userId)
        {
            throw new NotImplementedException();
        }
    }
}
