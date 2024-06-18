using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using PricesAndroid.Models;
using Newtonsoft.Json;
using System.Net.Http.Json;
using PricesAndroid.Services.Interfaces;

namespace PricesAndroid.Services.TetraServices
{
    public class RequestDataStore : IDataStore<Request>
    {
        private readonly string url;

        public RequestDataStore(string url)
        {
            this.url = url;
        }

        public async Task<bool> AddItemAsync(Request item)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PostAsJsonAsync($"{url}/Api/DAL/Requests/AddRequest", item))
                {
                    return response.IsSuccessStatusCode;
                }
            }
        }

        public async Task<IEnumerable<Request>> GetItemsAsync(bool forceRefresh = false)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"{url}/Api/DAL/Requests/GetAllRequests"))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<IEnumerable<Request>>(apiResponse);
                }
            }
        }

        public Task<bool> UpdateItemAsync(Request item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Request> GetItemAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
