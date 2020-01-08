using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ModelsDTO
{
   public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  virtual ICollection<ProductDTO> Products { get; set; }
        public virtual ICollection<ProviderDTO> Providers { get; set; }
        
    }
}
