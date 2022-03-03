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
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;

namespace WeatherForecast
{
    public partial class mainDashBoard : UserControl
    {
       
        
        public string api = "c3cf60022dfe56ff49aa0a20ec89558f";
        double lon;
        double lat;
        public string favFirstLocation = Properties.Settings.Default.favFirstPanelLoc1;
        public string favSecondLocation = Properties.Settings.Default.favFirstPanelLoc2;
        public string favThirdLocation = Properties.Settings.Default.favFirstPanelLoc3;
        public string favFourthLocation = Properties.Settings.Default.favFirstPanelLoc4;
        public string favFifthLocation = Properties.Settings.Default.favFirstPanelLoc5;
        public double deviceLon;
        public double deviceLat;
        public string tempratureMeter;
        public string S = "C";
        private GeoCoordinateWatcher Watcher = null;
        public mainDashBoard()
        {
            InitializeComponent();
          
        }
        void updatefromonload()
        {
            favLoc1.Text = favFirstLocation;
            favLoc2.Text = favSecondLocation;
            favLoc3.Text = favThirdLocation;
            favLoc4.Text = favFourthLocation;
            favLoc5.Text = favFifthLocation;
            if (Properties.Settings.Default.tempratureStatusCelcius == true)
            {
                S = "C";
                tempratureMeter = "metric";
            }
            else
            {
                S = "F";
                tempratureMeter = "imperial";
            }
        }
        void updateForecast(double Lon, double Lat)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=current,minutely,hourly,alerts&units={2}&appid={3}", Lat, Lon,tempratureMeter, api);
                var json = web.DownloadString(url);
                Weatherforecast.ForecastInfo ForecastInfo = JsonConvert.DeserializeObject<Weatherforecast.ForecastInfo>(json);
                WeatherIcon1.ImageLocation = "https://openweathermap.org/img/w/" + ForecastInfo.daily[0].weather[0].icon + ".png";
                lblDate1.Text = getDate(ForecastInfo.daily[0].dt).ToString("dd") + " " + getDate(ForecastInfo.daily[0].dt).ToString("ddd");
                lbltemp1.Text = ForecastInfo.daily[0].temp.max.ToString() + "/" + ForecastInfo.daily[0].temp.min.ToString() + "°" + S;

                WeatherIcon2.ImageLocation = "https://openweathermap.org/img/w/" + ForecastInfo.daily[1].weather[0].icon + ".png";
                lblDate2.Text = getDate(ForecastInfo.daily[1].dt).ToString("dd") + " " + getDate(ForecastInfo.daily[1].dt).ToString("ddd");
                lblTemp2.Text = ForecastInfo.daily[1].temp.max.ToString() + "/" + ForecastInfo.daily[1].temp.min.ToString() + "°" + S;

                WeatherIcon3.ImageLocation = "https://openweathermap.org/img/w/" + ForecastInfo.daily[2].weather[0].icon + ".png";
                lblDate3.Text = getDate(ForecastInfo.daily[2].dt).ToString("dd") + " " + getDate(ForecastInfo.daily[2].dt).ToString("ddd");
                lblTemp3.Text = ForecastInfo.daily[2].temp.max.ToString() + "/" + ForecastInfo.daily[2].temp.min.ToString() + "°" + S;

                WeatherIcon4.ImageLocation = "https://openweathermap.org/img/w/" + ForecastInfo.daily[3].weather[0].icon + ".png";
                lblDate4.Text = getDate(ForecastInfo.daily[3].dt).ToString("dd") + " " + getDate(ForecastInfo.daily[3].dt).ToString("ddd");
                lblTemp4.Text = ForecastInfo.daily[3].temp.max.ToString() + "/" + ForecastInfo.daily[3].temp.min.ToString() + "°" + S;

