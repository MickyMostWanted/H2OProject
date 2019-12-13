using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace H2ODAS.ViewModels
{
    public class SignUpPageViewModel : ViewModelBase
    {
        private DelegateCommand _signupCommand;
        public DelegateCommand SignUpCommand =>
            _signupCommand ?? (_signupCommand = new DelegateCommand(ExecuteSignUpCommand));
        private INavigationService _navigationService;

        async void ExecuteSignUpCommand()
        {
            await NavigationService.NavigateAsync("HomePage");
        }
        public SignUpPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "HomePage";
            _navigationService = navigationService;
        }
        
    }
}
