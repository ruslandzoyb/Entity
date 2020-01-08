using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Interface
{
   public interface IController<T> where T:class
    {
        void Put(T item);
        void Get(int id);
        void Delete(int id);
        IEnumerable<T> GetList();
        void Update(T item);
    }
}
