using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
   public class Provider
    {
        
      
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Category> Categories { get; set; }

        public Provider()
        {
            Products = new List<Product>();
            Categories = new List<Category>();
        }
      //  public virtual ICollection<Category> Categories { get; set; }
        //public List<Product> Products { get; set; }


    }
}
