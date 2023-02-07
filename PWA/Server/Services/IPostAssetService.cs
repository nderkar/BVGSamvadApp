using Samvad_App.Server.Models;

namespace Samvad_App.Server.Services
{
    public interface IPostAssetService
    {
        Task<PostAsset> AddPostAsset(PostAsset Postasset);
        Task<PostAsset> GetPostAssetsByAssetId(long assetid);
        Task<List<PostAsset>> GetPostAssetsByPostId(long postid, string userlikescomments);
    }
}
