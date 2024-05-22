using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private int _min;
        private double _avg;
        private int _max;

        public int Min
        {
            get { return _min; }
            set
            {
                _min = value;
                OnPropertyChanged();
            }
        }

        public double Avg
        {
            get { return _avg; }
            set
            {
                _avg = value;
                OnPropertyChanged();
            }
        }

        public int Max
        {
            get { return _max; }
            set
            {
                _max = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}