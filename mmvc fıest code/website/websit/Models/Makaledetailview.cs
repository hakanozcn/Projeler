using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using websitedb.data.dataclass;

namespace websit.Models
{
    public class Makaledetailview:Categoryview
    {
        public yazi Makale { get; set; }
        public blogger Blogers { get; set; }
    }


}