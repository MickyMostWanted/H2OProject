using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace H2ODAS.ViewModels
 {
    public class OfflinePage1ViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public OfflinePage1ViewModel(INavigationService navigationService)
        : base(navigationService)
        {
            Title = "Settings";
            _navigationService = navigationService;
        }
    }

}
