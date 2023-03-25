using Samvad_App.Shared.Models;

namespace Samvad_App.Client.Services
{
	public interface IAuthService
	{
		Task<LoginResult> Login(LoginModel loginModel);
		Task<RegisterResult> Register(RegisterModel registerModel);
		Task<RegisterResult> UpdateUser(EditUserModel editUserModel);
        Task<RegisterResult> UpdateUserAvatar(UserModel userModel);
        Task<ChangePasswordResult> ChangePassword(ChangePasswordModel changePasswordModel);
        Task<ChangePasswordResult> ChangeUserPassword(ChangeUserPasswordModel changeUserPasswordModel);
        Task Logout();
	}
}
