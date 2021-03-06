﻿using System.ComponentModel.DataAnnotations;

namespace ChineseDictionary.Models
{
    public class Vowel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(5)]
        public string Name { get; set; }
    }
}
