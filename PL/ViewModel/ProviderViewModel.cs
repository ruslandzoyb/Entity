using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.ViewModel
{
   public class ProviderViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public virtual ICollection<ProductViewModel> Products { get; set; }
        public virtual ICollection<CategoryViewModel> Categories { get; set; }

        public ProviderViewModel()
        {
            Products = new List<ProductViewModel>();
            Categories = new List<CategoryViewModel>();
        }
    }
}
