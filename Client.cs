using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace RateBeer
{
    public class Client
    {
        public async Task<Models.Response> SearchForBeer(string upc)
        {           
            if (_client == null)
                _client = new HttpClient();

            Models.Response model;

            // http://www.ratebeer.com/json/upc.asp?upc=5411681014005&k=2e1ob20b6n0gc999r -For Duvel
            var url = string.Format("http://www.ratebeer.com/json/upc.asp?upc={0}&k=2e1ob20b6n0gc999r", upc);
            var response = await _client.GetAsync(url);

            var jsonString = response.Content.ReadAsStringAsync();
            jsonString.Wait();
            var list = JsonConvert.DeserializeObject<List<Models.Response>>(jsonString.Result);
            model = list.FirstOrDefault();

            return model;    
        }

        HttpClient _client;
    }
}

