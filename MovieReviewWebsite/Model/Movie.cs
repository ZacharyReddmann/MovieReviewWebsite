using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieReviewWebsite.Model
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required] //Display attribute requiring name to not be null
        public string Name { get; set; }
        public string Author { get; set; }
        //Github Test
    }
}
