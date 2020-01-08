using AutoMapper;
using BL.ModelsDTO;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Mapper
{
    class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Provider, ProviderDTO>().ReverseMap();
            CreateMap<IEnumerable<Provider>, List<ProviderDTO>>().ReverseMap();
        }

    }
}
