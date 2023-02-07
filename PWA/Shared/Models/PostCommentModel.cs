using System.ComponentModel.DataAnnotations;

namespace Samvad_App.Shared.Models
{
    public class PostCommentModel
    {
        public long commentid
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
        [Display(Name = "Comment")]
        public string comment { get; set; }
        [Display(Name = "ModifiedDate")]
        public DateTime modifieddate
        {
            get;
            set;
        }
        public bool isdeleted { get; set; }
    }
}
