using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;
using DAL.Model;

namespace DAL.UOW
{
   public interface IUnitOfWork
    {
         IRepository<Product> Products { get;  }
        IRepository<Category> Categories { get;  }
        IRepository<Provider> Providers { get; }
        void Save();

    }
}
