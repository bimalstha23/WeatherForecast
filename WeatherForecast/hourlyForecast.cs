using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    internal class hourlyForecast
    {
        public class weather
        {
            public string icon { get; set; }

        }
        public class hourly
        {
            public long dt { get; set; }
            public double temp { get; set; }
            public List<weather> weather { get; set; }

        }
        public class HourlyForecast
        {
            public List<hourly> hourly { get; set; }
        }
    }
}
