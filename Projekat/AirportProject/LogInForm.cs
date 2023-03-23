using AirportProject.DomainModel;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using AirportProject.Controllers;
using BCrypt.Net;
using Newtonsoft.Json;

namespace AirportProject
{
    public partial class LogInForm : Form
    {
        private  ConnectionMultiplexer redis;
        private Session session;


        public LogInForm()
        {
            InitializeComponent();

        }

        public LogInForm(ConnectionMultiplexer redis)
        {
            InitializeComponent();
            this.redis = redis;
        }

        public bool LoginUser(string username, string password)
        {
            
            IDatabase db = redis.GetDatabase();
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            
            RedisValue userExists =  db.StringGet(username);
            if (!userExists.IsNullOrEmpty)
            {
                User user = JsonConvert.DeserializeObject<User>(userExists);
                string storedPassword = user.Password;
                if (!String.IsNullOrEmpty(storedPassword) && BCrypt.Net.BCrypt.Verify(password, storedPassword,false,HashType.SHA384))
                {
                    var sessionId = Guid.NewGuid().ToString();
                    var sessionRepo = new SessionRepository(redis);
                    session = new Session(sessionId, username);
                    sessionRepo.Save(session);
                    MessageBox.Show("Uspeo si konju, pogledaj bazu dal pamti dobro");
                    UserForm forma = new UserForm();
                    forma.Show();
                    this.Hide();
                    return true;
                }
                else
                {
                    MessageBox.Show("Familijo zapisi si lozinku na papirce vidis da gresis");
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Proveri dal se dobro zoves, nemam te takvog u bazu");
                return false;
            }
        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox1_Click(object sender, EventArgs e)
        {
            InputUsername.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            lozinkaInput.BackColor = SystemColors.Control;
        }

        private void TextBox2_Click(object sender, EventArgs e)
        {
            InputUsername.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = Color.White;
            lozinkaInput.BackColor = Color.White;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            lozinkaInput.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            lozinkaInput.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm forma = new RegisterForm();
            forma.Show();
            this.Hide();
        }

        private void prijaviseBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(InputUsername.Text) || string.IsNullOrEmpty(lozinkaInput.Text))
            {
                MessageBox.Show("Please enter a username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                string u = InputUsername.Text;
                string l = lozinkaInput.Text;
                LoginUser(u, l);
            }
            //string sacuvanalozinka = redis.Get(kor_ime);




        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
