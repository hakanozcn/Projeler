using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace websitedb.data.dataclass
{
  public  class yazi:baseclass
    {

        public string img { get; set; }
        public string Baslik { get; set; }
        public string İcerik { get; set; }
        public virtual blogger bloggerID { get; set; }
        public int BlogerID { get; set; }
        public virtual category CategoryID { get; set; }
        public int CategoryiD { get; set; }
        public DateTime Updatetime { get; set; }
    }
}
