using E_Tickets.Data;
using E_Tickets.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace E_Tickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService service;

        public ActorsController(IActorsService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            var data = service.GetAllAsync();
            return View(data);
        }
    }
}
