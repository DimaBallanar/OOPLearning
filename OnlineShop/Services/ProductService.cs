using OnlineShop.Repository;

namespace OnlineShop.Services
{
    public class ProductService
    {
        private readonly ProductRepository m_ProductRepository;

        public ProductService(ProductRepository productRepository)
        {
            m_ProductRepository = productRepository;
        }

    }
}
