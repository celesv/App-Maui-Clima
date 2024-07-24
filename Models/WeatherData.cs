using System;

namespace AppMauiClima.Models
{
    public class WeatherData
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Timezone { get; set; }
        public double Offset { get; set; }
        public double Elevation { get; set; }
        public Currently Currently { get; set; }
        public Minutely Minutely { get; set; }
        public Hourly Hourly { get; set; }
        public Daily Daily { get; set; }
        public Flags Flags { get; set; }
    }

    public class Currently
    {
        public double Time { get; set; }
        public string Summary { get; set; }
        public string Icon { get; set; }
        public double NearestStormDistance { get; set; }
        public double NearestStormBearing { get; set; }
        public double PrecipIntensity { get; set; }
        public double PrecipProbability { get; set; }
        public double PrecipIntensityError { get; set; }
        public string PrecipType { get; set; }
        public double Temperature { get; set; }
        public double ApparentTemperature { get; set; }
        public double DewPoint { get; set; }
        public double Humidity { get; set; }
        public double Pressure { get; set; }
        public double WindSpeed { get; set; }
        public double WindGust { get; set; }
        public double WindBearing { get; set; }
        public double CloudCover { get; set; }
        public double UvIndex { get; set; }
        public double Visibility { get; set; }
        public double Ozone { get; set; }
    }

    public class Minutely
    {
        public string Summary { get; set; }
        public string Icon { get; set; }
        public MinutelyDatum[] Data { get; set; }
    }

    public class MinutelyDatum
    {
        public double Time { get; set; }
        public double PrecipIntensity { get; set; }
        public double PrecipProbability { get; set; }
        public double PrecipIntensityError { get; set; }
        public string PrecipType { get; set; }
    }

    public class Hourly
    {
        public string Summary { get; set; }
        public string Icon { get; set; }
        public HourlyDatum[] Data { get; set; }
    }

    public class HourlyDatum
    {
        public double Time { get; set; }
        public string Icon { get; set; }
        public string Summary { get; set; }
        public double PrecipIntensity { get; set; }
        public double PrecipProbability { get; set; }
        public double PrecipIntensityError { get; set; }
        public double PrecipAccumulation { get; set; }
        public string PrecipType { get; set; }
        public double Temperature { get; set; }
        public double ApparentTemperature { get; set; }
        public double DewPoint { get; set; }
        public double Humidity { get; set; }
        public double Pressure { get; set; }
        public double WindSpeed { get; set; }
        public double WindGust { get; set; }
        public double WindBearing { get; set; }
        public double CloudCover { get; set; }
        public double UvIndex { get; set; }
        public double Visibility { get; set; }
        public double Ozone { get; set; }
    }

    public class Daily
    {
        public string Summary { get; set; }
        public string Icon { get; set; }
        public DailyDatum[] Data { get; set; }
    }

    public class DailyDatum
    {
        public double Time { get; set; }
        public string Icon { get; set; }
        public string Summary { get; set; }
        public double SunriseTime { get; set; }
        public double SunsetTime { get; set; }
        public double MoonPhase { get; set; }
        public double PrecipIntensity { get; set; }
        public double PrecipIntensityMax { get; set; }
        public double PrecipIntensityMaxTime { get; set; }
        public double PrecipProbability { get; set; }
        public double PrecipAccumulation { get; set; }
        public string PrecipType { get; set; }
        public double TemperatureHigh { get; set; }
        public double TemperatureHighTime { get; set; }
        public double TemperatureLow { get; set; }
        public double TemperatureLowTime { get; set; }
        public double ApparentTemperatureHigh { get; set; }
        public double ApparentTemperatureHighTime { get; set; }
        public double ApparentTemperatureLow { get; set; }
        public double ApparentTemperatureLowTime { get; set; }
        public double DewPoint { get; set; }
        public double Humidity { get; set; }
        public double Pressure { get; set; }
        public double WindSpeed { get; set; }
        public double WindGust { get; set; }
        public double WindGustTime { get; set; }
        public double WindBearing { get; set; }
        public double CloudCover { get; set; }
        public double UvIndex { get; set; }
        public double UvIndexTime { get; set; }
        public double Visibility { get; set; }
        public double TemperatureMin { get; set; }
        public double TemperatureMinTime { get; set; }
        public double TemperatureMax { get; set; }
        public double TemperatureMaxTime { get; set; }
        public double ApparentTemperatureMin { get; set; }
        public double ApparentTemperatureMinTime { get; set; }
        public double ApparentTemperatureMax { get; set; }
        public double ApparentTemperatureMaxTime { get; set; }
    }

    public class Flags
    {
        public string[] Sources { get; set; }
        public SourceTimes SourceTimes { get; set; }
        public double NearestStation { get; set; }
        public string Units { get; set; }
        public string Version { get; set; }
    }

    public class SourceTimes
    {
        public string Gfs { get; set; }
        public string Gefs { get; set; }
    }
}
