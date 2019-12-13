using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace H2ODAS.ViewModels
{
    public class MasterDetailPage1ViewModel : ViewModelBase
    {
      
            private readonly INavigationService _navigationService;
        private DelegateCommand _aboutUsCommand;
        public DelegateCommand AboutUsCommand =>
            _aboutUsCommand ?? (_aboutUsCommand = new DelegateCommand(ExecuteAboutUsCommand));
        
  
        private DelegateCommand _mainPageCommand;
        public DelegateCommand MainPageCommand =>
            _mainPageCommand ?? (_mainPageCommand = new DelegateCommand(ExecuteMainPageCommand));

        async void ExecuteAboutUsCommand()
        {
            await _navigationService.NavigateAsync("MasterDetailPage1/AboutUsPage");
        }

         void ExecuteMainPageCommand()
        {
            
        }

        public MasterDetailPage1ViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Sign Up Page";
            _navigationService = navigationService;
        }
    }
}

