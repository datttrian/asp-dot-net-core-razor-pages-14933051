using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Data.Models;

namespace MyApp.Namespace
{
    public class MoviesModel : PageModel
    {
        public List<Movie> Movies { get; set; }
        public void OnGet()
        {
            Movies = _context.Movies.ToList();
        }
    }
}
