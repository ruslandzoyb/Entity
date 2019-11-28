using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
  public  class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public DateTime TimeCreation { get; set; }
        public Category Category { get; set; }
        public Provider Provider { get; set; }

        public Product()
        {
            //TimeCreation = DateTime.Now;

        }

    }
}
