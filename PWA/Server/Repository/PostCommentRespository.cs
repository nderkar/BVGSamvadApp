using Microsoft.EntityFrameworkCore;
using Samvad_App.Server.Data;
using Samvad_App.Server.Models;

namespace Samvad_App.Server.Repository
{
    public class PostCommentRespository : IRepository<PostComment>
    {
        ApplicationDbContext _dbContext;
        public PostCommentRespository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public async Task<PostComment> CreateAsync(PostComment _object)
        {
            var obj = await _dbContext.PostComment.AddAsync(_object);
            _dbContext.SaveChanges();
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

        public Task<List<PostComment>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<PostComment>> GetAllAsync(int page, int size)
        {
            throw new NotImplementedException();
        }

        public Task<List<PostComment>> GetAllPostByUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetById(long postid, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetById(long postid)
        {
            Task<int> cnt = null;
            IQueryable<PostComment> c = _dbContext.PostComment.Where(x => x.postid == postid);
            if (c != null)
            {
                cnt = Task.FromResult(c.Count<PostComment>()); 
            }
            return cnt;
        }

        public Task<PostComment> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<PostComment> GetByIdAsync(long postid)
        {
            throw new NotImplementedException();
        }

        public Task<PostComment> GetByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<PostComment> GetByPostId(long postid, string userId)
        {
            throw new NotImplementedException();
        }
        public IQueryable<PostComment> GetAllPostComment()
        {
            return  _dbContext.PostComment.AsQueryable();
        }
        public async Task<List<PostComment>> GetByPostIdAsync(long postid, string userlikescomments)
        {
            List<PostComment> pCommentList = await GetAllPostComment().Where(u => u.postid == postid).OrderByDescending(u=> u.createddate).ToListAsync();
            return pCommentList;
           
        }

        public Task UpdateAsync(PostComment _object)
        {
            throw new NotImplementedException();
        }

        public Task<PostComment> UpdateAsync(PostComment _object, int inc, string countType)
        {
            throw new NotImplementedException();
        }
    }
}
