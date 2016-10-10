using SilverTower.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SilverTower.viewmodels
{
    public class GameResumeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
       
        public int NbPlayers { get { return Game.Instance.Heroes.Count; } }

        public GameResumeViewModel()
        {
            MessagingCenter.Subscribe<Application>(this, helpers.Messages.GameConfigurationUpdated, Refresh);
        }

        private void Refresh(Application obj)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NbPlayers"));
        }
    }
}
