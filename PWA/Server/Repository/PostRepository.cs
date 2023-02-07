using Microsoft.EntityFrameworkCore;
using Samvad_App.Server.Data;
using Samvad_App.Server.Models;

namespace Samvad_App.Server.Repository
{
    public class PostRepository : IRepository<Post> 
    {
        ApplicationDbContext _dbContext;
        public PostRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public async Task<Post> CreateAsync(Post _object)
        {
            var obj = await _dbContext.Post.AddAsync(_object);
            _dbContext.SaveChanges();
            //_dbContext.Entry(_object).Reload();
            //return _object;
            return obj.Entity;
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        //public async Task<Post> GetAllAsync(string userId)
        //{
        //    return await _dbContext.Post.FirstOrDefaultAsync(x => x.createdby == userId);
        //}

        public async Task<List<Post>> GetAllAsync(int page=0,int size=10)
        {
            return await _dbContext.Post.OrderByDescending(x => x.createdate).Skip(page * size).Take(size).ToListAsync();
        }

        public Task<List<Post>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Post>> GetAllPostByUserAsync(string userId)
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

        public Task<Post> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<Post> GetByIdAsync(long postid)
        {
            return await _dbContext.Post.FirstOrDefaultAsync(x => x.postid == postid);
        }

        public Task<Post> GetByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetByPostId(long postid, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Post>> GetByPostIdAsync(long postid, string userlikescomments)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Post _object)
        {
            _dbContext.Post.Update(_object);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Post> UpdateAsync(Post post, int cnt, string countType)
        {
            if(countType == "like")
            {
                post.likecount = cnt;
                _dbContext.Post.Attach(post).Property(x => x.likecount).IsModified = true;
            }
            else
            {
                post.commentcount = cnt;
                _dbContext.Post.Attach(post).Property(x => x.commentcount).IsModified = true;
            }
            await _dbContext.SaveChangesAsync();
            return post;
        }
        
    }
}
