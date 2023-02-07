using Samvad_App.Server.Models;
using Samvad_App.Server.Repository;

namespace Samvad_App.Server.Services
{
    public class PostLikeService :IPostLikeService
    {
        private readonly IRepository<PostLike> _postLikeService;
        public PostLikeService(IRepository<PostLike> PostLikeService)
        {
            _postLikeService = PostLikeService;
        }
        public async Task<PostLike> AddPostLike(PostLike PostLike)
        {
            PostLike postLike = null;
            if(_postLikeService.GetById(PostLike.postid,PostLike.userid).Result > 0)
            {
                PostLike pl = await _postLikeService.GetByPostId(PostLike.postid, PostLike.userid);
                if(pl != null)
                {
                    await _postLikeService.DeleteAsync(pl.likeid);
                }
                
            }
            else
            {
                postLike = await _postLikeService.CreateAsync(PostLike);
            }
            return postLike;
        }
        public Task<int> GetPostLikeCount(long postid, string userid)
        {
            return _postLikeService.GetById(postid, userid);
        }
        public Task<int> GetPostLikeCountByPost(long postid)
        {
            return _postLikeService.GetById(postid);
        }
        public Task<PostLike> GetPostLike(long postid, string userid)
        {
            return _postLikeService.GetByPostId(postid, userid);
        }
        public async Task<bool> DeletePostLike(long id)
        {
            await _postLikeService.DeleteAsync(id);
            return true;
        }

       
    }
}
