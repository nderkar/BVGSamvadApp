using Samvad_App.Server.Models;
using Samvad_App.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Samvad_App.Server.Services;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Manage.Internal;
using Samvad_App.Client.Pages;

namespace Samvad_App.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountsController : ControllerBase
	{
		private static readonly UserModel LoggedOutUser = new() { IsAuthenticated = false };

		private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
		private ApplicationUser currentUser = new ApplicationUser();
        private readonly IUserService _userService;
        public AccountsController(UserManager<ApplicationUser> userManager, 
			SignInManager<ApplicationUser> signInManager,
            IUserService userService)
		{
			_userManager = userManager;
            _signInManager = signInManager;
			_userService = userService;
        }
        [HttpGet]
        public async Task<ApplicationUser> GetUserDetails()
        {
			if(User.Identity.Name != null)
			{
                currentUser = await _signInManager.UserManager.FindByEmailAsync(User.Identity.Name);
            }
            
			return currentUser;
        }
        [HttpGet]
        [Route("userrole")]
        public async Task<IList<string>> GetUserRoles()
        {
            if (User.Identity.Name != null)
            {
                currentUser = await _signInManager.UserManager.FindByEmailAsync(User.Identity.Name);
            }

            return await _userManager.GetRolesAsync(currentUser);
        }
        [HttpGet("{id}")]
		public async Task<ApplicationUser> GetUserDetailsByUserId(string id)
		{
			return await _userService.GetUserAsync(id);

		}
        [HttpGet("{id}/{userlikescomments}")]
        public async Task<List<ApplicationUser>> Get(long id,string userlikescomments)
        {
            return await _userService.GetPostLikeByPostId(id, userlikescomments);
        }
        [HttpPost]
		public async Task<IActionResult> Post([FromBody] RegisterModel model)
		{
			var newUser = new ApplicationUser
			{
				UserName = model.Email,
				Email = model.Email,
				FirstName = model.FirstName,
				LastName = model.LastName
			};

			var result = await _userManager.CreateAsync(newUser, model.Password);

			if (!result.Succeeded)
			{
				var errors = result.Errors.Select(x => x.Description);

				return BadRequest(new RegisterResult { Successful = false, Errors = errors });
			}

			// Add all new users to the User role
			await _userManager.AddToRoleAsync(newUser, "User");

            // Add new users whose email starts with 'admin' to the Admin role
            //if (newUser.Email.StartsWith("admin"))
            if (model.UserRole == "Admin")
            {
				await _userManager.AddToRoleAsync(newUser, "Admin");
            }

			return Ok(new RegisterResult { Successful = true });
		}
        [HttpPost]
        [Route("changepassword")]
        public async Task<IActionResult> Put([FromBody] Shared.Models.ChangePasswordModel model)
        {
            
            if (User.Identity.Name != null)
            {
                currentUser = await _signInManager.UserManager.FindByEmailAsync(User.Identity.Name);
            }
            var resultCheck = await _signInManager.PasswordSignInAsync(currentUser.Email, model.OldPassword, false, false);

            if (!resultCheck.Succeeded)
            {
                return BadRequest(new ChangePasswordResult { Successful = false, Error = "Username and password are invalid." });
            }
           
            var result = await _userManager.ChangePasswordAsync(currentUser, model.OldPassword,model.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description);

                return BadRequest(new ChangePasswordResult { Successful = false, Errors = errors });
            }


            return Ok(new ChangePasswordResult { Successful = true });
        }
    }
}
