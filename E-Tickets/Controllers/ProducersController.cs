using E_Tickets.Data;
using E_Tickets.Data.Services;
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
    }
}
