using AirportProject.Controllers;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportProject
{
    public partial class PubSubForma : Form
    {
        private RedisConnect _redisConnect;
        public PubSubForma()
        {
            InitializeComponent();
        }

        public PubSubForma(RedisConnect redisConnect)
        {
            InitializeComponent();
            _redisConnect = redisConnect;
        }

        private void PubSubForma_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISubscriber sub=_redisConnect.PubSub();

            string pom;
            try
            {
                sub.Subscribe(new RedisChannel("test", RedisChannel.PatternMode.Literal), (channel, message) =>
                {
                    Console.WriteLine("Poruka je 4323" + message.ToString());

                    label1.Invoke(new Action(() => { label1.Text+= message.ToString(); }));
                });
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ISubscriber pub = _redisConnect.PubSub();
            var t=pub.Publish("test", "MarkoProba32");
            Console.WriteLine(t);
        }
    }
}
