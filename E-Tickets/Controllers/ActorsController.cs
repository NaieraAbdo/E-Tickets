using E_Tickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace E_Tickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext context;

        public ActorsController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var data = context.Actors.ToList();
            return View(data);
        }
    }
}
