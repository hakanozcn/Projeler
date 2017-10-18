using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.DTO.Product
{
   public class ProductlistDTO
    {
        public int ProductID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string name { get; set; }
        public string Description { get; set; }
        public Nullable<int> Store { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> Cost { get; set; }
        public Nullable<int> discount_rate { get; set; }
        
        public string İmageurl { get; set; }

    }
}
