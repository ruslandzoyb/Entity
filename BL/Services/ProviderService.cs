using AutoMapper;
using BL.Mapper;
using BL.ModelsDTO;
using BL.ServiceInterfaces;
using DAL.Model;
using DAL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class ProviderService : IProviderService
    {
        IUnitOfWork DataBase;
        //IMapConfig mapper;
        IMapper mapper;
        public ProviderService()
        {
            DataBase = new UnitOfWork();
            mapper = new MapperConfiguration(ctg => ctg.AddProfile(new MapperConfig())).CreateMapper(); 
        }
        public void Create(ProviderDTO item)
        {
            DataBase.Providers.Create(mapper.Map<Provider>(item));
        }

        public void Delete(int id)
        {
            DataBase.Providers.Delete(id);
        }

        //public void Delete(ProviderDTO item)
        //{
        //    throw new NotImplementedException();
        //}

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ProviderDTO GetElement(int? id)
        {
            return mapper.Map<ProviderDTO>(DataBase.Providers.GetElement(id));
        }

        public IEnumerable<ProviderDTO> GetList()
        {
            return mapper.Map<List<ProviderDTO>>(DataBase.Providers.GetList());
        }

        public IEnumerable<ProviderDTO> GetProviderByCat(CategoryDTO category)
        {
            var ctg = mapper.Map<Category>(category);
            return mapper.Map<List<ProviderDTO>>(DataBase.Providers.GetList().Where(x => x.Categories.Contains(ctg)));
        }

        public IEnumerable<ProviderDTO> GetProviderByCity(string city)
        {

            return mapper.Map<List<ProviderDTO>>(DataBase.Providers.GetList().Where(x => x.City == city));
        }

        public void Update(ProviderDTO item)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ProviderDTO> IService<ProviderDTO>.GetList()
        {
            throw new NotImplementedException();
        }
    }
}
