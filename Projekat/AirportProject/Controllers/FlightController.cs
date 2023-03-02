using AirportProject.DomainModel;
using Neo4j.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Linq;

namespace AirportProject.Controllers
{
    public class FlightController
    {
        private readonly IDriver _driver;
        private readonly ISession _session;
        public FlightController() { }
        public FlightController(IDriver driver)
        {
            _driver = driver;
            _session = _driver.Session(conf =>
            conf.WithDatabase("neo4j"));
        }
        public void CreateFlight(Flight f)
        {
            Query query = new Query(string.Format("MATCH (a1: Airport),(a2: Airport) WHERE a1.code=\"{0}\" AND a2.code=\"{1}\" " +
                "MERGE (a1)-[r:FLIGHT {{ code:\"{2}\",timeofdeparture:\"{3}\",timeofarival:\"{4}\",price:\"{5}\",freeseats:\"{6}\",numofseats:\"{7}\"}}]->(a2) RETURN r",
                f.Start.Code, f.Destination.Code, f.Code, f.TimeOfDeparture.ToString(), f.TimeOfArival.ToString(), f.Price, f.FreeSeats, f.NumOfSeats));
            _session.Run(query);
        }
        public void UpdateFlight(Flight f)
        {
            Query query = new Query(string.Format("MATCH (a:Airport {{code:\'{0}\'}})-[f:FLIGHT{{code:\'{1}\'}}]->(a2:Airport {{code:\'{2}\'}}) " +
                "SET f.timeofdeparture=\'{3}\',f.timeofarival=\'{4}\',f.price=\'{5}\',f.freeseats=\'{6}\',f.numofseats=\'{7}\'"
                , f.Start.Code, f.Code.ToString(), f.Destination.Code, f.TimeOfDeparture.ToString(), f.TimeOfArival.ToString(), f.Price.ToString(), f.NumOfSeats.ToString(), f.FreeSeats.ToString()));
            _session.Run(query);
        }
        public void DeleteFlight(Flight f)
        {
            Query query = new Query(string.Format("MATCH (a:Airport {{code:\'{0}\'}})-[f:FLIGHT {{code:{1} }}]->(a2:Airport {{code:{2}}})", f.Start.Code, f.Code, f.Destination.Code));
            _session.Run(query);
        }
        public List<Flight> GetAllFlightsFrom(Airport airport)
        {
            List<Flight> flights = new List<Flight>();
            var res = _session.ExecuteRead(tx =>
            {
                Query query = new Query(string.Format("MATCH(a1: Airport{{code:\'{0}\'}} )-[r:FLIGHT]->(a2:Airport) RETURN r,a1,a2 LIMIT 25", airport.Code));
                var cursor = tx.Run(query);
                return cursor.ToList();
            });
            foreach (var r in res)
            {
                var node = JsonConvert.SerializeObject(r[0].As<IRelationship>().Properties);
                //DateTime timeArrival = Convert.ToDateTime(r[0].As<IRelationship>().Properties.Values.First());
                //DateTime timeDeparture = Convert.ToDateTime(r[0].As<IRelationship>().Properties.Values.Last());

                var format = "d.M.yyyy. HH:mm:ss";
                var dateTimeConverter = new IsoDateTimeConverter { DateTimeFormat = format };
                var flight = JsonConvert.DeserializeObject<DomainModel.Flight>(node, dateTimeConverter);
                var node2 = JsonConvert.SerializeObject(r[1].As<INode>().Properties);
                var airportFrom = JsonConvert.DeserializeObject<DomainModel.Airport>(node2);
                var node3 = JsonConvert.SerializeObject(r[2].As<INode>().Properties);
                var airportTo = JsonConvert.DeserializeObject<DomainModel.Airport>(node3);
                flight.Start = airportFrom;
                flight.Destination = airportTo;

                flights.Add(flight);
            }
            return flights;
        }
        public List<Flight> GetAllFlightsTo(Airport airport)
        {
            List<Flight> flights = new List<Flight>();
            var res = _session.ExecuteRead(tx =>
            {
                Query query = new Query(string.Format("MATCH(a1: Airport )-[r:FLIGHT]->(a2:Airport {{code:'{0}'}}) RETURN r,a1,a2 LIMIT 25", airport.Code));
                var cursor = tx.Run(query);
                return cursor.ToList();
            });
            foreach (var r in res)
            {
                var node = JsonConvert.SerializeObject(r[0].As<IRelationship>().Properties);
                //DateTime timeArrival = Convert.ToDateTime(r[0].As<IRelationship>().Properties.Values.First());
                //DateTime timeDeparture = Convert.ToDateTime(r[0].As<IRelationship>().Properties.Values.Last());

                var format = "d.M.yyyy. HH:mm:ss";
                var dateTimeConverter = new IsoDateTimeConverter { DateTimeFormat = format };
                var flight = JsonConvert.DeserializeObject<DomainModel.Flight>(node, dateTimeConverter);
                var node2 = JsonConvert.SerializeObject(r[1].As<INode>().Properties);
                var airportFrom = JsonConvert.DeserializeObject<DomainModel.Airport>(node2);
                var node3 = JsonConvert.SerializeObject(r[2].As<INode>().Properties);
                var airportTo = JsonConvert.DeserializeObject<DomainModel.Airport>(node3);
                flight.Start = airportFrom;
                flight.Destination = airportTo;

                flights.Add(flight);
            }
            return flights;
        }
    }
}
