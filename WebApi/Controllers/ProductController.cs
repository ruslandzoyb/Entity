using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL.ModelsDTO;
using BL.ServiceInterfaces;
using BL.Services;
using PL.ViewModel;

namespace WebApi.Controllers
{
    public class ProductController : ApiController
    {
        private IProductService service=new ProductService();

        [HttpPost]
        public void Put([FromBody]ProductViewModel product)
        {
            ProductDTO dTO = 
            service.Create()
        }

    }
}
