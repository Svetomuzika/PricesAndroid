using PricesAndroid.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Bson;
using PricesAndroid.Services;

namespace PricesAndroid.ViewModels
{
    public class RequestsViewModel : BaseViewModel
    {
        private ObservableCollection<Request> _requestsList;
        private string _searchQuery;

        public ObservableCollection<Request> RequestsList
        {
            get => _requestsList;
            set => SetProperty(ref _requestsList, value);
        }

        public string SearchQuery
        {
            get => _searchQuery;
            set
            {
                RequestsList = GetSearchResults(value);
            }
        }

        private UserInfo user;

        public RequestsViewModel()
        {
            App.UserChanged += OnUserChanged;
        }

        public ObservableCollection<Request> GetSearchResults(string query)
        {
            var newList = RequestsList
                .Where(e => e.SearchHelper.ToLower().Contains(query.ToLower()));

            return new ObservableCollection<Request>(newList);
        }

        private void RefreshRequests()
        {
            if (user.Requests == null)
            {
                RequestsList = new ObservableCollection<Request>();
                return;
            }

            RequestsList = new ObservableCollection<Request>(user.Requests);
        }

        private void OnUserChanged(UserChangedEventArgs args)
        {
            user = args.NewUserInfo;

            RefreshRequests();
        }
    }
}
