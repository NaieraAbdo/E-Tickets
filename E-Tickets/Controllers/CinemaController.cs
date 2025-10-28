using E_Tickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace E_Tickets.Controllers
{
    public class CinemaController : Controller
    {
        private readonly AppDbContext context;

        public CinemaController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var allCinemas = context.Cinemas.ToList();
            return View(allCinemas);
        }
    }
}
