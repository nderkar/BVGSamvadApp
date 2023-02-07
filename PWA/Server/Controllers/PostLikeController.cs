using Microsoft.AspNetCore.Mvc;
using Samvad_App.Server.Models;
using Samvad_App.Server.Services;

namespace Samvad_App.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostLikeController : ControllerBase
    {
        private readonly IPostLikeService _PostLikeService;
        private readonly IPostService _PostService;
        public PostLikeController(IPostLikeService PostLikeService, IPostService postService)
        {
            _PostLikeService = PostLikeService;
            _PostService = postService;
        }
       
        [HttpGet("{postid}/{userid}")]
        public Task<int> GetPostLikeCountAsync(long postid, string userid)
        {
            return _PostLikeService.GetPostLikeCount(postid, userid);
        }
        [HttpPost]
        public async Task<Post> AddPostLike([FromBody] Post post)
        {
            PostLike newpostlike = null;
            Post updatedPost = null;
            try
            {
                PostLike postlike = new PostLike();
                postlike.userid = post.modifiedby;
                postlike.postid = post.postid;
                postlike.createddate = DateTime.Now;
                newpostlike = await _PostLikeService.AddPostLike(postlike);
                int cnt = _PostLikeService.GetPostLikeCountByPost(post.postid).Result;
                updatedPost = await _PostService.UpdateCount(post, cnt,"like");
            }
            catch(Exception ex)
            {

            }
           
            return updatedPost;
        }
        [HttpDelete("{id}")]
        public async Task<bool> DeletePostLike(long id)
        {
            await _PostLikeService.DeletePostLike(id);
            return true;
        }
    }
}
