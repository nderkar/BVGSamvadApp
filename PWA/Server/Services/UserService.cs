using Samvad_App.Server.Models;
using Samvad_App.Server.Repository;

namespace Samvad_App.Server.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<ApplicationUser> _user;
        public UserService(IRepository<ApplicationUser> user)
        {
            _user = user;
        }
        public async Task<ApplicationUser> GetUserAsync(string userId)
        {
            return await _user.GetByIdAsync(userId);
        }

    }
}
