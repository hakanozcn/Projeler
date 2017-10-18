using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace websitedb.data.dataclass
{
  public  class  category:baseclass

    {
        public string Categoryname { get; set; }
        public virtual ICollection<blogger> Bloggers { get; set; }
        public virtual ICollection<yazi> Yazilar { get; set; }
    }
}
