using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ServiceInterfaces
{
   public interface IService<T>:IDisposable
        where T:class
    {
        IEnumerable<T> GetList();
        T GetElement(int ?id);
        void Create(T item);
        void Update(T item);
        void Delete( int id);

       
    }
}
