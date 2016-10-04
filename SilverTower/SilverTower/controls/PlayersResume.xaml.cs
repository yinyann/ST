using SilverTower.viewmodels;
using System;
using Xamarin.Forms;

namespace SilverTower.controls
{
    public partial class PlayersResume : ContentView
    {
        GameViewModel _bindingContext = new GameViewModel();
        public PlayersResume()
        {
            BindingContext = _bindingContext;
            InitializeComponent();
        }

        async void ChangePlayersClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new page.GameConfiguration());
        }
    }
}
