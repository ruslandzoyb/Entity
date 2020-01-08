using BL.ModelsDTO;
using BL.ServiceInterfaces;
using DAL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class CategoryService : ICategoryService
    {
       private IUnitOfWork DataBase;
        public CategoryService()
        {
            DataBase = new UnitOfWork();
        }
        public void Create(CategoryDTO item)
        {

            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(CategoryDTO item)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public CategoryDTO GetCatByProduct(ProductDTO product)
        {
            throw new NotImplementedException();
        }

        public CategoryDTO GetElement(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryDTO> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(CategoryDTO item)
        {
            throw new NotImplementedException();
        }

        IEnumerable<CategoryDTO> IService<CategoryDTO>.GetList()
        {
            throw new NotImplementedException();
        }
    }
}
