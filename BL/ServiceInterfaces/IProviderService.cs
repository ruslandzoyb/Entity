using BL.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ServiceInterfaces
{
   public interface IProviderService: IService<ProviderDTO>
    {
        IEnumerable<ProviderDTO> GetProviderByCat(CategoryDTO category);
        IEnumerable<ProviderDTO> GetProviderByCity(string city);
    }
}
