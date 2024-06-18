using PricesAndroid.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PricesAndroid.Services.TestServices
{
    public class TestCitiesService : ICitiesService
    {
        public Task<IEnumerable<string>> GetCitiesAsync()
        {
            var cities = new List<string>
            {
                "Тюмень",
                "Когалым",
                "Курган",
                "Сургут",
                "Тобольск",
                "Москва",
                "Кушва",
                "Сочи",
                "Лангепас",
                "Урай",
                "Калининград",
                "Краснодар",
                "Покачи",
                "Новосибирск",
                "Омск",
                "Казань",
            }.AsEnumerable();

            return Task.FromResult(cities);
        }
    }
}
