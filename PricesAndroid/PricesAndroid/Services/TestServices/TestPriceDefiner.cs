using PricesAndroid.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace PricesAndroid.Services.TestServices
{
    internal class TestPriceDefiner : IPriceDefiner
    {
        public Task<double> GetPriceAsync(int weight, string city)
        {
            throw new NotImplementedException();
        }
    }
}
