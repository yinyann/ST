using SilverTower.models;
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
            string retour = string.Empty;
            switch (cellTapped.Text)
            {
                case "Tableau A":
                    retour = RencontreA();
                    break;

                case "Tableau B":
                    retour = RencontreB();
                    break;

                case "Tableau C":
                    retour = RencontreC();
                    break;

                case "Tableau D":
                    retour = RencontreD();
                    break;
            }

            Content = new Label { Text = retour };

        }

        private string RencontreD()
        {
            var rdn = new Random();
            string retour = string.Empty;
            switch (rdn.Next(2, 13))
            {
                case 2:
                case 3:
                    retour = "L'Ogroid Thaumaturge surgit...";
                    break;
                case 4:
                    retour = "Un événement inattendu survient.";
                    break;
                case 5:
                case 6:
                    retour = $"Vous rencontrez {Game.Instance.NbPlayers * 2} Kairic Acolytes et {rdn.Next(1, 4)} Tzaangors.";
                    break;
                case 7:
                    retour = RencontreText("Kairic Acolytes", Game.Instance.NbPlayers*2);
                    break;
                case 8:
                case 9:
                    retour = $"Vous rencontrez {Game.Instance.NbPlayers * 2} Grot Scuttling et un événement inattendu survient.";
                    break;
                case 10:
                    retour = RencontreText("Tzaangors", Game.Instance.NbPlayers + 1);
                    break;
                case 11:
                case 12:
                    retour = RencontreText("Pink horrors", 2);
                    break;
            }
            return retour;
        }

        private string RencontreC()
        {
            var rdn = new Random();
            string retour = string.Empty;
            switch (rdn.Next(1, 7))
            {
                case 1:
                    retour = RencontreText("Grot Scuttling", Game.Instance.NbPlayers * 2);
                    break;
                case 2:
                    retour = RencontreText("Tzaangors", rdn.Next(1,4));
                    break;
                case 3:
                    retour = $"Vous rencontrez {Game.Instance.NbPlayers} Grot Scuttling et un événement inattendu survient.";
                    break;
                case 4:
                    retour = RencontreText("Grot Scuttling", rdn.Next(1, 7));
                    break;
                case 5:
                    retour = RencontreText("Tzaangors", Game.Instance.NbPlayers);
                    break;
                case 6:
                    retour = RencontreText("Grot Scuttling", Game.Instance.NbPlayers);
                    break;
            }
            return retour;
        }

        private string RencontreB()
        {
            var rdn = new Random();
            string retour = string.Empty;
            switch (rdn.Next(1, 7))
            {
                case 1:
                    retour = $"Vous rencontrez {Game.Instance.NbPlayers} Kairic Acolytes et 1 Pink Horror.";
                    break;
                case 2:
                    retour = RencontreText("Pink Horror", 1);
                    break;
                case 3:
                    retour = $"Vous rencontrez {Game.Instance.NbPlayers} Kairic Acolytes et {Game.Instance.NbPlayers} Blue Horror.";
                    break;
                case 4:
                    retour = $"Vous rencontrez {2} Kairic Acolytes et {rdn.Next(1,4)} Blue Horrors.";
                    break;
                case 5:
                    retour = RencontreText("Blue Horrors", Game.Instance.NbPlayers);
                    break;
                case 6:
                    retour = RencontreText("Kairic Acolytes", Game.Instance.NbPlayers);
                    break;
            }
            return retour;
        }

        private string RencontreA()
        {
            var rdn = new Random();
            string retour = string.Empty;
            switch (rdn.Next(2, 13))
            {
                case 2:
                case 3:
                    retour = "Le Skaven Deathrunner surgit...";
                    break;
                case 4:
                    retour = "Un événement inattendu survient.";
                    break;
                case 5:
                case 6:
                    retour = RencontreText("Tzaangors", Game.Instance.NbPlayers);
                    break;
                case 7:
                    retour = $"Vous rencontrez {Game.Instance.NbPlayers} Kairic Acolytes et {rdn.Next(1,4)} Blue Horrors.";
                    break;
                case 8:
                case 9:
                    retour = RencontreText("Kairic Acolytes", Game.Instance.NbPlayers);
                    break;
                case 10:
                    retour = RencontreText("Grot Scuttling", Game.Instance.NbPlayers);
                    break;
                case 11:
                case 12:
                    retour = RencontreText("Blue Horrors", Game.Instance.NbPlayers);
                    break;
            }
            return retour;
        }

        /// <summary>
        /// TODO - générer des textes aléatoires pour l'ambiance
        /// </summary>
        /// <param name="name"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        private string RencontreText(string name, int quantity)
        {
            return $"Vous rencontrez {quantity} {name}.";
        }
    }
}
