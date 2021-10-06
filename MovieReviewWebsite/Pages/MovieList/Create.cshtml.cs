using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieReviewWebsite.Model;

namespace MovieReviewWebsite.Pages.MovieList
{
    public class CreateModel : PageModel
    {
        //Saving to database when button hit
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db) //Constructor
        {
            _db = db;
        }

        [BindProperty]   //Allows me to automatically assume that I can get this movie in the OnPost later
        public Movie Movie { get; set; }
  
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost() 
        {
            if (ModelState.IsValid) 
            {
                await _db.Movie.AddAsync(Movie);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else 
            {
                return Page();
            }
        }
    }
}
