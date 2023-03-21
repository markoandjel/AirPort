using System;

namespace AirportProject.DomainModel
{
    public class Session
    {
        public string SessionId { get; set; }
        public string Username { get; set; }
        public DateTime Expiry { get; set; }

        public Session() { }
        public Session(string id, string username)
        {
            SessionId = id;
            Username = username;
            Expiry = DateTime.Now.AddMinutes(30);
        }

        public bool IsExpired()
        {
            return DateTime.Now > Expiry;
        }
    }
}
