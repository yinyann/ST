using System;
using Xamarin.Forms;

namespace SilverTower
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Title = "Bienvenue dans la SilverTower";
            InitializeComponent();
        }
        async void OnMenuLineTapped(object sender, EventArgs args)
        {
            var menuTapped = (controls.MenuLine)sender;

            await menuTapped.ScaleTo(0.8, 100);
            await menuTapped.ScaleTo(1, 100);

            switch (menuTapped?.Name)
            {
                case "Rencontre":
                    await Navigation.PushAsync(new page.Rencontre());
                    break;
                case "Bestiaire":
                    await Navigation.PushAsync(new page.Bestiaire());
                    break;
                case "Evênement innatendu":
                    await Navigation.PushAsync(new page.Evenement());
                    break;
                case "Répit":
                    await Navigation.PushAsync(new page.Repit());
                    break;
            }
        }
    }
}
