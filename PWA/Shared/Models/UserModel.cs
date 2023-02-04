namespace Samvad_App.Shared.Models
{
	public class UserModel
	{
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ProfilePicture { get; set; }
        public bool IsAuthenticated { get; set; }
	}
}
