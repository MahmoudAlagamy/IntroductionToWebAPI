using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntroductionToWebAPI.Models
{
    public class Book
    {
        [Required]
        [MaxLength(20, ErrorMessage = "Error > 20")]
        [MinLength(5, ErrorMessage = "Error < 5")]
        public string Title { get; set; }

        [Required]
        public int NumberOfPages { get; set; }
    }
}