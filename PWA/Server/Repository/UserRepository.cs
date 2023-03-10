using Microsoft.EntityFrameworkCore;
using Samvad_App.Server.Data;
using Samvad_App.Server.Models;
using Samvad_App.Shared.Models;
using System.Collections.Generic;
using System.Linq.Expressions;

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

        public async Task DeleteAsync(string id)
        {
            var data = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            _dbContext.Remove(data);
            await _dbContext.SaveChangesAsync();
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

        public async Task<List<ApplicationUser>> GetAllAsync(int page, int size)
        {
            return await _dbContext.Users.OrderByDescending(x => x.CreatedDate).Skip(page * size).Take(size).ToListAsync();
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

        public async Task<List<ApplicationUser>> GetAllAsync(UserSearchModel model, int page, int size)
        {
            List<ApplicationUser> userList = new List<ApplicationUser>();
            if(model.SearchField.ToLower().Trim() == "all")
            {
                if(model.SearchValue.Trim() == string.Empty)
                {
                    userList = await _dbContext.Users.OrderByDescending(x => x.CreatedDate).Skip(page * size).Take(size).ToListAsync();
                }
                else
                {
                    userList = await _dbContext.Users
                        .Where(x=> 
                        x.FirstName.Contains(model.SearchValue) || 
                        x.LastName.Contains(model.SearchValue) ||
                        x.Email.Contains(model.SearchValue) ||
                        x.Category.Contains(model.SearchValue))
                        .OrderByDescending(x => x.CreatedDate)
                        .Skip(page * size)
                        .Take(size).ToListAsync();
                }
            }
            else
            {
                if (model.SearchValue.Trim() != string.Empty)
                {
                    switch (model.SearchField.ToLower().Trim())
                    {
                        case "first name":
                            userList = await _dbContext.Users
                        .Where(x =>
                        x.FirstName.Contains(model.SearchValue))
                        .OrderByDescending(x => x.CreatedDate)
                        .Skip(page * size)
                        .Take(size).ToListAsync();
                            break;
                        case "last name":
                            userList = await _dbContext.Users
                         .Where(x =>
                         x.LastName.Contains(model.SearchValue))
                         .OrderByDescending(x => x.CreatedDate)
                         .Skip(page * size)
                         .Take(size).ToListAsync();
                            break;
                        case "category":
                            userList = await _dbContext.Users
                        .Where(x =>
                        x.Category.Contains(model.SearchValue))
                        .OrderByDescending(x => x.CreatedDate)
                        .Skip(page * size)
                        .Take(size).ToListAsync();
                            break;
                        case "email":
                            userList = await _dbContext.Users
                        .Where(x =>
                        x.Email.Contains(model.SearchValue))
                        .OrderByDescending(x => x.CreatedDate)
                        .Skip(page * size)
                        .Take(size).ToListAsync();
                            break;
                        default:
                            // code block
                            break;
                    }
                    
                }
            }
           
            return userList;
        }
    }
}
