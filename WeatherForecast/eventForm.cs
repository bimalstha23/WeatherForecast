using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace WeatherForecast
{
    public partial class eventForm : Form
    {
        public eventForm()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "vDbkplFbNLdyWsjLBpieDvuJCx6ypyi4oCPDC3Ec",
            BasePath = "https://weather-application-35f1d-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eventForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("Internet Error");
            }
            textBoxDate.Text = Calender.static_month + "/" + UserControlDay.static_day + "/" + Calender.static_year;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Events events = new Events()
            {
                date = textBoxDate.Text,
                Event = textBoxEvent.Text
            };
            var set = client.Set(@"Events/", events);
            MessageBox.Show("Event Added");
            this.Close();
        }
    }
}
