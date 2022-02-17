using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExamenSADE_SupleantuSara.Data;
using ExamenSADE_SupleantuSara.Models.LibraryViewModels;

namespace ExamenSADE_SupleantuSara.Controllers
{
    public class HomeController : Controller
    {
        private readonly StoreContext _context;
        public HomeController(StoreContext context)
        {
            _context = context;
        }
        public async Task<ActionResult> Statistics()
        {
            IQueryable<OrderGroup> data =
            from order in _context.Orders
            group order by order.OrderDate into dateGroup
            select new OrderGroup()
            {
                OrderDate = dateGroup.Key,
                ProductCount = dateGroup.Count()
            };
            return View(await data.AsNoTracking().ToListAsync());
        }

        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
