    using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace websitedb.data.dataclass
{
    public class wcontext:DbContext
    {
        

        public wcontext(): base("dbconnection")
        {

            

        }

        public DbSet<category> Category { get; set; }
        public DbSet<blogger> Blogger { get; set; }
        public DbSet<slider> Slider { get; set; }
        public DbSet<duyulular> Duyulular { get; set; }
        public DbSet<etkinlik> Etkinlik { get; set; }
        public DbSet<yazi> Yazilar { get; set; }



    }
}
