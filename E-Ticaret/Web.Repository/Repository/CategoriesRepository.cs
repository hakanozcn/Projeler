using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.ORM.Databaseclass;

namespace Web.Repository.Repository
{
 public   class CategoriesRepository:RepositoryBase<Categories>
    {

        public override void Delete(int id)
        {
          /*foreach(var item in  Entity.Categories.Where(x => (x.ParentID == id)).ToList())
            {
                item.ParentID = null;
                Entity.Entry(item).State= System.Data.Entity.EntityState.Modified;

                Entity.SaveChanges();
            }
           foreach (var item in Entity.Products.Where(x => (x.CategoryID ==id)).ToList())
            {
                item.CategoryID = null;
                Entity.Entry(item).State = System.Data.Entity.EntityState.Modified;

                Entity.SaveChanges();

            }*/


            Entity.SaveChanges();
            Entity.Products.RemoveRange(Entity.Products.Where(x => (x.CategoryID == id)).ToList());
            base.Delete(id);
        }
    }

}
