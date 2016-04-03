using System.ComponentModel.DataAnnotations;

namespace ChineseDictionary.Web.Models
{
    public class ToneType
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string Name { get; set; }
    }
}
