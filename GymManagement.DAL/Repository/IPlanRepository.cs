using MVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL.Repository
{
    public interface IPlanRepository
    {
        //Get All Plan :
        Task<IEnumerable<Plan>> GetAllPlanAsync(bool tracking = false, CancellationToken ct =default );

        //Get Plan By ID :
        Task<Plan?> GetByIdAsync(int id, CancellationToken ct = default);

        //Add 
        Task<int> AddAsync(Plan plan, CancellationToken ct = default);

        //Update 
        Task<int> UpdateAsync (Plan plan, CancellationToken ct = default);   

        //Delted 
        Task<int> DeltedAsync (Plan plan, CancellationToken ct = default);


    }
}
