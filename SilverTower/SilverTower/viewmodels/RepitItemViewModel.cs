using System.ComponentModel;

namespace SilverTower.viewmodels
{
    public class RepitItemViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string HeroName { get; set; }

        public string HeroPictureName { get; set; }
    }
}
