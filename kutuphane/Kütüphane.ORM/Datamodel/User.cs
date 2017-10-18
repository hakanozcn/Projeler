using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane.ORM.Datamodel
{
    public class User : Base
    {
        public string Name { get; set; }
     
        public String Email { get; set; }
        
        public string KULLANICIADI{get; set;}
       
        public string Password { get; set; }
        public virtual ICollection<Books> Books { get; set; }

    }
}
