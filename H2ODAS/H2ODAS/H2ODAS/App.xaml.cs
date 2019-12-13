using Prism;
using Prism.Ioc;
using H2ODAS.ViewModels;
using H2ODAS.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static H2ODAS.ViewModels.HomePageViewModel;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace H2ODAS
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("MasterDetailPage1/NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<SignUpPage, SignUpPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<MasterDetailPage1, MasterDetailPage1ViewModel>();
            containerRegistry.RegisterForNavigation<AboutUsPage, AboutUsPageViewModel>();
            containerRegistry.RegisterForNavigation<OrderPage1, OrderPage1ViewModel>();
            containerRegistry.RegisterForNavigation<OfflinePage1, OfflinePage1ViewModel>();
        }
    }
}
