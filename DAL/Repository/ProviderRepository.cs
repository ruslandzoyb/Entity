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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
         
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Provider GetElement(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Provider> GetList()
        {
            throw new NotImplementedException();
        }

       

        public void Update(Provider item)
        {
            throw new NotImplementedException();
        }
    }
}
