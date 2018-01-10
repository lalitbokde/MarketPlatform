using MarketPlatform.Core.Domain.Products;
using MarketPlatform.Services.Common;
using System.Collections.Generic;
using System.Linq;

namespace MarketPlatform.Services.Products
{
    public class ProductsService : IProductsService
    {
        private readonly IRepository<Product> _RegistrationRepository;
        public ProductsService(IRepository<Product> RegistrationRepository)
        {
            this._RegistrationRepository = RegistrationRepository;
        }

        public void insertProduct(Product Registration)
        {
            _RegistrationRepository.Insert(Registration);
        }

        public List<Product> getAllProducts()
        {
            return _RegistrationRepository.Table.ToList();
        }

        public void updateProduct(Product model)
        {
            _RegistrationRepository.Update(model);
        }

    }
}
