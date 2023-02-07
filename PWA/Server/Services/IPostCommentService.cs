using Samvad_App.Server.Models;

namespace Samvad_App.Server.Services
{
    public interface IPostCommentService
    {
        Task<PostComment> AddPostComment(PostComment postComment);
        Task<bool> DeletePostComment(long id);
        //Task<int> GetPostCommentCount(long postid, string userid);
        Task<int> GetPostCommentCountByPost(long postid);
        Task<List<PostComment>> GetPostCommentByUser(long postid, string userid);
        Task<List<PostComment>> GetPostComment(long postid, string userlikescomments);
    }
}
