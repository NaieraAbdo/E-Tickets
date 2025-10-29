using E_Tickets.Data;
using E_Tickets.Data.Services;
using E_Tickets.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace E_Tickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService service;

        public ActorsController(IActorsService service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await service.GetAllAsync();
            return View(data);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
           await service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details (int id)
        {
            var actorDetails = await service.GetByIdAsync(id);
            if (actorDetails == null) return View("Empty");
            return View(actorDetails);
        }
    }
}
