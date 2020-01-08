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
        //IMapConfig mapper;
        IMapper mapper;

        public ProductService()
        {
            DataBase = new UnitOfWork();
             mapper = new MapperConfiguration(ctg => ctg.AddProfile(new Map())).CreateMapper();
            
        }
        public void Create(ProductDTO item)
        {
            DataBase.Products.Create(mapper.Map<Product>(item));
            //var config = new MapperConfiguration(cfg => { cfg.CreateMap<ProductDTO, Product>(); });
            // IMapper mapper = new MapperConfiguration(cfg => { cfg.CreateMap<ProductDTO, Product>(); }).CreateMapper();            // DataBase.Products.Create()
            
            //DataBase.Products.Create(mapper.Map<ProductDTO, Product>(item));
            //  DataBase.Products.Create(mapper.GetMapper<ProductDTO, Product>(item));
            DataBase.Save();

        }

        public void Delete(int id)
        {


            DataBase.Products.Delete(id);
        }

        public void Dispose()
        {
            // throw new NotImplementedException();
        }

        public IEnumerable<ProductDTO> GetByCategory(CategoryDTO category)
        {
            var ct = mapper.Map<Category>(category);
            var coll = mapper.Map<List<ProductDTO>>(DataBase.Products.GetList().Where(x => x.Category == ct));
            //IMapper catmap = new MapperConfiguration(cfg => cfg.CreateMap<CategoryDTO, Category>()).CreateMapper();
            //var cat = catmap.Map<CategoryDTO, Category>(category);
            //IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<IEnumerable<Product>, List<ProductDTO>>()).CreateMapper();
            //var coll = mapper.Map<IEnumerable<Product>, List<ProductDTO>>(DataBase.Products.GetList().Where(x => x.Category == cat));

            return coll;
        }

        public IEnumerable<ProductDTO> GetByPrice(double price)
        {

            IMapper mapper = new MapperConfiguration(cfg => { cfg.CreateMap<Product, ProductDTO>(); }).CreateMapper();
            var coll = DataBase.Products.GetList();
            var data = mapper.Map<IEnumerable<Product>, List<ProductDTO>>(coll.Where(x => x.Price == price)).ToList();

            return data;
        }

        public IEnumerable<ProductDTO> GetByProvider(ProviderDTO provider)
        {
            var prov = mapper.Map<Provider>(provider);
            var coll = mapper.Map<List<ProductDTO>>(DataBase.Products.GetList().Where(x => x.Provider == prov));
            //IMapper catmap = new MapperConfiguration(cfg => cfg.CreateMap<ProviderDTO, Provider>()).CreateMapper();
            //var pro = catmap.Map<ProviderDTO, Provider>(provider);
            //IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductDTO>()).CreateMapper();
            //var coll = mapper.Map<IEnumerable<Product>, IEnumerable<ProductDTO>>(DataBase.Products.GetList().Where(x => x.Provider == pro));

            return coll;
        }

        public ProductDTO GetElement(int? id)
        {
           var el= mapper.Map<ProductDTO>(DataBase.Products.GetElement(id));
            return el;
            //IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProductDTO, Product>()).CreateMapper();
            //var pr = mapper.Map<Product, ProductDTO>(DataBase.Products.GetElement(id));
            //return pr;
        }

        public IEnumerable<ProductDTO> GetList()
        {
            var list = mapper.Map<ICollection<ProductDTO>>(DataBase.Products.GetList()).ToList();
            return list;
            //IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<Product,ProductDTO>()).CreateMapper();
            //var coll = new List<ProductDTO>();
            // coll = mapper.Map<IEnumerable<Product>, List<ProductDTO>>(DataBase.Products.GetList());
            //return coll;
        }

        public ProductDTO ProductMax()
        {
            var pr = mapper.Map<ProductDTO>(DataBase.Products.GetList().Max());
            
            return pr;
        }

        public ProductDTO ProductMin()
        {
            var pr = mapper.Map<ProductDTO>(DataBase.Products.GetList().Min());

            return pr;
        }

        public void Update(ProductDTO item)
        {
            DataBase.Products.Update(mapper.Map<Product>(item));
            //IMapper mapper = new MapperConfiguration(cfg => cfg.CreateMap<ProductDTO, Product>()).CreateMapper();
            //var pr = mapper.Map<ProductDTO, Product>(item);
            //DataBase.Products.Update(pr);
        }
    }

    public class Map:Profile
    {
        public Map()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Provider, ProviderDTO>().ReverseMap();
           
        }

    }
    
}
