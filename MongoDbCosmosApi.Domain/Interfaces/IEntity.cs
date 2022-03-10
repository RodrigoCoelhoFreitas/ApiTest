namespace MongoDbCosmosApi.Domain.Interfaces
{
    public interface IEntity
    {
        Guid Key { get; set; }
    }
}