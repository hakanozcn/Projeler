using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.ORM.Databaseclass;

namespace Web.Repository.Repository
{
   public class CustomerRepository:RepositoryBase<Customer>
    {

        public IList<Order> OrderList(int id)
        {
            Customer Customer = Entity.Customer.Find(id);

            return Entity.Order.Where(x => (x.CustomerID == Customer.CustomerID)).ToList();


        }


    }
}
