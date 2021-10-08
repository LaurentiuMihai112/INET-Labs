using System.Collections.Generic;

namespace Weather
{
    public class WeatherFactory
    {
        private List<WeatherRow> _weatherRows;
        private static string FilePath = "F:\\INET-Labs\\Tema2\\resources\\weather.dat";

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
                    WeatherRow weatherRow = new WeatherRow(row[0].ParseValue<int>(), row[1].ParseValue<int>(),
                        row[2].ParseValue<int>(), row[3].ParseValue<int>(), row[4].ParseValue<int>(),
                        row[5].ParseValue<double>(), row[6].ParseValue<int>(), row[7].ParseValue<double>(),
                        row[8].ParseValue<string>(), row[9].ParseValue<string>(), row[10].ParseValue<double>(),
                        row[11].ParseValue<string>(), row[12].ParseValue<int>(), row[13].ParseValue<double>(),
                        row[14].ParseValue<int>(), row[15].ParseValue<int>(), row[16].ParseValue<double>());

                    WeatherRows.Add(weatherRow);
                }
            }
        }
    }
}