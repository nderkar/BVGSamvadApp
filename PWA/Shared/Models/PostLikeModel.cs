using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Samvad_App.Shared.Models
{
    public class PostLikeModel
    {
        public long likeid
        {
            get;
            set;
        }
        [Required]
        public long postid
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "userid")]
        public string userid
        {
            get;
            set;
        }
        [Display(Name = "CreatedDate")]
        public DateTime createddate
        {
            get;
            set;
        }
    }
}
