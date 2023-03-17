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

namespace AirportProject
{
    public partial class LogInForm : Form
    {
        private readonly RedisConnect redis;
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

        }

        private void prijaviseBtn_Click(object sender, EventArgs e)
        {
            string kor_ime = InputUsername.Text;
            string lozinka = lozinkaInput.Text;

            //string sacuvanalozinka = redis.Get(kor_ime);

            if (redis.Exists(kor_ime))
            {
                string sacuvanalozinka = redis.Get(kor_ime);
                if (BCrypt.Net.BCrypt.Verify(lozinka, sacuvanalozinka))
                {
                    MessageBox.Show("Upadaj momak");
                    Form1 forma = new Form1();
                    forma.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ne radi be ");
                }


            }
            else
                MessageBox.Show("Proveri juzernejm nema ga u bazu ovamo");

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
