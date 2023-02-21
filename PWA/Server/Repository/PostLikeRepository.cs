using Samvad_App.Server.Data;
using Samvad_App.Server.Models;
using Samvad_App.Shared.Models;

namespace Samvad_App.Server.Repository
{
    public class PostLikeRepository : IRepository<PostLike>
    {
        ApplicationDbContext _dbContext;
        public PostLikeRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public async Task<PostLike> CreateAsync(PostLike _object)
        {
            var obj = await _dbContext.PostLike.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }
        public Task<int> GetById(long postid, string userId)
        {
            Task<int> cnt = null;
            IQueryable<PostLike> c = _dbContext.PostLike.Where(x => x.postid == postid).Where(x => x.userid == userId);
            if(c != null)
            {
                cnt = Task.FromResult(c.Count<PostLike>()); //Task.FromResult(c.Count());
            }
            return cnt;
        }
        public Task<int> GetById(long postid)
        {
            Task<int> cnt = null;
            IQueryable<PostLike> c = _dbContext.PostLike.Where(x => x.postid == postid);
            if (c != null)
            {
                cnt = Task.FromResult(c.Count<PostLike>()); //Task.FromResult(c.Count());
            }
            return cnt;
        }
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(long id)
        {
            var data = _dbContext.PostLike.FirstOrDefault(x => x.likeid == id);
            _dbContext.Remove(data);
            await _dbContext.SaveChangesAsync();
        }

        public Task<List<PostLike>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<PostLike>> GetAllAsync(int page, int size)
        {
            throw new NotImplementedException();
        }

        public Task<List<PostLike>> GetAllPostByUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<PostLike> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<PostLike> GetByIdAsync(long postid)
        {
            throw new NotImplementedException();
        }

        public Task<PostLike> GetByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }        

        public Task UpdateAsync(PostLike _object)
        {
            throw new NotImplementedException();
        }

        public Task<PostLike> UpdateAsync(PostLike _object, int inc, string countType)
        {
            throw new NotImplementedException();
        }

        public Task<List<PostLike>> GetByPostIdAsync(long postid, string userlikescomments)
        {
            throw new NotImplementedException();
        }

        public async Task<PostLike> GetByPostId(long postid, string userId)
        {
            PostLike pl = null;           

            IQueryable<PostLike> c = _dbContext.PostLike.Where(x => x.postid == postid).Where(x => x.userid == userId);
            if (c != null)
            {
                pl = c.FirstOrDefault(); 
            }
            return pl;
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PostLike>> GetAllAsync(UserSearchModel model, int page, int size)
        {
            throw new NotImplementedException();
        }
    }
}
