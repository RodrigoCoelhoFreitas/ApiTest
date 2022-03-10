using MongoDbCosmosApi.Domain;
using MongoDbCosmosApi.Repository.Interfaces;
using MongoDBCosmosDBApi.Services.Interfaces;

namespace MongoDBCosmosDBApi.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public IQueryable<Product> QueryAll()
        {
            var result = _productRepository.QueryAll();
            return result;
        }

        public Product Query(Guid key)
        {
            var result = _productRepository.Query(key);
            return result;
        }
    }
}