using SilverTower.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using System.Windows.Input;

namespace SilverTower.page
{
    public partial class Heroes : ContentPage
    {
        private viewmodels.GameViewModel _viewModel = new viewmodels.GameViewModel();
        public Heroes()
        {
            BindingContext = _viewModel;
            Title = "Select Heroes";
            InitializeComponent();

            for (int i = 0; i < Game.AvailableHeroesDictionnary.Count; i++)
            {
                int index = i;
                string heroName = Game.AvailableHeroesDictionnary.ElementAt(i).Key;
                var image = new Image
                {
                    Source = heroName,
                    Scale = _viewModel.Heroes.Contains(heroName) ? 0.8 : 1
                };
                var tapGestureRecognizer = new TapGestureRecognizer
                {
                    Command = new Command((o) => { ImageTapped(image, index); })
                };
                image.GestureRecognizers.Add(tapGestureRecognizer);
                grid.Children.Add(image, i % 2, i % 3);
            }
        }

        protected override void OnDisappearing()
        {
            _viewModel.Dispose();
            base.OnDisappearing();
        }

        private void ImageTapped(Image image, int index)
        {
            string heroName = Game.AvailableHeroesDictionnary.ElementAt(index).Key;
            if (_viewModel.Heroes.Contains(heroName))
            {
                image.ScaleTo(1, 150);
                _viewModel.Remove(heroName);
            }
            else
            {
                image.ScaleTo(0.8, 150);
                _viewModel.AddHero(heroName);
            }

        }
    }
}
