using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Web.ORM;
using Web.ORM.Databaseclass;

namespace Web.Repository.Repository
{
   public class RepositoryBase<T> where T :class
    {

        public Entities Entity = new Entities();
        
        public T Bul(int id)
        {
           return Entity.Set<T>().Find(id);
        }


        public IList<T> GetAll()
        {

            return Entity.Set<T>().ToList();
        }
        
        public void ADD(T Entty)
        {
           Entity.Set<T>().Add(Entty);
           Entity.SaveChanges();
           Entity = new Entities();
        }
        public virtual void Delete(int id)
        {
            T entty = Entity.Set<T>().Find(id);
            Entity.Set<T>().Remove(entty);
            Entity.SaveChanges();
            Entity = new Entities();
        }
        public  void Update(T Entty)

        {
            
            Entity.Entry(Entty).State = System.Data.Entity.EntityState.Modified;
            Entity.SaveChanges();
        }
        public void Dispose()
        {
            if (Entity != null)
            {
                Entity.Dispose();
                Entity = null;
            }
            GC.SuppressFinalize(this);
        }


    }
}
