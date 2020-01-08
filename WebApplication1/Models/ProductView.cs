using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ProductView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        //public CategoryViewModel Category { get; set; }
        //public ProviderViewModel Provider { get; set; }

        //  public DateTime TimeCreation { get; set; }
        public ProductView()
        {
            //Category = new CategoryViewModel();
            //Provider = new ProviderViewModel();
        }
    }
}