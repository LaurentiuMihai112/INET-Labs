using System;

namespace Weather
{
    class Program
    {
        private static void Main(string[] args)
        {
            WeatherFactory weatherFactory = new WeatherFactory();
            weatherFactory.GetValues();
            WeatherData.SmallestTemperatureSpread(weatherFactory.WeatherRows);
        }
    }
}