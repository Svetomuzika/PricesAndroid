using PricesAndroid.Models;
using PricesAndroid.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace PricesAndroid.Services.TestServices
{
    internal class TestAuthService : IAuthService
    {
        public Task<UserInfo> GetUserAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterUserAsync(string email, string passwordHash, UserInfo userInfo)
        {
            throw new NotImplementedException();
        }
    }
}
