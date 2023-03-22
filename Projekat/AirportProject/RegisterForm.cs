using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackExchange.Redis;
using System.Security.Cryptography;
using BCrypt.Net;
using AirportProject.DomainModel;
using Newtonsoft.Json;

namespace AirportProject
{

    public partial class RegisterForm : Form
    {
        private readonly ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("87.250.63.38:6379");
        private Session session;
        public async Task<bool> RegisterUser(string username, string password)
        {
            var db = redis.GetDatabase();
            var userExists = await db.HashExistsAsync(username, "Password");

            if (!userExists)
            {
                var hashed = BCrypt.Net.BCrypt.HashPassword(password, BCrypt.Net.BCrypt.GenerateSalt(13), false,HashType.SHA384);
                var role = UserRole.User;
                var user = new User(username, hashed, role);
                var json = JsonConvert.SerializeObject(user);
                await db.StringSetAsync(username, json);

                var sessionId = Guid.NewGuid().ToString();
                var sessionRepo = new SessionRepository(redis);
                session = new Session(sessionId, username);
                sessionRepo.Save(session);
                MessageBox.Show("Uspeo si konju, pogledaj bazu dal pamti dobro");
                AdminForm forma = new AdminForm(session);
                forma.Show();
                this.Hide();
                redis.Dispose();
                return true;
            }
            else
            {
                MessageBox.Show("Ne radi s taj juzer, proveri opet unesi neki novi" ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
                return false;

            }
        }

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameRegisterInput.Text) || string.IsNullOrEmpty(registerLozinkaInput.Text))
            {
                MessageBox.Show("Please enter a username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                string u = usernameRegisterInput.Text;
                string l = registerLozinkaInput.Text;
                RegisterUser(u, l);
            }
        }
    
        

        private void button2_Click(object sender, EventArgs e)
        {
            LogInForm login = new LogInForm(redis);
            login.Show();
            this.Hide();
        }
    }
}
