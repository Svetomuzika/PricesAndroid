using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PricesAndroid.Models;
using PricesAndroid.Services.Interfaces;

namespace PricesAndroid.Services.TetraServices
{
    public class AuthService : IAuthService
    {
        private readonly string url;

        public AuthService(string url)
        {
            this.url = url;
        }

        public async Task<UserInfo> GetUserAsync(int userId)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"{url}/Api/DAL/Auth/Client?data={userId}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<UserInfo>(apiResponse);
                }
            }
        }

        public Task<bool> RegisterUserAsync(string email, string passwordHash, UserInfo userInfo)
        {
            throw new NotImplementedException();
        }
    }
}
