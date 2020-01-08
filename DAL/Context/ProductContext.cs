using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Model;

namespace DAL.Context
{
    public class ProductContext:DbContext
    {
        public ProductContext(): base("DBConnection")
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Provider> Providers { get; set; }


        
        /*static ProductContext()
        {
            Database.SetInitializer<ProductContext>(new MyContextInitializer());
        }*/
    }
    class MyContextInitializer : DropCreateDatabaseAlways<ProductContext>
    { }
    }
