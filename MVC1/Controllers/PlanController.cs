using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC1.Context;
using System.Threading.Tasks;

namespace MVC1.Controllers
{
    public class PlanController : Controller 
    {
        private readonly GymDbContext _context;

        public PlanController(GymDbContext context)

        {
            _context = context; 
        }

        //Get :: URL / Plan / Index 

        public async Task<IActionResult> Index()
        {
            var plans = await _context.Plans.ToListAsync();
            return View(plans);
        }

        // Get :: URL /Plan / Details / {id}
        public async Task<IActionResult> Details(int id)
        {
            var plan = await _context.Plans.FindAsync(id);
            
            if (plan == null)
                return  RedirectToAction(nameof(Index));
              
            return View(plan);
        }


    }
}
