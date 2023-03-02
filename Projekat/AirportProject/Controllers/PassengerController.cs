using AirportProject.DomainModel;
using Neo4j.Driver;

namespace AirportProject.Controllers
{
    public class PassengerController:Neo4jConnect
    {
        private readonly IDriver _driver;

        public PassengerController()
        {

        }

        public PassengerController(IDriver driver)
        {
            _driver = driver;
        }

        public void CreatePassenger(Passenger p) { 
            
            var session = _driver.Session(conf=>conf
            .WithDefaultAccessMode(AccessMode.Write)
            .WithDatabase("neo4j"))
            .Run("CREATE (p:Passenger {name: $name,passport: $passportNumber})", new { name = p.Name, passportNumber = p.PassportNumber });
        }

    }
}
