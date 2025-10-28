using E_Tickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace E_Tickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext context;

        public MoviesController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var allMovies = context.Movies.ToList();
            return View(allMovies);
        }
    }
}
