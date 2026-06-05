using GymManagement.DAL.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC1.Context;
using System.Threading.Tasks;

namespace MVC1.Controllers
{
    public class PlanController : Controller 
    {
        private readonly IPlanRepository planRepos;
        public PlanController(IPlanRepository planRepository)
        {
            planRepos = planRepository;
        }



        //Get :: URL / Plan / Index 

        public async Task<IActionResult> Index(CancellationToken ct )
        {
            var plans = await planRepos.GetAllPlanAsync(ct : ct);
            return View(plans);
        }

        // Get :: URL /Plan / Details / {id}
        public async Task<IActionResult> Details(int id , CancellationToken ct)
        {
            var plan = await planRepos.GetByIdAsync(id, ct); 
            
            if (plan == null)
                return  RedirectToAction(nameof(Index));
              
            return View(plan);
        }


    }
}
