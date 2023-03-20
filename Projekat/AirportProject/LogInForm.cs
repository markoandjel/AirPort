using AirportProject.Controllers;
using StackExchange.Redis;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AirportProject
{
    public partial class LogInForm : Form
    {
        private readonly RedisConnect redis;


        private string ExtractSalt(RedisValue hashedPassword)
        {
            // Extract the salt value from the hashed password string
            int startIndex = hashedPassword.ToString().LastIndexOf("$") + 1;
            int endIndex = startIndex + 22;
            string salt = hashedPassword.ToString().Substring(startIndex, 22);
            return salt;
        }

        private string HashPassword(string password, string salt)
        {
            // Concatenate the password and salt values
            string saltedPassword = password + salt;

            // Hash the salted password value using a secure hash function, such as bcrypt
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(saltedPassword);

            return hashedPassword;
        }
        public LogInForm()
        {
            InitializeComponent();

            redis = new RedisConnect("87.250.63.38:6379");
            bool connected = redis.Connect();
            if (!connected)
            {
                MessageBox.Show("Aj dodji kasnije ne mogu se povezujem sad");
            }
        }

        private bool LoginUser(string username, string password)
        {
            IDatabase db = redis.GetDatabase();
            RedisValue hashedPassword = db.HashGet("users", username);

            if (hashedPassword.IsNullOrEmpty)
            {
                return false;
            }

            string salt = ExtractSalt(hashedPassword);
            string hashedInputPassword = HashPassword(password, salt);

            return BCrypt.Net.BCrypt.Verify(hashedInputPassword, hashedPassword);
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
            string kor_ime = InputUsername.Text;
            string lozinka = lozinkaInput.Text;

            //string sacuvanalozinka = redis.Get(kor_ime);

            if (LoginUser(kor_ime, lozinka))
            {
                MessageBox.Show("Login successful.");
                Form1 forma = new Form1();
                forma.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
      

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
