using MarketPlatform.Core.Domain.Products;

namespace MarketPlatform.Services.Products
{
    public partial interface IProductsService
    {
        void insertProduct(Product modelProduct);

        Product getProduct();

        void updateProduct(Product model);
    }
}
