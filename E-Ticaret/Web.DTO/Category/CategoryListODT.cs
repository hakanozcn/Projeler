using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.DTO.Category
{
  public   class CategoryListODT
    { 
        public int CategoryID { get; set; }
        public int ParentID { get; set; }
        public string ParentName { get; set; }
        public string Name { get; set; }
    }
}
