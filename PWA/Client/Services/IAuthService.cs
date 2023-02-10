using Samvad_App.Shared.Models;

namespace Samvad_App.Client.Services
{
	public interface IAuthService
	{
		Task<LoginResult> Login(LoginModel loginModel);
		Task<RegisterResult> Register(RegisterModel registerModel);
        Task<RegisterResult> ChabgePassword(RegisterModel registerModel);
        Task Logout();
	}
}
