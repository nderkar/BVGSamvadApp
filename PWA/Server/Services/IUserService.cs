using Samvad_App.Server.Models;
using Samvad_App.Shared.Models;

namespace Samvad_App.Server.Services
{
    public interface IUserService
    {
        Task<ApplicationUser> GetUserAsync(string userId);
        Task<bool> DeleteUser(string userId);
        Task<List<ApplicationUser>> GetAllUserAsync(UserSearchModel model,int page, int size);
        Task<List<ApplicationUser>> GetPostLikeByPostId(long postid,string userlikescomments);
    }
}
