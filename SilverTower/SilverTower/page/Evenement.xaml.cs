using System;
using Xamarin.Forms;

namespace SilverTower.page
{
    public partial class Evenement : ContentPage
    {
        public Evenement()
        {
            Title = "Soudain ...";
            InitializeComponent();

            var rdn = new Random();
            int dizaine = rdn.Next(1, 7);
            int unite = rdn.Next(1, 7);

            this.Content = new Label { Text = $"Lisez le passage {dizaine}{unite}." };
        }
    }
}
