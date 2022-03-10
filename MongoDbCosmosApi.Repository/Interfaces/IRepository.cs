namespace MongoDbCosmosApi.Repository.Interfaces
{
    public interface IRepository<T>
    {
        public IQueryable<T> QueryAll();

        public T Query(Guid key);
    }
}