using AirportProject.Controllers;
using AirportProject.DomainModel;
using StackExchange.Redis;
using System;
using System.Windows.Forms;

namespace AirportProject
{
    public partial class AdminForm : Form
    {
        private Neo4jConnect _klijent;
        private RedisConnect redisConnect;
        private ConnectionMultiplexer _redis;
        private Session _session;
        private Timer _sessionTimer;

        public AdminForm(Session session)
        {
            InitializeComponent();

            _klijent = new Neo4jConnect("bolt://87.250.63.38:7687", "neo4j", "bazicari");
            this.redisConnect = new RedisConnect("87.250.63.38:6379");
            bool connected = redisConnect.Connect();
            if (!connected)
            {
                MessageBox.Show("Connection is not working!");
            }
            _session = session;

            _sessionTimer = new Timer();
            _sessionTimer.Interval = 1000; // Check every second
            _sessionTimer.Tick += new EventHandler(CheckSessionExpiration);
            _sessionTimer.Start();

        }
        private void CheckSessionExpiration(object sender, EventArgs e)
        {
            if (_session.IsExpired())
            {
                _sessionTimer.Stop();
                this.Close(); // Close the current form
                RegisterForm registerForm = new RegisterForm();
                registerForm.Show(); // Show the register form again
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
            AirportController a = new AirportController(_klijent.Driver);
            var airports=a.GetAllAirports();
            foreach(var p in airports)
            {
                cbxAirports.Items.Add(p.Name);
            }
            dgvMessages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void addTicket_Click(object sender, EventArgs e)
        {
            //int number = 12;
            //string seatnum = "22";
            //string gate = "5";
            //string fcode = "2344";
            //string passenger = "Marko Andjelkovic";
            //Flight flight= new Flight();
            //Ticket ticket = new Ticket(number,seatnum, gate, fcode,passenger);  
            //TicketController t = new TicketController(_klijent.Driver);
            //t.createTicket(ticket);
        }

     

        private void btnAirportManager_Click(object sender, EventArgs e)
        {
            AirportForm airportForm=new AirportForm(_klijent,_session);
            airportForm.ShowDialog();
        }

        private void btnFlightManager_Click(object sender, EventArgs e)
        {
            this.Close();
            FlightForm flighForm = new FlightForm(_klijent,redisConnect,_session);
            flighForm.ShowDialog();
        }

        private void btnCityManager_Click(object sender, EventArgs e)
        {
            this.Close();
            CityForm cityForm = new CityForm(_klijent,_session);
            cityForm.ShowDialog();
        }

        private void btnAirlineManager_Click(object sender, EventArgs e)
        {
            this.Close();
            AirlineForm airlineForm=new AirlineForm(_klijent,_session);
            airlineForm.ShowDialog();
        }

        private void cbxAirports_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvMessages.Rows.Clear();
            ISubscriber p = redisConnect.PubSub();

            p.UnsubscribeAll();

            AirportController a = new AirportController(_klijent.Driver);
            var airports = a.GetAllAirports();
            Airport selectAirport = airports.Find(x => x.Name == cbxAirports.SelectedItem.ToString());

            FlightController flights = new FlightController(_klijent.Driver);

            foreach (var v in flights.GetAllFlightsFrom(selectAirport))
            {
                string j = v.Code;
                p.Subscribe(j, (channel, message) =>
                {
                    dgvMessages.Invoke(new Action(() => { dgvMessages.Rows.Add(message);}));
                });
            }

            foreach (var v in flights.GetAllFlightsTo(selectAirport))
            {
                string j = v.Code;
                p.Subscribe(j, (channel, message) =>
                {
                    dgvMessages.Invoke(new Action(() => { dgvMessages.Rows.Add(message); }));
                });
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            SessionRepository repo = new SessionRepository(_redis);
            repo.Delete(_session.Username + "_Session");
            this.Close();
            LogInForm forma = new LogInForm(_redis);
            forma.Show();
        }
    }
}
