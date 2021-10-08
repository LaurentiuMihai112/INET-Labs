using System.Collections.Generic;
using Weather;

namespace Football
{
    public class FootballFactory
    {
        private List<FootballRow> _footballRows;
        private static string FilePath = "F:\\INET-Labs\\Tema2\\resources\\football.dat";

        public List<FootballRow> FootballRows
        {
            get => _footballRows;
            set => _footballRows = value;
        }

        public void GetValues()
        {
            FootballRows = new List<FootballRow>();
            var extractedRows = Reader.ReadFromFile(FilePath);
            foreach (List<string> row in extractedRows)
            {
                if (extractedRows.IndexOf(row) >= 1 && !(row[0].StartsWith('-')))
                {
                    FootballRow footballRow = new FootballRow(row[1].ParseValue<string>(), row[2].ParseValue<int>(),
                        row[3].ParseValue<int>(), row[4].ParseValue<int>(), row[5].ParseValue<int>(),
                        row[6].ParseValue<int>(), row[8].ParseValue<int>(), row[9].ParseValue<int>());
                    FootballRows.Add(footballRow);
                }
            }
        }
    }
}