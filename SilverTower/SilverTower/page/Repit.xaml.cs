using SilverTower.controls;
using SilverTower.models;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace SilverTower.page
{
    public partial class Repit : ContentPage
    {
        private List<RepitItem> _repitItems = new List<RepitItem>();
        private StackLayout _stack;

        public Repit()
        {
            Title = "Phase de répit";
            InitializeComponent();

            _stack = new StackLayout();
            foreach (string hero in Game.Instance.Heroes)
            {
                var item = new RepitItem(hero);
                item.RepitActionChoosen += OnRepitActionChoosen;
                _repitItems.Add(item);
                _stack.Children.Add(item);
            }

            this.Content = _stack;
        }

        private void OnRepitActionChoosen(object sender, RepitItem e)
        {
            if (_repitItems.All(_ => _.ImDone))
            {
                var info = new Label { Text = "Tous les héros ont fait leur choix.\r\nIls peuvent se placer où ils le souhaitent avant de passer au tour suivant.", HorizontalOptions = LayoutOptions.CenterAndExpand };
                _stack.Children.Add(info);
            }
        }
    }
}
