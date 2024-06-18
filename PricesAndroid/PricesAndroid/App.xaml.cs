using Autofac;
using PricesAndroid.Models;
using PricesAndroid.Services.DI;
using PricesAndroid.Services.Interfaces;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace PricesAndroid
{
    public class UserChangedEventArgs
    {
        public UserInfo NewUserInfo { get; }

        public UserChangedEventArgs(UserInfo newUserInfo)
        {
            NewUserInfo = newUserInfo;
        }
    }

    public partial class App : Application
    {
        public delegate void UserChangedEventHandler(UserChangedEventArgs args);
        public static event UserChangedEventHandler UserChanged;

        private UserInfo _userInfo;
        public UserInfo UserInfo
        {
            get => _userInfo;
            set
            {
                if(value == _userInfo) return;

                _userInfo = value;
                UserChanged?.Invoke(new UserChangedEventArgs(value));
            }
        }

        private readonly IContainer container;

        public App()
        {
            InitializeComponent();

            container = AutofacConfig.GetConfiguredContainer();
            // установка сопоставителя зависимостей
            DependencyResolver.ResolveUsing(type => container.IsRegistered(type) ? container.Resolve(type) : null);

            MainPage = DependencyService.Resolve<AppShell>();
        }

        protected override async void OnStart()
        {
            //Игнор темы системы(всегда светлая)
            Current.UserAppTheme = OSAppTheme.Light;

            Task.Run(() =>
            {
                UserInfo = DependencyService.Resolve<IAuthService>().GetUserAsync(1).Result;
            });
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
