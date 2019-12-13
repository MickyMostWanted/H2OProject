using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace H2ODAS.ViewModels
{

    public class HomePageViewModel : ViewModelBase
    {
        private DelegateCommand _orderCommand;
        private INavigationService _navigation;

        public DelegateCommand OrderCommand =>
            _orderCommand ?? (_orderCommand = new DelegateCommand(ExecuteSignUpCommand));


        private DelegateCommand _offlineCommand;

        public DelegateCommand OfflineCommand =>
            _offlineCommand ?? (_offlineCommand = new DelegateCommand(ExecuteOfflineCommand));
        void ExecuteSignUpCommand()
        {
            NavigationService.NavigateAsync("OrderPage1");
        }
        void ExecuteOfflineCommand()
        {
            NavigationService.NavigateAsync("OfflinePage1");
        }

        public HomePageViewModel(INavigationService navigation) : base(navigation)
        {
            _navigation = navigation;
        }
      
        
    }
}