using Microsoft.AspNetCore.Mvc;
using Mission6_Roney.Models;

namespace Mission6_Roney.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: AddMovie
        
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        // POST: AddMovie
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return RedirectToAction("MovieList"); // Redirect to a movie list page after adding
            }

            return View(movie); // Return to form if invalid
        }

        // GET: MovieList (To check if movies were added)
        public IActionResult MovieList()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }
    }
}