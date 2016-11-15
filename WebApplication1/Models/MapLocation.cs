using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace WebApplication1.Models
{
  public class MapLocation
  {
        [JsonProperty("longitude_min")]
        public double LongitudeMin { get; set; }
        [JsonProperty("longitude_max")]
        public double LongitudeMax { get; set; }
        [JsonProperty("latitude_max")]
        public double LatitudeMax { get; set; }
        [JsonProperty("latitude_min")]
        public double LatitudeMin { get; set; }
  }
}