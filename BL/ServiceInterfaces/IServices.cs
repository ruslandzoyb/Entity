using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Services;
namespace BL.ServiceInterfaces
{
   public interface IServices
    {
          ProductService Products { get;  }
         CategoryService Categories { get;  }
         ProviderService Providers { get;  }
        
    }
}
