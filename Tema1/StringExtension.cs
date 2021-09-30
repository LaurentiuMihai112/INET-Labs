using System;
using System.Linq;

namespace Tema1
{
    public static class StringExtension
    {
        public static int ComputeWords(this string sentence)
        {
            var words= sentence.Split(" ").ToList();
            return words.Count;
        }
    }
}
