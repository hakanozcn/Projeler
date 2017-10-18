using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.ORM.Databaseclass;

namespace Web.DTO.Category
{
   public  class CategoryAddODT
    {
        public Nullable<int> ParentID { get; set; }
        public string Name { get; set; }
        
    }
}
