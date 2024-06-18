using PricesAndroid.Views;
using Xamarin.Forms;

namespace PricesAndroid.Utilities.RouteFactories
{
    public class UserProfilePageRouteFactory : RouteFactory
    {
        private readonly UserProfilePage page;

        public UserProfilePageRouteFactory(UserProfilePage page)
        {
            this.page = page;
        }

        public override Element GetOrCreate()
        {
            return page;
        }
    }
}
