using System;
using System.Collections.Generic;
using System.IO;

namespace Weather
{
    public class Reader
    {
        public static List<Object> ReadFromFile(string filename)
        {
            List<Object> extractedList = new List<object>();
            string[] rows = File.ReadAllLines(filename);
            foreach (string row in rows)
            {
                extractedList.Add(new List<string>(row.Split((char[]) null, StringSplitOptions.RemoveEmptyEntries)));
            }

            return extractedList;
        }
    }
}