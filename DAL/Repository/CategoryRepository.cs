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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Category GetElement(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetList()
        {
            throw new NotImplementedException();
        }

       

        public void Update(Category item)
        {
            throw new NotImplementedException();
        }
    }
}
