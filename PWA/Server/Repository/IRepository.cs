using Samvad_App.Server.Models;

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
        public Task<List<T>> GetAllAsync();
        public Task<T> GetByIdAsync(long postid);
        public Task<T> GetByIdAsync(string userId);
        public Task<List<T>> GetByPostIdAsync(long postid);
        Task<List<T>> GetAllAsync(int page, int size);
    }
}
