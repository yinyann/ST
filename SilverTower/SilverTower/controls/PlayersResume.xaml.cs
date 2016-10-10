using SilverTower.viewmodels;
using System;
using Xamarin.Forms;

namespace SilverTower.controls
{
    public partial class PlayersResume : ContentView
    {
        GameResumeViewModel _bindingContext = new GameResumeViewModel();
        public PlayersResume()
        {
            BindingContext = _bindingContext;
            InitializeComponent();
        }

        async void ChangePlayersClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new page.Heroes());
        }
    }
}
