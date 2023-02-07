using Samvad_App.Server.Models;

namespace Samvad_App.Server.Services
{
    public interface IPostService
    {
        Task<Post> AddPost(Post Post);
        Task<bool> UpdatePost(long postid, Post Post);
        Task<bool> DeletePost(long postid);
        Task<List<Post>> GetAllPost(int page,int size);
        Task<List<Post>> GetAllPostByUserAsync(string userId);
        Task<Post> GetPost(long postid);
        Task<Post> UpdateCount(Post post, int cnt,string countType);
    }
}
