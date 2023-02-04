using System.ComponentModel.DataAnnotations;

namespace Samvad_App.Shared.Models
{
    public class PostModel
    {
        public long postid
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "Message")]
        public string postmessage
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "CreatedBy")]
        public string createdby
        {
            get;
            set;
        }
        [Display(Name = "CreatedDate")]
        public DateTime createdate
        {
            get;
            set;
        }
        [Display(Name = "ModifiedBy")]
        public string modifiedby
        {
            get;
            set;
        }
        [Display(Name = "ModifiedDate")]
        public DateTime modifieddate
        {
            get;
            set;
        }
        [Display(Name = "LikeCount")]
        public int likecount
        {
            get;
            set;
        }
        [Display(Name = "CommentCount")]
        public int commentcount
        {
            get;
            set;
        }
        [Display(Name = "extlink1")]
        public string extlink1
        {
            get;
            set;
        }
        [Display(Name = "extlink2")]
        public string extlink2
        {
            get;
            set;
        }
        public bool isdeleted
        {
            get;
            set;
        }
        
    }
}
