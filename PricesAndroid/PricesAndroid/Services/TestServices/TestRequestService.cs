using PricesAndroid.Models;
using PricesAndroid.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PricesAndroid.Services.TestServices
{
    public class TestRequestService : IRequestService
    {
        public Task<bool> CreateRequestAsync(Request request)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Request>> GetRequestsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
