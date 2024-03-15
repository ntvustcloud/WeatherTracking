using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_TanVu_Nguyen
{
    public class WeatherInfo
    {
        public int id { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public DateTime date { get; set; }
        public double temperature { get; set; }
        public int humidity { get; set; }
        public string sunrise { get; set; }
        public string sunset { get; set; }
        public bool cloudy { get; set; }
        public bool windy { get; set; }
        public bool rainy { get; set; }
               
    }
}
