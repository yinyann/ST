using SilverTower.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace SilverTower.viewmodels
{
    class GameViewModel : INotifyPropertyChanged, IDisposable
    {
        private List<string> _heroes = Game.Instance.Heroes;

        public List<string> Heroes { get { return _heroes; } }

        public GameViewModel()
        {
            MessagingCenter.Subscribe<Application>(this, helpers.Messages.GameConfigurationUpdated, Refresh);
        }

        private void Refresh(Application obj)
        {
            if(_heroes.Count != Game.Instance.Heroes.Count)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Heroes"));
                _heroes = Game.Instance.Heroes;
            }
            System.Diagnostics.Debug.WriteLine($"GameViewModelRefresh... Si il y en a plus que 2 il faut gérer le unsuscribe.");
        }

        public void AddHero(string heroName)
        {
            Game.Instance.Heroes.Add(heroName);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Heroes"));
            MessagingCenter.Send(App.Current, helpers.Messages.GameConfigurationUpdated);
        }

        public void Remove(string heroName)
        {
            Game.Instance.Heroes.Remove(heroName);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Heroes"));
            MessagingCenter.Send(App.Current, helpers.Messages.GameConfigurationUpdated);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Dispose()
        {
            MessagingCenter.Unsubscribe<Application>(this, helpers.Messages.GameConfigurationUpdated);
        }
    }
}
