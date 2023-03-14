using ETickets.Data;
using Microsoft.AspNetCore.Mvc;

namespace ETickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {
            _context = context;
        }

        AppDbContext context = new AppDbContext();  
        public IActionResult Index()
        {
            var date = _context.actors.ToList();
            return View(date);
        }

    }
}
