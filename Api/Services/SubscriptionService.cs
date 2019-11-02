using Api.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Api.Services
{
    public class SubscriptionService : CollectionManager<Subscription>
    {
        private protected readonly IMongoCollection<Subscription> _collection;
        
        public SubscriptionService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _collection = database.GetCollection<Subscription>(settings.SubscriptionsCollectionName);
        }

        override protected IMongoCollection<Subscription> getCollection() {
            return _collection;
        }
    }
}
