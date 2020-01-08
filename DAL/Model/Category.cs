using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
   public class Category
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual  ICollection<Product> Products { get; set; }
        public virtual ICollection<Provider> Providers { get; set; }

        public Category()
        {
            Products = new List<Product>();
            Providers = new List<Provider>();
        }
    }
}
