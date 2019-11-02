namespace Api.Models
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string UsersCollectionName { get; set; }
        public string CitiesCollectionName { get; set; }
        public string SubscriptionsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IDatabaseSettings
    {
        string UsersCollectionName { get; set; }
        string CitiesCollectionName { get; set; }
        string SubscriptionsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
