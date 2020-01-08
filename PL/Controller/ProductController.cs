using BL.ServiceInterfaces;
using PL.Interface;
using PL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BL.ModelsDTO;
using BL.Services;
using System.Threading;
using PL.Mapper;

namespace PL.Controller
{
    public class ProductController : IController<ProductViewModel>, IPrContr
    {
        IProductService service;
        IMapper mapper;

        public ProductController(ProductService service)
        {
            this.service = service;
            mapper = new MapperConfiguration(ctg => ctg.AddProfile(new MapConfig())).CreateMapper();
        }

        public void ByPrice(double price)
        {
            
            IMapper mapper = new MapperConfiguration(ctg => ctg.CreateMap <ProductDTO, ProductViewModel>()).CreateMapper();
            var coll= mapper.Map<IEnumerable<ProductDTO>, List<ProductViewModel>>(service.GetByPrice(price).ToList());
            //Thread.Sleep(3000);
            foreach (var item in coll)
            {
                Console.WriteLine(item.Name);
            }
          // return service.GetByPrice(price);
        }

        public void Delete(int id)
        {
            service.Delete(id);
           // throw new NotImplementedException();
        }

        public void Get(int id)
        {
            IMapper mapper = new MapperConfiguration(ctg => ctg.CreateMap<ProductDTO, ProductViewModel>()).CreateMapper();
            // var pr = service.GetElement(id);
            var pr = mapper.Map<ProductDTO, ProductViewModel>(service.GetElement(id));
        }

        public IEnumerable<ProductViewModel> GetList()
        {

          var coll= mapper.Map<IEnumerable<ProductViewModel>>(service.GetList()).ToList();
            //foreach (var item in coll)
            //{
            //    Console.WriteLine($"{item.Id}  {item.Name}  {item.Price}");
            //}
            return coll;
            //IMapper mapper = new MapperConfiguration(ctg => ctg.CreateMap<IEnumerable<ProductDTO>, List<ProductViewModel>>()).CreateMapper();

            //var coll = mapper.Map<IEnumerable<ProductDTO>, List<ProductViewModel>>(service.GetList()); //service.GetList();
            
        }

        public void Put(ProductViewModel item)
        {
            var pr = new ProductDTO() { Name = item.Name, Price = item.Price };
            service.Create(pr);
        }

        public void Update(ProductViewModel item)
        {
           // throw new NotImplementedException();
        }
    }
}
