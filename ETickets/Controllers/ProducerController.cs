using ETickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETickets.Controllers
{
    public class ProducerController : Controller
    {
        private readonly AppDbContext _context;

        public ProducerController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allProduysers = await _context.Producers.ToListAsync();
            return View(allProduysers);
        }
    }
}
