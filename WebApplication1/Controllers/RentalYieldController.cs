using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
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

        [Route("api/RentalYield/{postCode}/{area}")]
        public IHttpActionResult GetRentalYield(string postCode, string area)
        {
            //string response;
          using (var client = new HttpClient())
          {
            //client.BaseAddress = new Uri(baseurl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var uri = $"{baseurl}{apiurl}?postcode={postCode}&area={area}&api_key={apiKey}";
                // New code:
                //http://api.zoopla.co.uk/api/v1/property_listings.json?postcode=IG101TH&area=Loughton&listing_status=sale&api_key=psuy4qtt4u6nfy5r6mtrxdb9
                //http://api.zoopla.co.uk/api/v1/property_listings.json?postcode=IG101TH&area=Loughton&listing_status=rent&api_key=psuy4qtt4u6nfy5r6mtrxdb9
                //response = client.DownloadString(uri);
                HttpResponseMessage response = client.GetAsync(uri).Result;
            if (response.IsSuccessStatusCode)
            {
              var propertyListing = response.Content.ReadAsAsync<PropertyListings>().Result;
              foreach (var listing in propertyListing.Listings)
              {
                //Call your store method and pass in your own object
                //SaveCustomObjectToDB(x);
              }
            }
            else
            {
              //Something has gone wrong, handle it here
                return BadRequest("Unable to get json.");
            }
          }

          return Ok("Success");
        }
    }
}
