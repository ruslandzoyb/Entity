using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using BL.ServiceInterfaces;
using BL.Services;
namespace API.Controllers
{
    public class ProductController : ApiController
    {
        IServices service;
        public ProductController(IServices services)
        {
            this.service = new BL.Services.Services();
        }


        public HttpResponseMessage Delete(int id)
        {

            service.Products.Delete(id);
            return new HttpResponseMessage();


        }
        [HttpGet]
        public string Name()
        {
            //string s;
            StringBuilder s =new StringBuilder();
           var list= service.Products.GetList();
            foreach (var item in list)
            {
                s.AppendLine( item.Name);
            }
            return s.ToString();
        }

    }
}
