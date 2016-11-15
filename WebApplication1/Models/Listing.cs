﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
  public class Listing
  {
        [JsonProperty("num_floors")]
        public int NumFloors { get; set; }
        [JsonProperty("listing_status")]
        public string ListingStatus { get; set; }
        [JsonProperty("num_bedrooms")]
        public int NumBedrooms { get; set; }
        public double Latitude { get; set; }
        [JsonProperty("agent_address")]
        public string AgentAddress { get; set; }
        [JsonProperty("property_type")]
        public string PropertyType { get; set; }
        public double Longitude { get; set; }
        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }
        public string Description { get; set; }
        [JsonProperty("post_town")]
        public string PostTown { get; set; }
        [JsonProperty("details_url")]
        public string DetailsUrl { get; set; }
        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }
        public string Outcode { get; set; }
        [JsonProperty("property_report_url")]
        public string PropertyReportUrl { get; set; }
        public string County { get; set; }
        public decimal Price { get; set; }
        [JsonProperty("listing_id")]
        public long ListingId { get; set; }
        [JsonProperty("image_caption")]
        public string ImageCaption { get; set; }
        public string Status { get; set; }
        [JsonProperty("agent_name")]
        public string AgentName { get; set; }
        [JsonProperty("num_recepts")]
        public int NumRecepts { get; set; }
        public string Country { get; set; }
        [JsonProperty("displayable_address")]
        public string DisplayableAddress { get; set; }
        [JsonProperty("first_published_date")]
        public DateTime FirstPublishedDate { get; set; }
        [JsonProperty("floor_plan")]
        public List<string> FloorPlans { get; set; }
        [JsonProperty("street_name")]
        public string StreetName { get; set; }
        [JsonProperty("num_bathrooms")]
        public int NumBathrooms { get; set; }
        [JsonProperty("price_change")]
        public List<PriceChange> PriceChanges { get; set; }
        [JsonProperty("agent_logo")]
        public string AgentLogo { get; set; }
        [JsonProperty("agent_phone")]
        public string AgentPhone { get; set; }
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
        [JsonProperty("last_published_date")]
        public DateTime LastPublishedDate { get; set; }
  }
}