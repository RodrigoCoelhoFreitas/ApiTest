using MongoDB.Driver;
using MongoDbCosmosApi.Domain.Interfaces;
using MongoDbCosmosApi.Repository.Context;
using MongoDbCosmosApi.Repository.Interfaces;

namespace MongoDbCosmosApi.Repository.Base
{
    public abstract class Repository<T> : IRepository<T> where T : IEntity
    {
        private readonly IMongoCollection<T> _collectionName;

        protected Repository(IMongoCollection<T> collectionoName)
        {
            _collectionName = collectionoName;
        }

        protected Repository(IConnectionFactory connectionfactory, string databaseName, string collectionName)
        {
            _collectionName = connectionfactory.GetDatabase(databaseName).GetCollection<T>(collectionName);
        }

        public IQueryable<T> QueryAll()
        {
            return _collectionName.AsQueryable<T>();
        }

        public T Query(Guid key)
        {
            return _collectionName.AsQueryable<T>().FirstOrDefault(w => w.Key == key);
        }
    }
}