using Samvad_App.Server.Models;

namespace Samvad_App.Server.Services
{
    public interface IPostLikeService
    {
        Task<PostLike> AddPostLike(PostLike PostLike);        
        Task<bool> DeletePostLike(long id);
        Task<int> GetPostLikeCount(long postid, string userid);
        Task<int> GetPostLikeCountByPost(long postid);
        Task<PostLike> GetPostLike(long postid, string userid);
    }
}
