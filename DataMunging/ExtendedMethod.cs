using System;

namespace Weather
{
    public static class ExtendedMethod
    {
        public static int Check(this string property)
        {
            return Int32.Parse(property.Replace('*', '\0'));
        }
    }
}