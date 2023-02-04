using System.ComponentModel.DataAnnotations;

namespace Samvad_App.Shared.Models
{
	public class LoginModel
	{
		[Required]
		public string Email { get; set; }

		[Required]
		public string Password { get; set; }

		public bool RememberMe { get; set; }
	}
}
