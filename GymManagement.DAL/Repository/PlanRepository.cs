using Microsoft.EntityFrameworkCore;
using MVC1.Context;
using MVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL.Repository
{
    public class PlanRepository : IPlanRepository
    {
        //1 -- Conection DataBase 
        private readonly GymDbContext context;
        public PlanRepository(GymDbContext context)
        {
            this.context = context;
        }

        public async Task<int> AddAsync(Plan plan, CancellationToken ct = default)
        {
            context.Plans.Add(plan);
            return await context.SaveChangesAsync(ct);
        }

        public async Task<int> DeltedAsync(Plan plan, CancellationToken ct = default)
        {
            context.Plans.Remove(plan);
            return await context.SaveChangesAsync(ct);
        }

        public async Task<IEnumerable<Plan>> GetAllPlanAsync(bool tracking = false, CancellationToken ct = default)
        {
            // if (tracking) //true 

            //   return await context.Plans.ToListAsync(ct);  

            // else //fale 

            //   return await context.Plans.AsNoTracking().ToListAsync(ct);
                                             //True               //False
            IQueryable<Plan> query = tracking ? context.Plans : context.Plans.AsNoTracking();
            return await query.ToListAsync(ct);
        }

        public async Task<Plan?> GetByIdAsync(int id, CancellationToken ct = default)
        {
            return await context.Plans.FindAsync(id, ct);
        }

        public async Task<int> UpdateAsync(Plan plan, CancellationToken ct = default)
        {
            context.Plans.Update(plan);
            return await context.SaveChangesAsync(ct);
        }
    }
}
