using MongoDbCosmosApi.Domain.Base;

namespace MongoDbCosmosApi.Domain
{
    public sealed class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Product()
        {
            this.Key = Guid.NewGuid();
        }
    }
}