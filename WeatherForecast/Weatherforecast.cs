using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    internal class Weatherforecast
    {
        public class temp
        {
            public double day { get; set; }
            public double min { get; set; }
            public double max { get; set; }
        }
        public class weather
        {
            public string icon { get; set; }
        }
        public class daily
        {
            public long dt { get; set; }
            public temp temp { get; set; }
            public List<weather> weather { get; set; }
        }
        public class ForecastInfo
        {
            public List<daily> daily { get; set; }
        }

    }
}
