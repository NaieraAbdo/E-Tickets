using E_Tickets.Data;
using E_Tickets.Data.Services;
using E_Tickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace E_Tickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService service;

        public ProducersController(IProducersService service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await service.GetAllAsync();
            return View(allProducers);
        }

        //GET: producers/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("PictureURL,Bio,FullName")]Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            await service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var ProducerDetails = await service.GetByIdAsync(id);
            if (ProducerDetails is null) return View("NotFound");
            return View(ProducerDetails);
        }

        //GET: producers/edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await service.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProfilePictureURL,FullName,Bio")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);

            if (id == producer.Id)
            {
                await service.UpdateAsync(producer, id);
                return RedirectToAction(nameof(Index));
            }
            return View(producer);
        }


    }
}
