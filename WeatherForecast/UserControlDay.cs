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
    public partial class UserControlDay : UserControl
    {
        public static string static_day;
        public UserControlDay()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "vDbkplFbNLdyWsjLBpieDvuJCx6ypyi4oCPDC3Ec",
            BasePath = "https://weather-application-35f1d-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void UserControlDay_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("Connection Error!");
            }
            /*displayEvent();*/
        }
        public void days(int numday)
        {
            lblDay.Text = numday.ToString();
        }

        private void UserControlDay_Click(object sender, EventArgs e)
        {
            
            static_day = lblDay.Text;
            timer1.Start();
            eventForm eventForm = new eventForm();
            eventForm.Show();
        }
        void displayEvent()
        {   
                var res = client.Get(@"students/" + Calender.static_month + "-" + static_day + "-" + Calender.static_year);
                Events events = res.ResultAs<Events>();
                if (events != null)
                {
                Eventlabel.Text = events.Event.ToString();
                }
            
             }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*displayEvent();*/
        }
    }
}
