using System;
using System.Collections.Generic;

namespace Weather
{
    public class WeatherFactory
    {
        private List<WeatherRow> _weatherRows;
        private static string FilePath = "D:\\Facultate\\.NET\\DataMunging\\resources\\weather.dat";

        public List<WeatherRow> WeatherRows
        {
            get => _weatherRows;
            set => _weatherRows = value;
        }

        public void GetValues()
        {
            WeatherRows = new List<WeatherRow>();
            var extractedRows = Reader.ReadFromFile(FilePath);
            foreach (List<string> row in extractedRows)
            {
                if (extractedRows.IndexOf(row) >= 2 && extractedRows.IndexOf(row) < extractedRows.Count - 1)
                {
                    WeatherRows.Add(new WeatherRow(row[0].Check(), row[1].Check(), row[2].Check()));
                }
            }
        }
    }
}