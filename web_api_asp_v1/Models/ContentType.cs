using System.ComponentModel.DataAnnotations;
namespace web_api_asp_v1.Models
{
    public class ContentType
    {
        public int ContentTypeID { get; set; }
        [Required]
        [StringLength(50)]
        public string TypeName { get; set; }
    }
}
