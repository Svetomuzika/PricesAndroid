using PricesAndroid.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PricesAndroid.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignInPage : ContentPage
    {
        public SignInPage(SignInViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}