using Samvad_App.Server.Models;

namespace Samvad_App.Server.Services
{
    public interface IUserService
    {
        Task<ApplicationUser> GetUserAsync(string userId);
        Task<List<ApplicationUser>> GetPostLikeByPostId(long postid,string userlikescomments);
    }
}
