using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace websitedb.data.dataclass
{
    public class duyulular: baseclass
    {
        public virtual blogger BloggeID { get; set; }
 
        public int Blogerid { get; set; }

        public  string Title { get; set; }

        public string Description { get; set; }

        public    DateTime  Updatetime { get; set; }


    }
}
