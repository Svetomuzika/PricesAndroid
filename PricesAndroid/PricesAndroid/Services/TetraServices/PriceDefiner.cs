using Newtonsoft.Json;
using PricesAndroid.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PricesAndroid.Services.TetraServices
{
    public class PriceDefiner : IPriceDefiner
    {
        private readonly string url;

        public PriceDefiner(string url)
        {
            this.url = url;
        }

        public async Task<double> GetPriceAsync(int weight, string city)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"{url}/Api/DAL/Requests/GetRequestSum?weight={weight}&city={city}"))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<double>(apiResponse);
                }
            }
        }
    }
}
