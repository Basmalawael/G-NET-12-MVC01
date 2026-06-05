using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL.Models
{
    internal class Category : BaseEntity //Id , CreatedAt , UpdatedAt 
    {
        public string CategoryName { get; set; }    

    }
}
