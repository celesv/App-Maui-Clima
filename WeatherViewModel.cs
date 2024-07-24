using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppMauiClima
{
    public class WeatherViewModel : INotifyPropertyChanged
    {
        private string _temperature;
        private string _humidity;
        private string _weatherSummary;
        private string _weatherIcon;
        private string _timezone;

        public string Temperature
        {
            get => _temperature;
            set
            {
                _temperature = value;
                OnPropertyChanged();
            }
        }

        public string Humidity
        {
            get => _humidity;
            set
            {
                _humidity = value;
                OnPropertyChanged();
            }
        }

        public string WeatherSummary
        {
            get => _weatherSummary;
            set
            {
                _weatherSummary = value;
                OnPropertyChanged();
            }
        }

        public string WeatherIcon
        {
            get => _weatherIcon;
            set
            {
                _weatherIcon = value;
                OnPropertyChanged();
            }
        }

        public string Timezone
        {
            get => _timezone;
            set
            {
                _timezone = value;
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
