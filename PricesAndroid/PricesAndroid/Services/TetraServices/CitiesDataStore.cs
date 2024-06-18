using Newtonsoft.Json;
using PricesAndroid.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PricesAndroid.Services.TetraServices
{
    public class CitiesDataStore : IDataStore<string>
    {
        private readonly string url;

        public CitiesDataStore(string url)
        {
            this.url = url;
        }

        public Task<bool> AddItemAsync(string item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<string>> GetItemsAsync(bool forceRefresh = false)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"{url}/Api/DAL/Stavki/GetAllPuncts"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<IEnumerable<string>>(apiResponse);
                }
            }
        }

        public Task<bool> UpdateItemAsync(string item)
        {
            throw new NotImplementedException();
        }
    }
}
