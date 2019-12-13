using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Navigation.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace H2ODAS.ViewModels
{

    public class MainPageViewModel : ViewModelBase
    {   
        
        private readonly INavigationService _navigationService;

        private DelegateCommand _loginCommand;
        public DelegateCommand LoginCommand =>
            _loginCommand ?? (_loginCommand = new DelegateCommand(ExecuteLoginCommand));

        private DelegateCommand _signupCommand;
        public DelegateCommand SignUpCommand =>
            _signupCommand ?? (_signupCommand = new DelegateCommand(ExecuteSignUpCommand));

       async void  ExecuteSignUpCommand()
        {
            await NavigationService.NavigateAsync("SignUpPage");
        }

        async void ExecuteLoginCommand()
        {
            await NavigationService.NavigateAsync("MasterDetailPage1/LoginPage");
        }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            _navigationService = navigationService;
        }

        
    }
}
