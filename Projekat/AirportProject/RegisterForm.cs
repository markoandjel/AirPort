using AirportProject.DomainModel;
using BCrypt.Net;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                sessionRepo.Save(session,username);
                AdminForm forma = new AdminForm(session);
                forma.Show();
                this.Hide();
                redis.Dispose();
                return true;
            }
            else
            {
                MessageBox.Show("Incorrect user" ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernameRegisterInput_MouseEnter(object sender, EventArgs e)
        {
            usernameRegisterInput.BackColor= Color.White;
            panel3.BackColor= Color.White;
        }

        private void usernameRegisterInput_Click(object sender, EventArgs e)
        {
            usernameRegisterInput.BackColor = Color.White;
            panel3.BackColor= Color.White;
            registerLozinkaInput.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
        }

        private void usernameRegisterInput_MouseLeave(object sender, EventArgs e)
        {
            usernameRegisterInput.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void registerLozinkaInput_MouseClick(object sender, MouseEventArgs e)
        {
            registerLozinkaInput.BackColor = Color.White;
            panel4.BackColor = Color.White;
            usernameRegisterInput.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void registerLozinkaInput_MouseEnter(object sender, EventArgs e)
        {
            registerLozinkaInput.BackColor = Color.White;
            panel4.BackColor = Color.White;
        }

        private void registerLozinkaInput_MouseLeave(object sender, EventArgs e)
        {
            registerLozinkaInput.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
        }

        private void usernameRegisterInput_Enter(object sender, EventArgs e)
        {
            usernameRegisterInput.BackColor = Color.White;
            panel3.BackColor = Color.White;
            registerLozinkaInput.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
        }

        private void usernameRegisterInput_Leave(object sender, EventArgs e)
        {

        }

        private void usernameRegisterInput_MouseEnter_1(object sender, EventArgs e)
        {

        }

        private void usernameRegisterInput_MouseLeave_1(object sender, EventArgs e)
        {

        }

        private void registerLozinkaInput_Enter(object sender, EventArgs e)
        {
            registerLozinkaInput.BackColor = Color.White;
            panel4.BackColor = Color.White;
            usernameRegisterInput.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
