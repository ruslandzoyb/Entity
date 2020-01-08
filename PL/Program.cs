using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Services;
using BL.ModelsDTO;
using System.Data.Entity;
using PL.Controller;
using PL.ViewModel;


namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductController productController = new ProductController(new BL.Services.ProductService());
            var c= productController.GetList();

            Console.WriteLine("kus");

            Console.ReadLine();
        }
    }
}
