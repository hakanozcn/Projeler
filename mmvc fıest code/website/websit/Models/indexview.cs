using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using websitedb.data.dataclass;

namespace websit.Models
{
    public class İndexview:Categoryview
    {
        public List<yazi> Yazilar { get; set; }
        public List<slider> Slider { get; set; }
        public List<duyulular> Duyulular { get; set; }
        public List<etkinlik> Etkinlik { get; set; }
    }
}