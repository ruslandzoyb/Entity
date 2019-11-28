using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;
using DAL.Context;
using DAL.Model;

namespace DAL.UOW
{
   public class UnitOfWork :IUnitOfWork
    {
        private CategoryRepository categoryRepository;
        private ProductRepository productRepository;
        private ProviderRepository providerRepository;

        private ProductContext db;
        public UnitOfWork()
        {
            this.db = new ProductContext();
        }
       
      /*  public ProductRepository Products
        {
            get
            {
                if (categoryRepository == null)
                {
                    productRepository = new ProductRepository(db);
                }
                return productRepository;
            }
        }*/

     

      public  IRepository<Product> Products
        {
            get
            {
                if (categoryRepository == null)
                {
                    productRepository = new ProductRepository(db);
                }
                return productRepository;
            }
        }

        public IRepository<Category> Categories
        {
            get
            {
                if (categoryRepository == null)
                {
                    categoryRepository = new CategoryRepository(db);
                }
                return categoryRepository;
            }
        }

        public IRepository<Provider> Providers
        {
            get
            {
                if (providerRepository==null)
                {
                    providerRepository = new ProviderRepository(db);
                }
                return providerRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
