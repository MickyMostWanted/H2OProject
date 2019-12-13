using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace H2ODAS.ViewModels
{
    public class OrderPage1ViewModel : ViewModelBase
    {
        private DelegateCommand _SubmitOrderCommand;
        private INavigationService _navigationService;

        public DelegateCommand SubmitOrderCommand =>
            _SubmitOrderCommand ?? (_SubmitOrderCommand = new DelegateCommand(ExecuteSubmitOrderCommand));

       async void ExecuteSubmitOrderCommand()
        {
            await NavigationService.NavigateAsync("HomePage");
        }
        public OrderPage1ViewModel(INavigationService navigationService)
           : base(navigationService)
        {
            Title = "HomePage";
            _navigationService = navigationService;
        }

    }
}
