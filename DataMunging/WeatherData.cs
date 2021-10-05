using System;
using System.Collections.Generic;

namespace Weather
{
    public class WeatherData
    {
        public static void SmallestTemperatureSpread(List<WeatherRow> weatherRows)
        {
            int day = 0;
            int spread = Int32.MaxValue;
            foreach (var weatherRow in weatherRows)
            {
                if (weatherRow.GetTemperatureSpread() < spread)
                {
                    spread = weatherRow.GetTemperatureSpread();
                    day = weatherRow.Dy;
                }
            }

            Console.WriteLine($"The day with minimum temperature spread is: {day}");
        }
    }
}