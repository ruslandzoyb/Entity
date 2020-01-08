using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL.Services;
using BL.ServiceInterfaces;
using AutoMapper;
using Ap.Models;
using System.Threading.Tasks;

namespace Ap.Controllers
{
    public class ValuesController : ApiController
    {
        IProductService services = new ProductService();
        IMapper mapper = new MapperConfiguration(ctg => ctg.AddProfile(new Ap.Models.Map())).CreateMapper();
        // GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        public  HttpResponseMessage Get()
        {
            IEnumerable<ProductView> l;
         l =  mapper.Map<IEnumerable<ProductView>>(services.GetList());
            foreach (var item in l)
            {
               
            }
          HttpResponseMessage message=  Request.CreateResponse(HttpStatusCode.OK, l);
            return message;
            
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
