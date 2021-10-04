using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieReviewWebsite.Model;

namespace MovieReviewWebsite.Pages.MovieList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db) 
        {
            _db = db;
        }

        public IEnumerable<Movie> Movies { get; set; }

        public async Task OnGet()
        {
            Movies = await _db.Movie.ToListAsync(); //Going to DB and getting all the movies and storing that in the Ienumerable Movies in the get handler
        }
    }
}
