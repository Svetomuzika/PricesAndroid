using PricesAndroid.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PricesAndroid.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RequestsPage : ContentPage
    {
        public RequestsPage(RequestsViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}