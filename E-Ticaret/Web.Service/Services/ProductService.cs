using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.DTO.Product;
using Web.ORM.Databaseclass;
using Web.Repository.Repository;
using Web;

namespace Web.Service.Services
{
    public class ProductService
    {
        public Entities ent = new Entities();
        ProductsRepository Product = new ProductsRepository();
        public ProductlistDTO Find(int id)
        { 
            Products  urun =Product.Bul(id);
ProductlistDTO Rproduct = new ProductlistDTO {

    ProductID = urun.ProductID,
    CategoryID = urun.CategoryID,
    name = urun.name,
    Description = urun.Description,
    Store = urun.Store,
    Price = urun.Price,
    discount_rate = urun.discount_rate,
    Cost = urun.Cost,
    İmageurl = urun.İmageurl



};
            return Rproduct;
        }
        public  IList<ProductlistDTO> GetAll()
        {

            return Product.GetAll().Where(x => (x.display == true)).Select(x => new ProductlistDTO {

                ProductID = x.ProductID,
                CategoryID = x.CategoryID,
                name = x.name,
                Description = x.Description,
                Store = x.Store,
                Price = x.Price,
                discount_rate = x.discount_rate,
                Cost = x.Cost,
                İmageurl = x.İmageurl



            }).ToList();


            
        }

        public  IList<ProductlistDTO> GetAll( int CategoryID)
        {

            return Product.GetAll().Where(x => (x.CategoryID == CategoryID)).Select(x => new ProductlistDTO
            {

                ProductID = x.ProductID,
                CategoryID = x.CategoryID,
                name = x.name,
                Description = x.Description,
                Store = x.Store,
                Price = x.Price,
                discount_rate = x.discount_rate,
                Cost = x.Cost,
                İmageurl = x.İmageurl



            }).ToList();
        }
        public void Add(ProductAddDTO Entty)
        {

            /* if (Entty.İmage!=null)
             {
                 Entty.İmage.SaveAs(Server.MapPath("~/Imj/Product/") + Entty.İmage.FileName);
             }*/


            /*   Products Products = new Products
               {
                   name = Entty.name,
                   CategoryID = Entty.CategoryID,
                   Store = Entty.Store,
                   Price = Entty.Price,
                   Cost = Entty.Cost,
                   Description = Entty.Description,
                   discount_rate = Entty.discount_rate,
                   İmageurl = Entty.İmage.FileName
               };*/
            Products product = new Products();
            product.CategoryID = Entty.CategoryID;
            product.Cost = Entty.Cost;
            product.Price = Entty.Price;
            product.İmageurl = null;
            product.discount_rate = 10;
            product.Description = Entty.Description;
            product.display = true;
            product.name = Entty.name;


            Product.ADD(product);

        }

        public void Delete(int id)
            {
            Product.Delete(id);

}
        public void update(ProductlistDTO urun)
        {
           Products entty=  Product.Bul(urun.ProductID);
            entty.name = urun.name;
            entty.CategoryID = urun.CategoryID;
            entty.Description = urun.Description;
            entty.discount_rate = urun.discount_rate;
            entty.İmageurl = urun.İmageurl;
            entty.Cost = urun.Cost;
            entty.Price = urun.Price;

            Product.Update(entty);

        }

    }
}
