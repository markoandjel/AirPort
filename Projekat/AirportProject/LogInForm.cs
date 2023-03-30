using AirportProject.DomainModel;
using BCrypt.Net;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AirportProject
{
    public partial class LogInForm : Form
    {
        private  ConnectionMultiplexer redis;
        private Session session;
        private SessionRepository sessionRepo;

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
            if(redis == null)
                redis = ConnectionMultiplexer.Connect("87.250.63.38:6379");
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
                    
                    session = new Session(sessionId, username);
                    
                    if(!db.StringGet(username + "_Session").IsNull)
                    {
                        MessageBox.Show("You are already logged in!");
                        return false;
                    }

                    //db.StringSet(username+"_Session", JsonConvert.SerializeObject(session));
                    sessionRepo = new SessionRepository(redis);
                    sessionRepo.Save(session,username);
                    if (user.Role == 0)
                    {
                       
                        AdminForm forma = new AdminForm(session);
                        forma.ShowDialog();
                        this.Hide();
                        return true;
                    }
                    else
                    {
                        UserForm forma = new UserForm(session);
                        forma.ShowDialog();
                        this.Hide();
                        return true;
                    }  
                }
                else
                {
                    MessageBox.Show("Bad password");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Bad username");
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
            this.Hide();
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
            
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
