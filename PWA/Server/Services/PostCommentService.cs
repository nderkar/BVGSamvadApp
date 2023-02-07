using Samvad_App.Server.Models;
using Samvad_App.Server.Repository;

namespace Samvad_App.Server.Services
{
    public class PostCommentService : IPostCommentService
    {
        private readonly IRepository<PostComment> _postCommentService;
        public PostCommentService(IRepository<PostComment> PostCommentService)
        {
            _postCommentService = PostCommentService;
        }

        public async Task<PostComment> AddPostComment(PostComment postComment)
        {
            PostComment _postComment = null;
            _postComment = await _postCommentService.CreateAsync(postComment);
            return _postComment;
        }

        public Task<bool> DeletePostComment(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PostComment>> GetPostComment(long postid, string userlikescomments)
        {
            return await _postCommentService.GetByPostIdAsync(postid,userlikescomments);
        }

        public Task<List<PostComment>> GetPostCommentByUser(long postid, string userid)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetPostCommentCountByPost(long postid)
        {
            return _postCommentService.GetById(postid);
        }
    }
}
