using MongoDB.Driver;

namespace MongoDbCosmosApi.Repository.Context
{
    public interface IConnectionFactory
    {
        IMongoClient GetClient();
        IMongoDatabase GetDatabase(IMongoClient mongoClient, string databaseName);
        IMongoDatabase GetDatabase(string databaseName);
    }
}