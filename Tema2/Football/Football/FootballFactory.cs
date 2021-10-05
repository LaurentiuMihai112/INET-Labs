using System.Collections.Generic;
using Weather;

namespace Football
{   
    public class FootballFactory
    {
        private List<FootballRow> _footballRows;
        private static string FilePath = "..\\..\\..\\resources\\football.dat";

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
                    FootballRows.Add(new FootballRow(row[1], row[6].Check(), row[8].Check()));
                }
            }
        }
    }
}