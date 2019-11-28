using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.ModelsDTO;
using BL.ServiceInterfaces;
using DAL.UOW;
using AutoMapper;
using DAL.Model;

namespace BL.Services
{
    public class ProductService : IProductService
    {
        IUnitOfWork DataBase;

        public ProductService( )
        {
            DataBase = new UnitOfWork();
        }
        public void Create(ProductDTO item)
        {
            //var config = new MapperConfiguration(cfg => { cfg.CreateMap<ProductDTO, Product>(); });
            IMapper mapper = new MapperConfiguration(cfg => { cfg.CreateMap<ProductDTO, Product>(); }).CreateMapper();            // DataBase.Products.Create()
           
            DataBase.Products.Create(mapper.Map<ProductDTO, Product>(item));
            
        }

        public void Delete(ProductDTO product)
        {

            DataBase.Products.Delete(product.Id);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDTO> GetByCategory(CategoryDTO category)
        {
            IMapper catmap = new MapperConfiguration(cfg => cfg.CreateMap<CategoryDTO, Category>()).CreateMapper();
            var cat = catmap.Map<CategoryDTO, Category>(category);
            IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<IEnumerable<Product>,List<ProductDTO>>()).CreateMapper();
            var coll = mapper.Map<IEnumerable<Product>, List<ProductDTO>>(DataBase.Products.GetList().Where(x=>x.Category==cat));

            return coll;
        }

        public IEnumerable<ProductDTO> GetByPrice(double price)
        {
            IMapper mapper= new MapperConfiguration(cfg => cfg.CreateMap<IEnumerable<Product>, List<ProductDTO>>()).CreateMapper();
            var coll = mapper.Map<IEnumerable<Product>, List<ProductDTO>>(DataBase.Products.GetList().Where(x => x.Price == price));
            return coll;
        }

        public IEnumerable<ProductDTO> GetByProvider(ProviderDTO provider)
        {
            throw new NotImplementedException();
        }

        public ProductDTO GetElement(int id)
        {
            IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProductDTO, Product>()).CreateMapper();
            var pr = mapper.Map<Product, ProductDTO>(DataBase.Products.GetElement(id));
            return pr;
        }

        public IEnumerable<ProductDTO> GetList()
        {
            IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<IEnumerable<Product>, List<ProductDTO>>()).CreateMapper();
            var coll = mapper.Map<IEnumerable<Product>, List<ProductDTO>>(DataBase.Products.GetList());
            return coll;
        }

        public ProductDTO ProductMax()
        {
            IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDTO>()).CreateMapper();
            var pr = mapper.Map<Product, ProductDTO>(DataBase.Products.GetList().Max());
            return pr;
        }

        public ProductDTO ProductMin()
        {
            IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDTO>()).CreateMapper();
            var pr = mapper.Map<Product, ProductDTO>(DataBase.Products.GetList().Min());
            return pr;
        }

        public void Update(ProductDTO item)
        {
            
        }
    }
}
