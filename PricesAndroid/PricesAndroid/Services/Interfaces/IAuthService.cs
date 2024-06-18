using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PricesAndroid.Models;

namespace PricesAndroid.Services.Interfaces
{
    public interface IAuthService
    {
        Task<bool> RegisterUserAsync(string email, string passwordHash, UserInfo userInfo);
        Task<UserInfo> GetUserAsync(int userId);

    }
}
