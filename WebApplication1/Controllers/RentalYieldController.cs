using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using System.Web.Http.Results;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RentalYieldController : ApiController
    {
        private const string apiKey = "psuy4qtt4u6nfy5r6mtrxdb9";
        private const string baseurl = "http://api.zoopla.co.uk";
    private const string localUrl = @"C:\Kiru\Zoopla Json\property_listings.json";
    private const string apiurl = "/api/v1/property_listings.json";
        //private const string postcode = "IG10";
        //private const string area = "Loughton";

        [HttpPost]
        [Route("api/RentalYield")]
        public decimal GetRentalYield(SearchInput input)
        {
            
            decimal averagePrice;
            decimal averageRent;
            decimal rentalYield;
            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri(baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                averagePrice = GetAveragePrice(input, "sale");
                averageRent = GetAveragePrice(input, "rent");
                rentalYield = ((averageRent * 12) / averagePrice) * 100;
            }

            return rentalYield;
        }

        private static decimal GetAveragePrice(SearchInput input, string listingStatus)
        {
            PropertyListings propertyListing = null;
            decimal averagePrice;
            input.ListingStatus = listingStatus;
            var uri = BuildUri(input);
            // New code:
            //http://api.zoopla.co.uk/api/v1/property_listings.json?postcode=IG101TH&area=Loughton&listing_status=sale&api_key=psuy4qtt4u6nfy5r6mtrxdb9
            //http://api.zoopla.co.uk/api/v1/property_listings.json?postcode=IG101TH&area=Loughton&listing_status=rent&api_key=psuy4qtt4u6nfy5r6mtrxdb9
            //response = client.DownloadString(uri);
            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri(baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync(uri).Result;
                if (response.IsSuccessStatusCode)
                {
                    propertyListing = response.Content.ReadAsAsync<PropertyListings>().Result;
                    averagePrice =
                            propertyListing.Listings.Where(x => x.ListingStatus == listingStatus)
                                .Select(x => x.Price)
                                .Average();

                }
                else
                {
                    //Something has gone wrong, handle it here
                    throw new ApplicationException("Unable to get json.");
                }
            }
            
            return averagePrice;
        }

        

        private static string BuildUri(SearchInput input)
        {
            var uri = new StringBuilder();
            uri.Append($"{baseurl}{apiurl}?api_key={apiKey}");

            if (!string.IsNullOrEmpty(input.Area))
            {
                uri.Append($"&area={input.Area}");
            }
            if (!string.IsNullOrEmpty(input.Street))
            {
                uri.Append($"&street={input.Street}");
            }
            if (!string.IsNullOrEmpty(input.Town))
            {
                uri.Append($"&town={input.Town}");
            }
            if (!string.IsNullOrEmpty(input.County))
            {
                uri.Append($"&county={input.County}");
            }
            if (!string.IsNullOrEmpty(input.PostCode))
            {
                uri.Append($"&postcode={input.PostCode}");
            }
            if (!string.IsNullOrEmpty(input.Country))
            {
                uri.Append($"&country={input.Country}");
            }
            if (input.Longitude > 0)
            {
                uri.Append($"&longitude={input.Longitude}");
            }
            if (input.Latitude > 0)
            {
                uri.Append($"&latitude={input.Latitude}");
            }
            if (input.LongitudeMin > 0)
            {
                uri.Append($"&lon_min={input.LongitudeMin}");
            }
            if (input.LatitudeMin > 0)
            {
                uri.Append($"&lat_min={input.LatitudeMin}");
            }
            if (input.LongitudeMax > 0)
            {
                uri.Append($"&lon_max={input.LongitudeMax}");
            }
            if (input.LatitudeMax > 0)
            {
                uri.Append($"&lat_max={input.LatitudeMax}");
            }
            if (!string.IsNullOrEmpty(input.OutputType))
            {
                uri.Append($"&output_type={input.OutputType}");
            }
            if (input.Radius > 0)
            {
                uri.Append($"&radius={input.Radius}");
            }
            if (!string.IsNullOrEmpty(input.OrderBy))
            {
                uri.Append($"&order_by={input.OrderBy}");
            }
            if (!string.IsNullOrEmpty(input.Ordering))
            {
                uri.Append($"&ordering={input.Ordering}");
            }
            if (!string.IsNullOrEmpty(input.ListingStatus))
            {
                uri.Append($"&listing_status={input.ListingStatus}");
            }
            if (input.IncludeSold > 0)
            {
                uri.Append($"&include_sold={input.IncludeSold}");
            }
            if (input.IncludeRented > 0)
            {
                uri.Append($"&include_rented={input.IncludeRented}");
            }
            if (input.MinimumPrice > 0)
            {
                uri.Append($"&minimum_price={input.MinimumPrice}");
            }
            if (input.MaximumPrice > 0)
            {
                uri.Append($"&maximum_price={input.MaximumPrice}");
            }
            if (input.MinimumBeds > 0)
            {
                uri.Append($"&minimum_beds={input.MinimumBeds}");
            }
            if (input.MaximumBeds > 0)
            {
                uri.Append($"&maximum_beds={input.MaximumBeds}");
            }
            if (!string.IsNullOrEmpty(input.Furnished))
            {
                uri.Append($"&furnished={input.Furnished}");
            }
            if (!string.IsNullOrEmpty(input.PropertyType))
            {
                uri.Append($"&property_type={input.PropertyType}");
            }
            uri.Append($"&chain_free={input.ChainFree.ToString()}");
            uri.Append($"&newhomes={input.NewHomes.ToString()}");
            if (!string.IsNullOrEmpty(input.Keywords))
            {
                uri.Append($"&keywords={input.Keywords}");
            }
            if (input.ListingId > 0)
            {
                uri.Append($"&listing_id={input.ListingId}");
            }
            if (input.BranchId > 0)
            {
                uri.Append($"&branch_id={input.BranchId}");
            }
            if (input.PageNumber > 0)
            {
                uri.Append($"&page_number={input.PageNumber}");
            }
            if (input.PageSize > 0)
            {
                uri.Append($"&page_size={input.PageSize}");
            }
            uri.Append($"&summarised={input.Summarised.ToString()}");

            return uri.ToString();
        }
    }
}
