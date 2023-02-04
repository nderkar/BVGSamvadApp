﻿using Microsoft.AspNetCore.Identity;
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
	}
}