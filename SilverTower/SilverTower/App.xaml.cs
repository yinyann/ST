using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SilverTower
{
    public partial class App : Application
    {
        public App()
        {
#if DEBUG

            MessagingCenter.Subscribe<Application>(this, helpers.Messages.GameConfigurationUpdated, (e) => { System.Diagnostics.Debug.WriteLine(helpers.Messages.GameConfigurationUpdated); });
            System.Diagnostics.Debug.WriteLine($"Subscription to {helpers.Messages.GameConfigurationUpdated} message for debug.");
#endif
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
