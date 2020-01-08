using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ap.Models
{
    public class ProductView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        
             public CategoryView Category { get; set; }
        public ProviderView Provider { get; set; }

        public ProductView()
        {
            Category = new CategoryView();
            Provider = new ProviderView ();
        }
    
    }
}