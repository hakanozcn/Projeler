using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using websitedb.data.dataclass;

namespace websit.Models
{
    public class Makaleview:Categoryview
    {
        public string catogryidstring { get; set; }
        public List<yazi> Makaleler { get; set; }

        public HttpPostedFileBase file { get; set; }
    }
}