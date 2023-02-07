using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Samvad_App.Server.Models;
using Samvad_App.Server.Services;

namespace Samvad_App.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostCommentController : ControllerBase
    {
        private readonly IPostCommentService _PostCommentService;
        private readonly IPostService _PostService;
        public PostCommentController(IPostCommentService postCommentService, IPostService postService)
        {
            _PostCommentService = postCommentService;
            _PostService = postService;
        }
        //[HttpGet("{postid}/{userid}")]
        //public Task<int> GetPostLikeCountAsync(long postid, string userid)
        //{
        //    return _PostLikeService.GetPostLikeCount(postid, userid);
        //}
        [HttpGet("{id}")]
        public async Task<List<PostComment>> Get(long id)
        {
            return await _PostCommentService.GetPostComment(id, "usercomments");
        }
        [HttpPost]
        public async Task<Post> AddPostComment([FromBody] Post post)
        {
            PostComment newpostcomment = null;
            Post updatedPost = null;
            try
            {
                PostComment postcomment = new PostComment();
                postcomment.userid = post.modifiedby;
                postcomment.postid = post.postid;
                postcomment.createddate = DateTime.Now;
                postcomment.modifieddate = DateTime.Now;
                postcomment.comment = post.postmessage;
                postcomment.isdeleted = false;
                newpostcomment = await _PostCommentService.AddPostComment(postcomment);
                int cnt = _PostCommentService.GetPostCommentCountByPost(post.postid).Result;
                updatedPost = await _PostService.UpdateCount(post, cnt,"comment");
            }
            catch (Exception ex)
            {

            }

            return updatedPost;
        }
        [HttpDelete("{id}")]
        public async Task<bool> DeletePostLike(long id)
        {
            await _PostCommentService.DeletePostComment(id);
            return true;
        }
    }
}
