using PricesAndroid.ViewModels;
using Xamarin.Forms;

namespace PricesAndroid.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel vm)
        {
            InitializeComponent();

            BindingContext = vm;
        }
    }
}