using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class RentalYieldController : ApiController
    {
        private const string apiKey = "psuy4qtt4u6nfy5r6mtrxdb9";
        private const string baseurl = "http://api.zoopla.co.uk";
        private const string apiurl = "/api/v1/property_listings.json";
        //private const string postcode = "IG10";
        //private const string area = "Loughton";

        [Route("api/RentalYield/{postCode}/{area}")]
        public string GetRentalYield(string postCode, string area)
        {
            string response;
            using (var client = new WebClient())
            {
                //client.BaseAddress = new Uri(baseurl);
                //client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var uri = $"{baseurl}{apiurl}?postcode={postCode}&area={area}&api_key={apiKey}";
                // New code:
                response = client.DownloadString(uri);
                //if (response.IsSuccessStatusCode)
                //{
                //    //var dataObjects = response.Content.ReadAsAsync().Result;
                //    //foreach (var d in dataObjects)
                //    //{
                //    //    Console.WriteLine("{0}", d.Name);
                //    //}
                //}
            }
            return response;
        }
    }
}
