using Samvad_App.Server.Models;
using Samvad_App.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Samvad_App.Server.Services;

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
	}
}
