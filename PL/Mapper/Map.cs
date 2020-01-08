using BL.ModelsDTO;
using PL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace PL.Mapper
{
    public class MapConfig : Profile
    {
        public MapConfig()
        {
            CreateMap<ProductViewModel, ProductDTO>().ReverseMap();
            CreateMap<CategoryViewModel, CategoryDTO>().ReverseMap();
            CreateMap<ProviderViewModel, ProviderDTO>().ReverseMap();

        }

    }
}
