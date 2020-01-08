using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL.Services;
using BL.ServiceInterfaces;
using BL.ModelsDTO;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Threading;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
   
    public class ProductController : ApiController
    {
   

       
        //[HttpGet]
        //public string GetStr()
        //{
        //    return "Bitch";
        //}
        [HttpGet]
        public HttpResponseMessage Get()
        {
            BL.Services.ProductService service = new ProductService();


            ProductDTO c = service.GetElement(1);
            ProductView productView = new ProductView()
            {
                Id = c.Id,
                Name = c.Name,
                Price = c.Price
            };
          //  List<ProductDTO> products = new List<ProductDTO>();
          //var pr= new ProductDTO()
          //  {
          //      Name = "Soska",
          //      Price = 300
          //  };
          //  var pr1 = new ProductDTO()
          //  {
          //      Name = "vsvsdv",
          //      Price = 3500
          //  };
          //  var pr2 = new ProductDTO()
          //  {
          //      Name = "Sosdvvsdska",
          //      Price = 3020
          //  };
          //  products.Add(pr);
          //  products.Add(pr1);
          //  products.Add(pr2);
            return Request.CreateResponse(HttpStatusCode.OK, productView);
            
        }
       

    }
}
