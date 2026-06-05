using GymManagement.DAL.Models.@enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL.Models
{
    public class Trainer : GymUser //Id CreatedAt UpdatedAt Name Email Phone DateOfB Address 
    {
          //HireDate == CreatedAt
          public Specialty Specialty { get; set; }

    }
}
