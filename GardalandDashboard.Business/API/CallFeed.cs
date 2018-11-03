using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace GardalandDashboard.Business.API
{
    public class CallFeed
    {

        public static API.AttractionTimeResponseModel GetAttractions(string userAgent, string signature, string apiURL)
        {
            using (var http = new HttpClient())
            {

                // add the user-agent as header
                http.DefaultRequestHeaders.Add("User-Agent", userAgent);

                // add the data on the request
                var data = new API.AttractionTimeRequestModel
                {
                    signature = signature
                };

                var content = new StringContent(JsonConvert.SerializeObject(data));

                // make the requeste
                var request = http.PostAsync(apiURL, content);

                // get and deserealize the response
                var response = request.Result.Content.ReadAsStringAsync().Result;
                var responseDeserialized = JsonConvert.DeserializeObject<API.AttractionTimeResponseModel>(response);

                return responseDeserialized;

            }

        }

    }

}