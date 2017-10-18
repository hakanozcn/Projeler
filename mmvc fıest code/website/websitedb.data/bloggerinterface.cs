using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace websitedb.data
{
     public interface bloggerinterface
    {
       

        string Name { get; set; }

        string Username { get; set; }
        DateTime Createtime { get; set; }
        DateTime Lastaktivetime { get; set; }
        
    }
}
