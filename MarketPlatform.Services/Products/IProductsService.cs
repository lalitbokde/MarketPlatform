using MarketPlatform.Core.Domain.Products;
using System.Collections.Generic;

namespace MarketPlatform.Services.Products
{
    public partial interface IProductsService
    {
        void insertProduct(Product modelProduct);

        List<Product> getAllProducts();

        void updateProduct(Product model);
    }
}
