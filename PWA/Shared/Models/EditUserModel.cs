using System.ComponentModel.DataAnnotations;

namespace Samvad_App.Shared.Models
{
    public class EditUserModel
    {
        [DataType(DataType.Text)]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }


        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Required]
        public string UserRole { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Category")]
        public string Category { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }

    }
}
