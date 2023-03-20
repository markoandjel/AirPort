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

namespace AirportProject
{   

    public partial class RegisterForm : Form
    {
        private readonly ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("87.250.63.38:6379");

        public void RegisterUser(string username, string password)
        {
            IDatabase db = redis.GetDatabase();

            if (db.HashExists("users", username))
            {
                throw new Exception("Username already exists.");
            }

            // Generate a salt value for the password
            string salt = GenerateSalt();

            // Hash the password with the salt value
            string hashedPassword = HashPassword(password, salt);

            // Store the username and hashed password in the Redis hash
          
            db.HashSet("users", new HashEntry[] { new HashEntry(username, hashedPassword) });

            MessageBox.Show("Uspesna prijava");
        }

        private string GenerateSalt()
        {
            // Generate a random salt value
            byte[] saltBytes = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            string salt = Convert.ToBase64String(saltBytes);
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
            string username = usernameRegisterInput.Text;
            string password = registerLozinkaInput.Text;

            RegisterUser(username, password);
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogInForm login = new LogInForm();
            login.Show();
            this.Hide();
        }
    }
}
