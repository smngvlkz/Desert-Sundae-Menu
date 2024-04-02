using Microsoft.AspNetCore.Mvc;
using Menu.Data;
using Menu.Models;
using Microsoft.EntityFrameworkCore;

namespace Menu.Controllers
{
    public class Menu : Controller
    {
        private readonly MenuContext _context;
        public Menu(MenuContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string searchString)
        {
            var Flavors = from f in _context.Flavor
                          select f;
            if(!string.IsNullOrEmpty(searchString))
            {
                Flavors = Flavors.Where(f => f.Name.Contains(searchString));
                return View(await Flavors.ToListAsync());
            }
            return View(await Flavors.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            var Flavors = await _context.Flavor
                .Include(fi => fi.FlavorIngredients)
                .ThenInclude(i => i.Ingredients)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (Flavors == null)
            {
                return NotFound();
            }
            return View(Flavors);
        }

    }
}
