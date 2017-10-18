using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane.ORM.Datamodel
{
  public  class Books:Base
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int store { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public int writerID { get; set; }

        public virtual Writers writer { get; set; }
        
    }
}
