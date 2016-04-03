using System.ComponentModel.DataAnnotations;

namespace ChineseDictionary.Web.Models
{
    public class Consonant
    {
        public int ConsonantId { get; set; }
        [Required]
        [MaxLength(5)]
        public string Name { get; set; }
    }
}
