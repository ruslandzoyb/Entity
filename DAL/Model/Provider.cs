﻿using System;
using System.Collections.Generic;
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
        public List<Product> Products { get; set; }


    }
}
