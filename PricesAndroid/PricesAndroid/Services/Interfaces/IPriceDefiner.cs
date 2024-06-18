using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PricesAndroid.Services.Interfaces
{
    public interface IPriceDefiner
    {
        Task<double> GetPriceAsync(int weight, string city);
    }
}
