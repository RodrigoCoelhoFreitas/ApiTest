using MongoDbCosmosApi.Domain;

namespace MongoDBCosmosDBApi.Services.Interfaces
{
    public interface IProductService
    {
        IQueryable<Product> QueryAll();

        Product Query(Guid key);
    }
}