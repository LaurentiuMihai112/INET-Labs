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
        /*      To what extent did the design decisions you made when writing the original programs make it easier or harder
         *      to factor out common code?
         * 
         *      Considering that we already knew that we were supossed to reuse the code, we tried to write it in a way
         *      that was going to be useful for the second program
         *
         * 
         *      Was the way you wrote the second program influenced by writing the first?
         *
         *      Yes. Because the program's structure is largely the same with some small modifications because of
         *      resource files f
         *
         *      
         *      Is factoring out as much common code as possible always a good thing? Did the readability of the programs
         *      suffer because of this requirement? How about the maintainability?
         *
         *      Not always, it usually is, but sometimes it would be better to keep the code simple and easy to read,
         *      even if it's not really generic and cant be reused in multiple programs.
         *      Considering the difficulty level of these programs, no the readability remained pretty much the same
         *      Because the programs have common code, if anything has to be added, it has to be done just once, so yes,
         *      I would say it is more maintainable.
         */
    }
}