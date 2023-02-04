using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Samvad_App.Server.Models
{
    [Table("PostLike", Schema = "dbo")]
    public class PostLike
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long likeid { get; set; }
        [Required]
        public long postid { get; set; }
        [Required]
        public string userid { get; set; }
        public DateTime createddate { get; set; }
    }
}
