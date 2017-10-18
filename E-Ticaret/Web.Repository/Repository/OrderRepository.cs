using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.ORM.Databaseclass;

namespace Web.Repository.Repository
{
  public  class OrderRepository:RepositoryBase<Order>
    {

        public IList<Orderdetail> DETAIL(int id)
        {

            
            return Entity.Orderdetail.Where(x => (x.OrderID ==id)).ToList();
        }

    }
}
