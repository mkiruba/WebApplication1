using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace WebApplication1.Models
{
    public class SearchInput
    {
        public string Area { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        [JsonProperty("lon_min")]
        public double LongitudeMin { get; set; }
        [JsonProperty("lon_max")]
        public double LongitudeMax { get; set; }
        [JsonProperty("lat_max")]
        public double LatitudeMax { get; set; }
        [JsonProperty("lat_min")]
        public double LatitudeMin { get; set; }
        [JsonProperty("output_type")]
        public string OutputType { get; set; }
        public decimal Radius { get; set; }
        [JsonProperty("order_by")]
        public string OrderBy { get; set; }
        public string Ordering { get; set; }
        [JsonProperty("listing_status")]
        public string ListingStatus { get; set; }
        [JsonProperty("include_sold")]
        public int IncludeSold { get; set; }
        [JsonProperty("include_rented")]
        public int IncludeRented { get; set; }
        [JsonProperty("minimum_price")]
        public decimal MinimumPrice { get; set; }
        [JsonProperty("maximum_price")]
        public decimal MaximumPrice { get; set; }
        [JsonProperty("minimum_beds")]
        public int MinimumBeds { get; set; }
        [JsonProperty("maximum_beds")]
        public int MaximumBeds { get; set; }
        public string Furnished { get; set; }
        [JsonProperty("property_type")]
        public string PropertyType { get; set; }
        [JsonProperty("new_homes")]
        public bool NewHomes { get; set; }
        [JsonProperty("chain_free")]
        public bool ChainFree { get; set; }
        public string Keywords { get; set; }
        [JsonProperty("listing_id")]
        public long ListingId { get; set; }
        [JsonProperty("branch_id")]
        public long BranchId { get; set; }
        [JsonProperty("page_number")]
        public int PageNumber { get; set; }
        [JsonProperty("page_size")]
        public int PageSize { get; set; }
        public bool Summarised { get; set; }
    }
}