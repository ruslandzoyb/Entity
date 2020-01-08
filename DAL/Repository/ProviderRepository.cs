using DAL.Context;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
   public class ProviderRepository : IRepository<Provider>
    {
        private ProductContext db;
        public ProviderRepository(ProductContext db)
        {
            this.db = db;
        }
        public void Create(Provider item)
        {
            db.Providers.Add(item);
        }

        public void Delete(int id)
        {
            var pr = db.Providers.Find(id);
            if (pr!=null)
            {
                db.Providers.Remove(pr);
            }
        }

        

        public Provider GetElement(int? id)
        {
            return db.Providers.Find(id);
           
        }

        public IEnumerable<Provider> GetList()
        {
            return db.Providers.ToList();
        }

       



        public void Update(Provider item)
        {
            //throw new NotImplementedException();
        }
    }
}
