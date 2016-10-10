using SilverTower.models;
using SilverTower.viewmodels;
using System;
using Xamarin.Forms;

namespace SilverTower.controls
{
    public partial class RepitItem : ContentView
    {
        public bool ImDone { get; set; }

        private Random _random = new Random();

        public EventHandler<RepitItem> RepitActionChoosen;

        RepitItemViewModel _bindingContext = new RepitItemViewModel();

        public RepitItem()
        {
            InitializeComponent();
        }

        public RepitItem(string heroPictureName) : this()
        {
            _bindingContext.HeroPictureName = heroPictureName;
            _bindingContext.HeroName = Game.AvailableHeroesDictionnary[heroPictureName];
            BindingContext = _bindingContext;
        }

        void FouilleClicked(object sender, EventArgs args)
        {
            stackContent.Children.RemoveAt(2);
            stackContent.Children.RemoveAt(1);
            stackContent.Children.Add(new Label { Text = _random.NextDouble() < 0.5 ? "J'ai trouvé un trésor !!" : "Cette pièce est vide..." });

            Done();
        }

        void SoinClicked(object sender, EventArgs args)
        {
            var soin = _random.Next(1, 4);
            stackContent.Children.RemoveAt(2);
            stackContent.Children.RemoveAt(1);
            stackContent.Children.Add(new Label { Text = $"{soin} dégâts soignés." });

            Done();
        }

        private void Done()
        {
            ImDone = true;
            RepitActionChoosen?.Invoke(this, this);
        }
    }
}
