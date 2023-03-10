using System.ComponentModel.DataAnnotations;

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
        //public PostModel currentPost { get; set; }
        //public UserModel user { get; }
    }
}
