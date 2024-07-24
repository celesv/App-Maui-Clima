using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using AppMauiClima.Services;
using AppMauiClima.Models;

namespace AppMauiClima
{
    public partial class MainPage : ContentPage
    {
        private WeatherService _weatherService;
        private WeatherViewModel _viewModel;

        public MainPage()
        {
            InitializeComponent();
            _weatherService = new WeatherService();
            _viewModel = (WeatherViewModel)BindingContext;
        }

        private async void OnGetWeatherClicked(object sender, EventArgs e)
        {
            string latitude = LatitudeEntry.Text;
            string longitude = LongitudeEntry.Text;

            if (string.IsNullOrWhiteSpace(latitude) || string.IsNullOrWhiteSpace(longitude))
            {
                await DisplayAlert("Error", "Por, favor, ingresa la latitud y la longitud", "OK");
                return;
            }

            try
            {
                var weatherData = await _weatherService.GetWeatherDataAsync(latitude, longitude);

                if (weatherData != null)
                {
                    _viewModel.Timezone = weatherData.Timezone;
                    _viewModel.Temperature = $"{weatherData.Currently.Temperature} °F";
                    _viewModel.Humidity = $"{weatherData.Currently.Humidity * 100}%";
                    _viewModel.WeatherSummary = weatherData.Currently.Summary;

                    string iconName = weatherData.Currently.Icon;

                    _viewModel.WeatherIcon = iconName switch
                    {
                        "clear-day" => "clearday.png",
                        "clear-night" => "clearnight.png",
                        "cloudy" => "cloudy.png",
                        "fog" => "fog.png",
                        "partly-cloudy-day" => "partlycloudyday.png",
                        "partly-cloudy-night" => "partlycloudynight.png",
                        "rain" => "rain.png",
                        "sleet" => "sleet.png",
                        "snow" => "snow.png",
                        "wind" => "wind.png",
                    };
                }
                else
                {
                    await DisplayAlert("Error", "Error al obtener los datos del clima.", "OK");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                await DisplayAlert("Error", "Coordenadas inválidas", "OK");
            }
        }
    }
}
