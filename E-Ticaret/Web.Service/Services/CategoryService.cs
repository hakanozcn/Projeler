using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.ORM.Databaseclass;
using Web.Repository.Repository;
using Web.DTO.Category;
namespace Web.Service.Services
{
    public class CategoryService
    {
        private CategoriesRepository Categori = new CategoriesRepository();
        
        public IList<CategoryListODT> GetAll( )
            {


            return Categori.GetAll().Select(x => new CategoryListODT
            {
                
                ParentID =(int)x.ParentID,
                CategoryID = x.CategoryID,
                Name=x.Name,
               /*ParentName=Categori.Bul(Convert.ToInt32(x.ParentID)).Name*/

            }).ToList();
            
}
        public void  Add(CategoryAddODT Entty)
        {

            Categories category = new Categories {Name=Entty.Name,
            ParentID=Entty.ParentID};
            Categori.ADD(category);

        }
        public void Delete(int id)
        {
            Categori.Delete(id);
            
        }
        public CategoryListODT find(int id)
        {  Categories entty= Categori.Bul(id);

            return new CategoryListODT
            {
                
                Name = entty.Name,
                ParentID = (int)entty.ParentID,
                CategoryID = entty.CategoryID,
              /*  ParentName = Categori.Bul((int)entty.ParentID).Name*/

            };
        }
        
    }
}
