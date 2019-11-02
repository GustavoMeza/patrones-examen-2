using Api.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Api.Services
{
    public class UserService : CollectionManager<User>
    {
        private protected readonly IMongoCollection<User> _collection;
        
        public UserService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _collection = database.GetCollection<User>(settings.UsersCollectionName);
        }

        override protected IMongoCollection<User> getCollection() {
            return _collection;
        }
    }
}
