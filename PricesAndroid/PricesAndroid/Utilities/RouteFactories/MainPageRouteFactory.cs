using PricesAndroid.Views;
using Xamarin.Forms;

namespace PricesAndroid.Utilities.RouteFactories
{
    public class MainPageRouteFactory : RouteFactory
    {
        private readonly MainPage page;

        public MainPageRouteFactory(MainPage page)
        {
            this.page = page;
        }

        public override Element GetOrCreate()
        {
            return page;
        }
    }
}
