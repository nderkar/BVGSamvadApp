using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Samvad_App.Shared.Models
{
    public class EmployeeModel
    {
        public int Id
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "Email")]
        public string Email
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "Mobile Number")]
        public string MobileNo
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "Address")]
        public string Address
        {
            get;
            set;
        }
    }
}
