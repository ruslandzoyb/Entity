using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ap.Models
{
    public class ProviderView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public virtual ICollection<ProductView> Products { get; set; }
        public virtual ICollection<CategoryView> Categories { get; set; }

        public ProviderView()
        {
            Products = new List<ProductView>();
            Categories = new List<CategoryView>();
        }

    }
}