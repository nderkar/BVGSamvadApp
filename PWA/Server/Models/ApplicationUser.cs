using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Samvad_App.Server.Models
{
	public class ApplicationUser : IdentityUser
	{
        public override string Id { get; set; }
        public string FirstName { get; set; }
		public string LastName { get; set; }
		public string ProfilePicture { get; set; }
        public string CustomClaim { get; set; }
		public string Notes { get; set; }
        public string Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public override string PhoneNumber { get; set; }
    }
}
