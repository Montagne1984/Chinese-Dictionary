using System.ComponentModel.DataAnnotations;

namespace ChineseDictionary.Web.Models
{
    public class Area
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
