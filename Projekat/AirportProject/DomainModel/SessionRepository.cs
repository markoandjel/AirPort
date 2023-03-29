using Newtonsoft.Json;
using StackExchange.Redis;
using System;

namespace AirportProject.DomainModel
{
    public class SessionRepository
    {
        private readonly IDatabase _db;

        public SessionRepository(IConnectionMultiplexer redis)
        {
            if (redis == null)
                redis = ConnectionMultiplexer.Connect("87.250.63.38:6379");
            _db = redis.GetDatabase();
        }
        public void Save(Session session,string username)
        {
            var json = JsonConvert.SerializeObject(session);
            _db.StringSet(username + "_Session", json, session.Expiry - DateTime.Now);
        }
        public Session get (string sessionId)
        {
            var json = _db.StringGet(sessionId);
            return json.IsNullOrEmpty ? null: JsonConvert.DeserializeObject<Session>(json);
        }

        public void Delete (string sessionId)
        {
            _db.KeyDelete(sessionId);
        }
        

    }
}
