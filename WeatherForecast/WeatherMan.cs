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
using System.Device.Location;
using Newtonsoft.Json;

namespace WeatherForecast
{
    public partial class WeatherMan : Form
    {
        public string APIkey = "c3cf60022dfe56ff49aa0a20ec89558f";

        public  double deviceLon;
        public  double deviceLat;
        public string deviceLocation;
        private GeoCoordinateWatcher Watcher = null;
        public WeatherMan()
        {
            InitializeComponent();
            mainDashBoard dashBoard = new mainDashBoard();
            addUserControl(dashBoard);
            activeContainerPanel.Height = btndashboard.Height;
            
        }
        private void addUserControl(UserControl userControl)
        {   userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btndashboard_Click(object sender, EventArgs e)
        {
            activeContainerPanel.Height = btndashboard.Height;
            
            activeContainerPanel.Top = btndashboard.Top;
            mainDashBoard dashBoard = new mainDashBoard();
            addUserControl(dashBoard);
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            activeContainerPanel.Height = btnCalender.Height;
            
            activeContainerPanel.Top = btnCalender.Top;
            Calender calender = new Calender();
            addUserControl(calender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            activeContainerPanel.Height = button3.Height;
            
            activeContainerPanel.Top = button3.Top;
            Settings settings = new Settings();
            addUserControl(settings);
        }
        void gettime()
        {
            timetxt.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        void getdate()
        {
            datetxt.Text = DateTime.Now.ToString("MM / dd / yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getdate();
            gettime();
        }
        private void Watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            if (e.Status == GeoPositionStatus.Ready)
            {
                // Display the latitude and longitude.
                if (Watcher.Position.Location.IsUnknown)
                {
                    Console.WriteLine("Cannot find location data");
                }
                else
                {
                    deviceLat = Watcher.Position.Location.Latitude;
                    deviceLon = Watcher.Position.Location.Longitude;

                }
            }
        }
        void updateweather(double Lon, double Lat)
        {

            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&units=metric&appid={2}", Lat, Lon, APIkey);

                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                currentweathericon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                lblHumidity.Text = Info.main.humidity.ToString();
                lblTemp.Text = Convert.ToInt32(Info.main.temp).ToString();
                lblVisibility.Text = Info.visibility.ToString();
                lblCountry.Text = Info.sys.country;
                lblCityname.Text = Info.name;
                lblPressure.Text = Info.main.pressure.ToString();
                lblWindspeed.Text = Info.wind.speed.ToString();
                deviceLocation = Info.name;
            }
        }

        private void WeatherMan_Load_1(object sender, EventArgs e)
        {
            Watcher = new GeoCoordinateWatcher();
            // Catch the StatusChanged event.
            Watcher.StatusChanged += Watcher_StatusChanged;

            // Start the watcher.
            Watcher.Start();
            updateweather(deviceLon, deviceLat);
            timer1.Start();
        }

        private void WeatherMan_Shown(object sender, EventArgs e)
        {
            updateweather(deviceLon, deviceLat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
