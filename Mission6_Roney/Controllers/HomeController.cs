using Microsoft.AspNetCore.Mvc;
using Mission6_Roney.Models;
using Microsoft.EntityFrameworkCore;

namespace Mission6_Roney.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GetToKnowJoel()
    {
        return View();
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