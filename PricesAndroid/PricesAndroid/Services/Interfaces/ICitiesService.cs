using System.Collections.Generic;
using System.Threading.Tasks;

namespace PricesAndroid.Services.Interfaces
{
    public interface ICitiesService
    {
        Task<IEnumerable<string>> GetCitiesAsync();
    }
}
