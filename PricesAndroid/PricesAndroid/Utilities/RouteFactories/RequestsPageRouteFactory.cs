using PricesAndroid.Views;
using Xamarin.Forms;

namespace PricesAndroid.Utilities.RouteFactories
{
    public class RequestsPageRouteFactory : RouteFactory
    {
        private readonly RequestsPage page;

        public RequestsPageRouteFactory(RequestsPage page)
        {
            this.page = page;
        }

        public override Element GetOrCreate()
        {
            return page;
        }
    }
}
