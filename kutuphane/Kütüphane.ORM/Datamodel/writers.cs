using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane.ORM.Datamodel
{
 public   class Writers
    {
     public string Name { get; set; }
     public string Surname { get; set; }
     public virtual ICollection<Books> Books { get; set; }
     
    }
}
