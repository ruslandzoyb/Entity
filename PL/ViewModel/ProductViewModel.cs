using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.ViewModel
{
  public  class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public  CategoryViewModel Category { get; set; }
        public  ProviderViewModel Provider { get; set; }

        //  public DateTime TimeCreation { get; set; }
        public ProductViewModel()
        {
            Category = new CategoryViewModel();
            Provider = new ProviderViewModel();
        }

    }
}
