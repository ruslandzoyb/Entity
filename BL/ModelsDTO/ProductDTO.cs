using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ModelsDTO
{
  public  class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public DateTime TimeCreation { get; private set; }
        public CategoryDTO Category { get; set; }
        public ProviderDTO Provider { get; set; }
    
        public ProductDTO()
        {
            TimeCreation = DateTime.Now;
        }


    }
}
