using System;
using System.Collections.Generic;
using System.Web;

namespace websitedb.data.dataclass
{
   public  class blogger:baseclass,bloggerinterface
    {
       
        

       public string İmg { get; set; }

       public string Cv { get; set; }

       public string Name { get; set; }

       public   string Username { get; set; }

       public  string Password { get; set; }
        
       public string Email { get; set; }

       public   DateTime Createtime { get; set; }

       public  DateTime Lastaktivetime { get; set; }

       public string Description { get; set; }

       public virtual ICollection<category> Categories { get; set; }
        public virtual ICollection<yazi> Yazilar { get; set; }
        public virtual ICollection<etkinlik> Etkinlikler { get; set; }
        public virtual ICollection<duyulular> Duyulular { get; set; }

    }
}
