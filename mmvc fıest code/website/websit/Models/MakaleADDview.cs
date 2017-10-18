using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using websitedb.data.dataclass;

namespace websit.Models
{
    public class MakaleADDview:Categoryview

    {
        public HttpPostedFileBase file { get; set; }
        public string Baslik { get; set; }
        public string İcerik { get; set; }
        public string CategoryiD { get; set; }
        public int blogerID { get; set; }

    }


}