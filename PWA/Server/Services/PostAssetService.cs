using Samvad_App.Server.Models;
using Samvad_App.Server.Repository;

namespace Samvad_App.Server.Services
{
    public class PostAssetService : IPostAssetService    {
        private readonly IRepository<PostAsset> _postAssetService;
        public PostAssetService(IRepository<PostAsset> PostAssetService)
        {
            _postAssetService = PostAssetService;
        }


        public async Task<PostAsset>AddPostAsset(PostAsset Postasset)
        {
            return await _postAssetService.CreateAsync(Postasset);
        }

        public Task<PostAsset> GetPostAssetsByAssetId(long assetid)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PostAsset>> GetPostAssetsByPostId(long postid, string userlikescomments)
        {
            return await _postAssetService.GetByPostIdAsync(postid,userlikescomments);
        }

    }
}
