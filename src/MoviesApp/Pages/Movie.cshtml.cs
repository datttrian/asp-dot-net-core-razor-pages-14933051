using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Data;
using MoviesApp.Data.Models;

namespace MyApp.Namespace
{
    public class MovieModel : PageModel
    {
        // public int Id {get;set;}
        public Movie? Movie {get;set;}

        private ApplicationDbContext _context;
        public MovieModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet(int id)
        {
            Movie = _context.Movies.FirstOrDefault(n => n.Id == id);
        }
    }
}
