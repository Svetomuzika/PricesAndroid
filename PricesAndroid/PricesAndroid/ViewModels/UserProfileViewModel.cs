using PricesAndroid.Models;

namespace PricesAndroid.ViewModels
{
    public class UserProfileViewModel : BaseViewModel
    {
        private UserInfo _user;

        public UserProfileViewModel()
        {
            App.UserChanged += OnUserChanged;
        }

        private void OnUserChanged(UserChangedEventArgs args)
        {
            _user = args.NewUserInfo;
        }
    }
}
