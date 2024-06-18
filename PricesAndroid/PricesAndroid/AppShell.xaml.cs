using PricesAndroid.Utilities.RouteFactories;
using PricesAndroid.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PricesAndroid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public Element RequestsPageContent
            => Routing.GetOrCreateContent(nameof(RequestsPage));

        public Element EstimationPageContent
            => Routing.GetOrCreateContent(nameof(MainPage));

        public Element ProfilePageContent
            => Routing.GetOrCreateContent(nameof(UserProfilePage));

        public AppShell(MainPageRouteFactory mainPageFac,
            RequestsPageRouteFactory reqPageFac,
            UserProfilePageRouteFactory userPageFac)
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(RequestsPage), reqPageFac);
            Routing.RegisterRoute(nameof(MainPage), mainPageFac);
            Routing.RegisterRoute(nameof(UserProfilePage), userPageFac);

            Requests.Content = RequestsPageContent;
            Estimation.Content = EstimationPageContent;
            Profile.Content = ProfilePageContent;

            //Задаем стартовую страницу
            CurrentItem = Estimation;
        }
    }
}