using H2ODAS.ViewModels;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
namespace H2ODAS.ViewModels
{
    public class AboutUsPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public AboutUsPageViewModel(INavigationService navigationService)
        : base(navigationService)
        {
            Title = "Settings";
            _navigationService = navigationService;
        }
    }
}