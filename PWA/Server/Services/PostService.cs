using Samvad_App.Server.Models;
using Samvad_App.Server.Repository;

namespace Samvad_App.Server.Services
{
    public class PostService : IPostService
    {
        private readonly IRepository<Post> _post;
        public PostService(IRepository<Post> Post)
        {
            _post = Post;
        }
        public async Task<Post> AddPost(Post Post)
        {
            return await _post.CreateAsync(Post);
        }

        public async Task<bool> DeletePost(long postid)
        {
            await _post.DeleteAsync(postid);
            return true;
        }

        public async Task<List<Post>> GetAllPostByUserAsync(string userId)
        {
            return await _post.GetAllPostByUserAsync(userId);
        }

        public async Task<List<Post>> GetAllPost(int page=0,int size=10)
        {
            return await _post.GetAllAsync(page,size);
        }

        public async Task<Post> GetPost(long postid)
        {
            return await _post.GetByIdAsync(postid);
        }

        public async Task<bool> UpdatePost(long postid, Post Post)
        {
            var data = await _post.GetByIdAsync(postid);
            if (data != null)
            {
                data.modifieddate = Post.modifieddate;
                data.modifiedby = Post.modifiedby;
                data.likecount = Post.likecount;
                data.commentcount = Post.commentcount;
                await _post.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }

        public Task<PostAssetService> AddPostAsset(PostAssetService Postasset)
        {
            throw new NotImplementedException();
        }
    }
}
