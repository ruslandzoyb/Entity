using BL.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    class Services : IServices
    {
        private ProductService products;
        private CategoryService categories;
        private ProviderService providers;
        public ProductService Products { get {
                if (products == null)
                {
                    products = new ProductService();
                }
                return products;

            } }

        public CategoryService Categories
        {
            get
            {
                if (categories == null)
                {
                    categories = new CategoryService();
                }
                return categories;

            }
        }

        public ProviderService Providers
        {
            get
            {
                if (providers == null)
                {
                    providers = new ProviderService();
                }
                return providers;

            }
        }

    }
}
