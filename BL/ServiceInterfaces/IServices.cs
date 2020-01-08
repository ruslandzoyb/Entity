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
          IProductService Products { get;  }
         ICategoryService Categories { get;  }
         IProviderService Providers { get;  }
        
    }
}
