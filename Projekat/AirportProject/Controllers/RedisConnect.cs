using StackExchange.Redis;

namespace AirportProject.Controllers
{
    public class RedisConnect
    {
        private readonly string connectionString;
        private ConnectionMultiplexer connection;

        public RedisConnect(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool Connect()
        {
            connection = ConnectionMultiplexer.Connect(connectionString);
            return connection.IsConnected;
        }

        public IDatabase GetDatabase(int db = -1)
        {
            return connection.GetDatabase(db);
        }

        public void Close()
        {
            connection.Close();
        }

        public string Get(string key)
        {
            IDatabase db = connection.GetDatabase();
            return db.StringGet(key);
        }

        public void Set(string key, string value)
        {
            IDatabase db = connection.GetDatabase();
            db.StringSet(key, value);
        }

        public bool Exists(string key)
        {
            IDatabase db = connection.GetDatabase();
            return db.KeyExists(key);
        }

        public ISubscriber PubSub()
        {
            return connection.GetSubscriber();
        }
    }
}
