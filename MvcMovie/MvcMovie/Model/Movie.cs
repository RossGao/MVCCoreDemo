using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 180)]
        [DataType(DataType.Currency)]       // DataType is not validation condition but provided more specific info about the property type and html can generate extral tags(attributes) for it.
        public decimal Price { get; set; }

        [RegularExpression(@"(a|b|c)+")]    // Include all string with no symbol other than 'a','b','c', such as aaa, abc, a,b,c
        [StringLength(3, MinimumLength = 1)]
        [Required]
        public string Rating { get; set; }
    }
}