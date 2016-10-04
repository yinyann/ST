using System;
using Xamarin.Forms;

namespace SilverTower.page
{
    public partial class Rencontre : ContentPage
    {
        public Rencontre()
        {
            Title = "Rencontre";
            InitializeComponent();
        }

        void OnCellTapped(object sender, EventArgs args)
        {
            var cellTapped = (Label)sender;
            cellTapped.Text = "test";
        }
    }
}
