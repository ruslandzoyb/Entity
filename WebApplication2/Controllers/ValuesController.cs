using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL.ModelsDTO;
using BL.ServiceInterfaces;
using BL.Services;
namespace WebApplication2.Controllers
{
    public class ValuesController : ApiController
    {
        private IProductService service;
        public ValuesController()
        {
            service = new ProductService();
        }
        // GET api/values
        public HttpResponseMessage Get()
        {
            var coll = service.GetList();

            return Request.CreateResponse(HttpStatusCode.OK, coll.ToList());
        }

        // GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

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
