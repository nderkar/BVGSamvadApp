using Samvad_App.Server.Models;
using Samvad_App.Shared.Models;

namespace Samvad_App.Server.Repository
{
    public interface IRepository<T>
    {
        public Task<T> CreateAsync(T _object);
        public Task UpdateAsync(T _object);
        public Task<List<T>> GetAllPostByUserAsync(string userId);
        public Task<T> GetByIdAsync(int Id);
        public Task DeleteAsync(int id);
        public Task DeleteAsync(long id);
        public Task DeleteAsync(string id);
        public Task<List<T>> GetAllAsync();
        public Task<T> GetByIdAsync(long postid);
        public Task<T> GetByIdAsync(string userId);
        public Task<List<T>> GetByPostIdAsync(long postid,string userlikescomments);
        Task<List<T>> GetAllAsync(int page, int size);
        Task<List<T>> GetAllAsync(UserSearchModel model, int page, int size);
        public Task<T> UpdateAsync(T _object,int inc, string countType);
        public Task<T> GetByPostId(long postid, string userId);
        public Task<int> GetById(long postid, string userId);
        public Task<int> GetById(long postid);
    }
}
