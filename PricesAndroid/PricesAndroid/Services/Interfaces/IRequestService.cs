using PricesAndroid.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PricesAndroid.Services.Interfaces
{
    public interface IRequestService
    {
        Task<IEnumerable<Request>> GetRequestsAsync();
        Task<bool> CreateRequestAsync(Request request);
    }
}
