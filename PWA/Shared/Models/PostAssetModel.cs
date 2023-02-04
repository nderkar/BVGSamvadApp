using System.ComponentModel.DataAnnotations;

namespace Samvad_App.Shared.Models
{
    public class PostAssetModel
    {
        public long assetid
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
        [Display(Name = "asseturl")]
        public string asseturl
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "assettype")]
        public string assettype
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
        public bool isdeleted
        {
            get;
            set;
        }
    }
}
