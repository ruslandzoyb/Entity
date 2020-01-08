using DAL.Context;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
   public class CategoryRepository : IRepository<Category>
    {
        private ProductContext db;


        public CategoryRepository(ProductContext db)
        {
            this.db = db;
        }
        public void Create(Category item)
        {
            db.Categories.Add(item);
        }

        public void Delete(int id)
        {
            var cat = db.Categories.Find(id);

            db.Categories.Remove(cat);
        }

       

        public Category GetElement(int? id)
        {
            return db.Categories.Find(id);
        }

        public IEnumerable<Category> GetList()
        {
            return db.Categories.ToList();
        }

        

        public void Update(Category item)
        {
          //  throw new NotImplementedException();
        }
    }
}
