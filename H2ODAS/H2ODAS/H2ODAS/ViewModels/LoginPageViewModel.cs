using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Navigation.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;

namespace H2ODAS.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private DelegateCommand _loginCommand;

        private INavigationService _navigationService;

        public DelegateCommand LoginCommand =>
            _loginCommand ?? (_loginCommand = new DelegateCommand(ExecuteLoginCommand));

        async void ExecuteLoginCommand()
        {
            await _navigationService.NavigateAsync("HomePage");
        }
        public LoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "HomePage";
            _navigationService = navigationService;
        }
    }
}