                WeatherIcon5.ImageLocation = "https://openweathermap.org/img/w/" + ForecastInfo.daily[4].weather[0].icon + ".png";
                lblDate5.Text = getDate(ForecastInfo.daily[4].dt).ToString("dd") + " " + getDate(ForecastInfo.daily[4].dt).ToString("ddd");
                lblTemp5.Text = ForecastInfo.daily[4].temp.max.ToString() + "/" + ForecastInfo.daily[4].temp.min.ToString() + "°" + S;

                WeatherIcon6.ImageLocation = "https://openweathermap.org/img/w/" + ForecastInfo.daily[5].weather[0].icon + ".png";
                lblDate6.Text = getDate(ForecastInfo.daily[5].dt).ToString("dd") + " " + getDate(ForecastInfo.daily[5].dt).ToString("ddd");
                lblTemp6.Text = ForecastInfo.daily[5].temp.max.ToString() + "/" + ForecastInfo.daily[5].temp.min.ToString() + "°" + S;

                WeatherIcon7.ImageLocation = "https://openweathermap.org/img/w/" + ForecastInfo.daily[6].weather[0].icon + ".png";
                lblDate7.Text = getDate(ForecastInfo.daily[6].dt).ToString("dd") + " " + getDate(ForecastInfo.daily[6].dt).ToString("ddd");
                lblTemp7.Text = ForecastInfo.daily[6].temp.max.ToString() + "/" + ForecastInfo.daily[6].temp.min.ToString() + "°" + S;
                
