using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Data.Models;
using MoviesApp.Data;

namespace MyApp.Namespace
{
    public class AddMovieModel : PageModel
    {
        [BindProperty]
        public string Title { get; set; }
        [BindProperty]
        public int Rate { get; set; }
        [BindProperty]
        public string Description { get; set; }
        // [BindProperty]
        // public Movie Movie {get;set;}
        // public void OnGetMyOnClick()
        // {
        //     string stopHere = "";
        // }

        private ApplicationDbContext _context;
        public AddMovie(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            // Title = "Welcome";
        }

        public IActionResult OnPost()
        {
            // string value = $"{Title} - {Rate} - {Description}";
            // string value = $"{Movie.Title} - {Movie.Rate} - {Movie.Description}";

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var movie = new Movie()
            {
                Title = Title;
                Rate = Rate;
                Description = Description
            }
            _context.Movies.Add(movie);
            _context.SaveChanges();
            // return Page();
            return Redirect("Movies");
        }
    }
}
