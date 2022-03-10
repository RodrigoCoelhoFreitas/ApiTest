using MongoDB.Driver;
using MongoDbCosmosApi.Domain;
using MongoDbCosmosApi.Repository.Base;
using MongoDbCosmosApi.Repository.Context;

namespace MongoDbCosmosApi.Repository
{
    public sealed class ProductRepository : Repository<Product>
    {
        public ProductRepository(IMongoCollection<Product> collectionoName) : base(collectionoName)
        {
        }

        public ProductRepository(IConnectionFactory connectionfactory, string databaseName, string collectionName) : base(connectionfactory, databaseName, collectionName)
        {
        }
    }
}