using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Samvad_App.Server.Models
{
    [Table("PostComment", Schema = "dbo")]
    public class PostComment
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long commentid { get; set; }
        [Required]
        public string userid { get; set; }
        public DateTime createddate { get; set; }
        [Required]
        public long postid { get; set; }
        [Required]
        public string comment { get; set; }
        public DateTime modifieddate { get; set; }
        public bool isdeleted { get; set; }
    }
}
