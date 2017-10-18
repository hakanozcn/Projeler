using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace websitedb.data.dataclass
{
   public  class etkinlik:baseclass
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Updatetime { get; set; }

        public DateTime Time { get; set; }

        public virtual blogger BloggerID { get; set; }

        public int Blogerid { get; set; }
    }
}
