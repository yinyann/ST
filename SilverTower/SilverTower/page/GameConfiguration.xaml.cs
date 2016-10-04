using System;
using Xamarin.Forms;

namespace SilverTower.page
{
    public partial class GameConfiguration : ContentPage
    {
        private viewmodels.GameViewModel _viewModel = new viewmodels.GameViewModel();
        public GameConfiguration()
        {
            BindingContext = _viewModel;

            Title = "Configuration";
            InitializeComponent();
        }

        protected override void OnDisappearing()
        {
            _viewModel.Dispose();
            base.OnDisappearing();
        }

        async void Valider(object sender, EventArgs args)
        {
            await Navigation.PopAsync();
        }
    }
}
