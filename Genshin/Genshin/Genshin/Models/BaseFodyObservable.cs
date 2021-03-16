using System.ComponentModel;

namespace Genshin.Models
{
    public abstract class BaseFodyObservable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
