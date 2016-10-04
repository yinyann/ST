using SilverTower.models;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace SilverTower.viewmodels
{
    class GameViewModel : INotifyPropertyChanged, IDisposable
    {
        private int _nbJoueurs = Game.Instance.NbPlayers;

        public int NbJoueurs
        {
            get
            {
                return _nbJoueurs;
            }
            set
            {
                // mise à jour du vueModel
                if (_nbJoueurs != value)
                {
                    _nbJoueurs = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NbJoueurs"));
                }

                // mise à jour du model
                if (Game.Instance.NbPlayers != value)
                {
                    Game.Instance.NbPlayers = value;
                    MessagingCenter.Send(App.Current, helpers.Messages.GameConfigurationUpdated);
                }
            }
        }

        public GameViewModel()
        {
            MessagingCenter.Subscribe<Application>(this, helpers.Messages.GameConfigurationUpdated, Refresh);
        }

        public void Refresh(Application obj)
        {
            NbJoueurs = Game.Instance.NbPlayers;
            System.Diagnostics.Debug.WriteLine($"GameViewModelRefresh... Si il y en a plus que 2 il faut gérer le unsuscribe.");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Dispose()
        {
            MessagingCenter.Unsubscribe<Application>(this, helpers.Messages.GameConfigurationUpdated);
        }
    }
}
