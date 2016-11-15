using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.Models
{
    public class PropertyListings
    {
        public string Country { get; set; }
        [JsonProperty("result_count")]
        public string ResultCount { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        [JsonProperty("area_name")]
        public string AreaName { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        [JsonProperty("bounding_box")]
        public MapLocation BoundingBox { get; set; }
        [JsonProperty("listing")]
        public List<Listing> Listings { get; set; }

    }
}