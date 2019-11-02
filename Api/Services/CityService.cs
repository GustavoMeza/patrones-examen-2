using Api.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Api.Services
{
    public class CityService : CollectionManager<City>
    {
        private protected readonly IMongoCollection<City> _collection;
        
        public CityService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _collection = database.GetCollection<City>(settings.CitiesCollectionName);
        }

        override protected IMongoCollection<City> getCollection() {
            return _collection;
        }
    }
}
