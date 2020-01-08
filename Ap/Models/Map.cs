using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BL.ModelsDTO;

namespace Ap.Models
{
    public class Map:Profile
    {
        public Map()
        {
            CreateMap<ProductView, ProductDTO>().ReverseMap();
            CreateMap<CategoryView, CategoryDTO>().ReverseMap();
            CreateMap<ProviderView, ProviderDTO>().ReverseMap();
        }
    }
}