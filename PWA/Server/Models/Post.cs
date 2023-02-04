using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Samvad_App.Server.Models
{
    [Table("Post", Schema = "dbo")]
    public class Post
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long postid { get; set; }
        [Required]
        public string postmessage { get; set; }
        [Required]
        public string createdby { get; set; }
        public DateTime createdate { get; set; }
        public string modifiedby { get; set; }       
        public DateTime modifieddate { get; set; }
        public int likecount { get; set; }
        public int commentcount { get; set; }
        public string extlink1 { get; set; }
        public string extlink2 { get; set; }
        public bool isdeleted { get; set; }
        //public IList<Comments>
    }
}
