using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Samvad_App.Server.Models
{
    [Table("PostAsset", Schema = "dbo")]
    public class PostAsset
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long assetid { get; set; }
        [Required]
        public long postid { get; set; }
        [Required]
        public string asseturl { get; set; }
        [Required]
        public string assettype { get; set; }
        public DateTime createddate { get; set; }
        public bool isdeleted { get; set; }
    }
}
