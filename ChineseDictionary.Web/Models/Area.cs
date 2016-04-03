using System.ComponentModel.DataAnnotations;

namespace ChineseDictionary.Web.Models
{
    public class Area
    {
        public int AreaId { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