                WeatherIcon8.ImageLocation = "https://openweathermap.org/img/w/" + ForecastInfo.daily[7].weather[0].icon + ".png";
                lblDate8.Text = getDate(ForecastInfo.daily[7].dt).ToString("dd") + " " + getDate(ForecastInfo.daily[7].dt).ToString("ddd");
                lblTemp8.Text = ForecastInfo.daily[7].temp.max.ToString() + "/" + ForecastInfo.daily[7].temp.min.ToString() + "°" + S;

            }
        }

        void updateHourlyForecast(double Lon, double Lat)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=current,minutely,daily,alerts&units={2}&appid={3}", Lat, Lon,tempratureMeter, api);
                var json = web.DownloadString(url);
                hourlyForecast.HourlyForecast hourlyForecastInfo = JsonConvert.DeserializeObject<hourlyForecast.HourlyForecast>(json);
                WeatherIcon1.ImageLocation = "https://openweathermap.org/img/w/" + hourlyForecastInfo.hourly[0].weather[0].icon + ".png";
                lblDate1.Text = getDate(hourlyForecastInfo.hourly[0].dt).ToString("HH:mm");
                lbltemp1.Text = hourlyForecastInfo.hourly[0].temp.ToString() + "°" + S;

                WeatherIcon1.ImageLocation = "https://openweathermap.org/img/w/" + hourlyForecastInfo.hourly[2].weather[0].icon + ".png";
                lblDate2.Text = getDate(hourlyForecastInfo.hourly[2].dt).ToString("HH:mm");
                lblTemp2.Text = hourlyForecastInfo.hourly[2].temp.ToString() + "°" + S;

                WeatherIcon1.ImageLocation = "https://openweathermap.org/img/w/" + hourlyForecastInfo.hourly[5].weather[0].icon + ".png";
                lblDate3.Text = getDate(hourlyForecastInfo.hourly[5].dt).ToString("HH:mm");
                lblTemp3.Text = hourlyForecastInfo.hourly[5].temp.ToString() + "°" + S;

                WeatherIcon1.ImageLocation = "https://openweathermap.org/img/w/" + hourlyForecastInfo.hourly[8].weather[0].icon + ".png";
                lblDate4.Text = getDate(hourlyForecastInfo.hourly[8].dt).ToString("HH:mm");
                lblTemp4.Text = hourlyForecastInfo.hourly[8].temp.ToString() + "°" + S;

                WeatherIcon1.ImageLocation = "https://openweathermap.org/img/w/" + hourlyForecastInfo.hourly[11].weather[0].icon + ".png";
                lblDate5.Text = getDate(hourlyForecastInfo.hourly[11].dt).ToString("HH:mm");
                lblTemp5.Text = hourlyForecastInfo.hourly[11].temp.ToString() + "°" + S;

                WeatherIcon1.ImageLocation = "https://openweathermap.org/img/w/" + hourlyForecastInfo.hourly[14].weather[0].icon + ".png";
                lblDate6.Text = getDate(hourlyForecastInfo.hourly[14].dt).ToString("HH:mm");
                lblTemp6.Text = hourlyForecastInfo.hourly[14].temp.ToString() + "°" + S;

                WeatherIcon1.ImageLocation = "https://openweathermap.org/img/w/" + hourlyForecastInfo.hourly[17].weather[0].icon + ".png";
                lblDate7.Text = getDate(hourlyForecastInfo.hourly[17].dt).ToString("HH:mm");
                lblTemp7.Text = hourlyForecastInfo.hourly[17].temp.ToString() + "°" + S;

                WeatherIcon1.ImageLocation = "https://openweathermap.org/img/w/" + hourlyForecastInfo.hourly[20].weather[0].icon + ".png";
                lblDate8.Text = getDate(hourlyForecastInfo.hourly[20].dt).ToString("HH:mm");
                lblTemp8.Text = hourlyForecastInfo.hourly[20].temp.ToString() + "°" + S;
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
                try
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&units={1}&appid={2}", text,tempratureMeter, api);
                    var json = web.DownloadString(url);
                    WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                    lon = Info.coord.lon;
                    lat = Info.coord.lat;
                    lblForecastCity.Text = Info.name;
                }
                catch (WebException)
                {
                    MessageBox.Show("City does not exists!");
                }
            }
        }
        private void searchbtn_Click(object sender, EventArgs e)
        {
            string cityName = txtSearch.Text;

            using (WebClient web = new WebClient())
            {
                try
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&units={1}&appid={2}", cityName,tempratureMeter, api);
                    var json = web.DownloadString(url);
                    WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                    lon = Info.coord.lon;
                    lat = Info.coord.lat;
                }
                catch (WebException)
                {
                    MessageBox.Show("City does not exists!");
                }
                getcity(lon, lat);
                updateForecast(lon, lat);
                Chart(lon, lat);

            }
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                //Perform search
                string cityName = txtSearch.Text;

                using (WebClient web = new WebClient())
                {
                    try
                    {
                        string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&units={1}&appid={2}", cityName, tempratureMeter, api);
                        var json = web.DownloadString(url);
                        WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                        lon = Info.coord.lon;
                        lat = Info.coord.lat;
                    }
                    catch (WebException)
                    {
                        MessageBox.Show("City does not exists!");
                    }
                    getcity(lon, lat);
                    updateForecast(lon, lat);
                    Chart(lon, lat);

                }

            }
        }


        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            getLonLat(favFirstLocation);
            updateForecast(lon,lat);
            Chart(lon, lat);
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            getLonLat(favSecondLocation);
            updateForecast(lon, lat);
            Chart(lon, lat);
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            getLonLat(favThirdLocation);
            updateForecast(lon, lat);
            Chart(lon, lat);
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            getLonLat(favFourthLocation);
            updateForecast(lon, lat);
            Chart(lon, lat);
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            getLonLat(favFifthLocation);
            updateForecast(lon, lat);
            Chart(lon, lat);
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
                    /*label2.Text = deviceLon.ToString();
                    label6.Text = deviceLat.ToString();*/
                    getcity(deviceLon, deviceLat);
                    updateForecast(deviceLon, deviceLat);
                    Chart(deviceLon, deviceLat);
                }
            }
        }
        string getcity(double Lon, double Lat)
        {

            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&units={2}&appid={3}", Lat, Lon,tempratureMeter, api);

                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                lblForecastCity.Text = Info.name;
                return Info.name;
            }
        }
        private void mainDashBoard_Load(object sender, EventArgs e)
        {

           updatefromonload();
            Watcher = new GeoCoordinateWatcher();
            // Catch the StatusChanged event.
            Watcher.StatusChanged += Watcher_StatusChanged;
            // Start the watcher.
            Watcher.Start();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            updateHourlyForecast(lon, lat);
            ChartHourly(lon, lat);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            updateForecast(lon, lat);
            Chart(lon, lat);
        }
        
        void Chart(double Lon, double Lat)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=current,minutely,hourly,alerts&units={2}&appid={3}", Lat, Lon,tempratureMeter ,api);
                var json = web.DownloadString(url);
                Weatherforecast.ForecastInfo ForecastInfo = JsonConvert.DeserializeObject<Weatherforecast.ForecastInfo>(json);
                cartesianChart1.Series = new SeriesCollection
                {
                    new LineSeries
                    {
                        Title = getcity(Lon, Lat),
                        Values = new ChartValues<ObservablePoint>
                        {
                        new ObservablePoint(getDate(ForecastInfo.daily[0].dt).Day,ForecastInfo.daily[0].temp.max),
                        new ObservablePoint(getDate(ForecastInfo.daily[1].dt).Day,ForecastInfo.daily[1].temp.max),
                        new ObservablePoint(getDate(ForecastInfo.daily[2].dt).Day,ForecastInfo.daily[2].temp.max),
                        new ObservablePoint(getDate(ForecastInfo.daily[3].dt).Day,ForecastInfo.daily[3].temp.max),
                        new ObservablePoint(getDate(ForecastInfo.daily[4].dt).Day,ForecastInfo.daily[4].temp.max),
                        new ObservablePoint(getDate(ForecastInfo.daily[5].dt).Day,ForecastInfo.daily[5].temp.max),
                        new ObservablePoint(getDate(ForecastInfo.daily[6].dt).Day,ForecastInfo.daily[6].temp.max),
                        new ObservablePoint(getDate(ForecastInfo.daily[7].dt).Day,ForecastInfo.daily[7].temp.max),
                        },
                        PointGeometrySize = 40

                    }
                };
            }
        }

        void ChartHourly(double Lon, double Lat)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=current,minutely,daily,alerts&units={2}&appid={3}", Lat, Lon,tempratureMeter, api);
                var json = web.DownloadString(url);
                hourlyForecast.HourlyForecast hourlyForecastInfo = JsonConvert.DeserializeObject<hourlyForecast.HourlyForecast>(json);
                cartesianChart1.Series = new SeriesCollection
                {
                    new LineSeries
                    {
                        Title = getcity(Lon, Lat),
                        Values = new ChartValues<ObservablePoint>
                        {
                        new ObservablePoint(getDate(hourlyForecastInfo.hourly[0].dt).Hour,hourlyForecastInfo.hourly[0].temp),
                        new ObservablePoint(getDate(hourlyForecastInfo.hourly[2].dt).Hour,hourlyForecastInfo.hourly[2].temp),
                        new ObservablePoint(getDate(hourlyForecastInfo.hourly[5].dt).Hour,hourlyForecastInfo.hourly[5].temp),
                        new ObservablePoint(getDate(hourlyForecastInfo.hourly[8].dt).Hour,hourlyForecastInfo.hourly[8].temp),
                        new ObservablePoint(getDate(hourlyForecastInfo.hourly[11].dt).Hour,hourlyForecastInfo.hourly[11].temp),
                        new ObservablePoint(getDate(hourlyForecastInfo.hourly[14].dt).Hour,hourlyForecastInfo.hourly[14].temp),
                        new ObservablePoint(getDate(hourlyForecastInfo.hourly[17].dt).Hour,hourlyForecastInfo.hourly[17].temp),
                        new ObservablePoint(getDate(hourlyForecastInfo.hourly[20].dt).Hour,hourlyForecastInfo.hourly[20].temp),
                        },
                        PointGeometrySize = 40
                    }
                };
            }
        }
    }
}
