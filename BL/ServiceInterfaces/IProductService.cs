using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.ModelsDTO;

namespace BL.ServiceInterfaces
{
   public interface IProductService:IService<ProductDTO>
    {
        IEnumerable<ProductDTO> GetByCategory(CategoryDTO category);
        IEnumerable<ProductDTO> GetByProvider(ProviderDTO provider );
        IEnumerable<ProductDTO> GetByPrice(double price);
        ProductDTO ProductMax();
        ProductDTO ProductMin();

    }
}
