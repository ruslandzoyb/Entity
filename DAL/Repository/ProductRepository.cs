using DAL.Context;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
   public class ProductRepository : IRepository<Product>
    {
        private ProductContext db;

        public ProductRepository(ProductContext db)
        {
            this.db = db;
        }
        public void Create(Product item)
        {
            db.Products.Add(item);
        }

        public void Delete(int id)
        {
            Product product = db.Products.Find(id);
            if (product!=null)
            {
                db.Products.Remove(product);
            }
        }

      

        public Product GetElement(int? id)
        {
           return db.Products.Find(id);
        }

        public IEnumerable<Product> GetList()
        {

            return db.Products;
           

        }

       

        public void Update(Product item)
        {
           
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
