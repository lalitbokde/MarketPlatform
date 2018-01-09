using MarketPlatform.Core.Domain.Products;
using MarketPlatform.Services.Common;
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

        public Product getProduct()
        {
            return _RegistrationRepository.Table.FirstOrDefault();
        }

        public void updateProduct(Product model)
        {
            _RegistrationRepository.Update(model);
        }

    }
}
