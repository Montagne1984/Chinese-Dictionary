using System.ComponentModel.DataAnnotations;

namespace ChineseDictionary.Web.Models
{
    public class Consonant
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(5)]
        public string Name { get; set; }
    }
}
