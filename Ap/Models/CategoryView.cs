using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ap.Models
{
    public class CategoryView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ProductView> Products { get; set; }
        public virtual ICollection<ProviderView> Providers { get; set; }

        public CategoryView()
        {
            Products = new List<ProductView>();
            Providers = new List<ProviderView>();
        }
    }
}