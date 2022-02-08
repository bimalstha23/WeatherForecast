using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Device.Location;

namespace WeatherForecast
{
    public partial class mainDashBoard : UserControl
    {
       
        
        public string api = "c3cf60022dfe56ff49aa0a20ec89558f";
        double lon;
        double lat;
        public string favFirstLocation = "Pokhara";
        public string favSecondLocation = "Kathmandu";
        public string favThirdLocation = "Lalitpur";
        public string favFourthLocation = "Bhaktapur";
        public string favFifthLocation = "Biratnagar";
        public double deviceLon;
        public double deviceLat;
        private GeoCoordinateWatcher Watcher = null;
        public mainDashBoard()
        {
            InitializeComponent();
        }
        void updateForecast(double Lon, double Lat)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=current,minutely,hourly,alerts&units=metric&appid={2}", Lat, Lon, api);
                var json = web.DownloadString(url);
                Weatherforecast.ForecastInfo ForecastInfo = JsonConvert.DeserializeObject<Weatherforecast.ForecastInfo>(json);

                lblDate1.Text = getDate(ForecastInfo.daily[0].dt).ToString("dd") + " " + getDate(ForecastInfo.daily[0].dt).ToString("ddd");
                lbltemp1.Text = ForecastInfo.daily[0].temp.min.ToString() + "/" + ForecastInfo.daily[0].temp.min.ToString();

                lblDate2.Text = getDate(ForecastInfo.daily[1].dt).ToString("dd") + " " + getDate(ForecastInfo.daily[1].dt).ToString("ddd");
                lblTemp2.Text = ForecastInfo.daily[1].temp.min.ToString() + "/" + ForecastInfo.daily[1].temp.min.ToString();

                lblDate3.Text = getDate(ForecastInfo.daily[2].dt).ToString("dd") + " " + getDate(ForecastInfo.daily[2].dt).ToString("ddd");
                lblTemp3.Text = ForecastInfo.daily[2].temp.min.ToString() + "/" + ForecastInfo.daily[2].temp.min.ToString();

                lblDate4.Text = getDate(ForecastInfo.daily[3].dt).ToString("dd") + " " + getDate(ForecastInfo.daily[3].dt).ToString("ddd");
                lblTemp4.Text = ForecastInfo.daily[3].temp.min.ToString() + "/" + ForecastInfo.daily[3].temp.min.ToString();

                lblDate5.Text = getDate(ForecastInfo.daily[4].dt).ToString("dd") + " " + getDate(ForecastInfo.daily[4].dt).ToString("ddd");
                lblTemp5.Text = ForecastInfo.daily[4].temp.min.ToString() + "/" + ForecastInfo.daily[4].temp.min.ToString();

                lblDate6.Text = getDate(ForecastInfo.daily[5].dt).ToString("dd") + " " + getDate(ForecastInfo.daily[5].dt).ToString("ddd");
                lblTemp6.Text = ForecastInfo.daily[5].temp.min.ToString() + "/" + ForecastInfo.daily[5].temp.min.ToString();

                lblDate7.Text = getDate(ForecastInfo.daily[6].dt).ToString("dd") + " " + getDate(ForecastInfo.daily[6].dt).ToString("ddd");
                lblTemp7.Text = ForecastInfo.daily[6].temp.min.ToString() + "/" + ForecastInfo.daily[6].temp.min.ToString();

                lblDate8.Text = getDate(ForecastInfo.daily[7].dt).ToString("dd") + " " + getDate(ForecastInfo.daily[7].dt).ToString("ddd");
                lblTemp8.Text = ForecastInfo.daily[7].temp.min.ToString() + "/" + ForecastInfo.daily[7].temp.min.ToString();

            }
        }
        DateTime getDate(double millisecound)
        {

            DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(millisecound).ToLocalTime();

            return day;
        }
        void getLonLat(string text)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&appid={1}", text, api);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                lon = Info.coord.lon;
                lat = Info.coord.lat;
                lblForecastCity.Text = Info.name;
            }
        }
        private void searchbtn_Click(object sender, EventArgs e)
        {
            string cityName = txtSearch.Text;

            using (WebClient web = new WebClient())
            {
                try
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&appid={1}", cityName, api);
                    var json = web.DownloadString(url);
                    WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                    lon = Info.coord.lon;
                    lat = Info.coord.lat;
                }
                catch (WebException)
                {
                    MessageBox.Show("City does not exists!");
                }
                updateForecast(lon, lat);

            }
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            WeatherMan mainForm;
            mainForm = (WeatherMan)this.FindForm();
            if (e.KeyCode == Keys.Enter)
            {
                //Perform search
                string cityName = txtSearch.Text;

                using (WebClient web = new WebClient())
                {
                    try
                    {
                        string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&appid={1}", cityName,mainForm.APIkey);
                        var json = web.DownloadString(url);
                        WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                        lon = Info.coord.lon;
                        lat = Info.coord.lat;
                    }
                    catch (WebException)
                    {
                        MessageBox.Show("City does not exists!");
                    }
                    updateForecast(lon, lat);

                }

            }
        }


        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            getLonLat(favFirstLocation);
            updateForecast(lon,lat);
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            getLonLat(favSecondLocation);
            updateForecast(lon, lat);
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            getLonLat(favThirdLocation);
            updateForecast(lon, lat);
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            getLonLat(favFourthLocation);
            updateForecast(lon, lat);
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            getLonLat(favFifthLocation);
            updateForecast(lon, lat);
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
                    label2.Text = deviceLon.ToString();
                    label6.Text = deviceLat.ToString();
                    getcity(deviceLon, deviceLat);
                    updateForecast(deviceLon, deviceLat);
                }
            }
        }
        void getcity(double Lon, double Lat)
        {

            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&units=metric&appid={2}", Lat, Lon, api);

                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                lblForecastCity.Text = Info.name;
            }
        }
        private void mainDashBoard_Load(object sender, EventArgs e)
        {
            Watcher = new GeoCoordinateWatcher();
            // Catch the StatusChanged event.
            Watcher.StatusChanged += Watcher_StatusChanged;
            // Start the watcher.
            Watcher.Start();
        }
    }
}
