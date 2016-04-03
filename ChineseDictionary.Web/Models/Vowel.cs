using System.ComponentModel.DataAnnotations;

namespace ChineseDictionary.Web.Models
{
    public class Vowel
    {
        public int VowelId { get; set; }
        [Required]
        [MaxLength(5)]
        public string Name { get; set; }
    }
}
