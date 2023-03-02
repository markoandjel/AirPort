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
    }
}
