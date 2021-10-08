using System;

namespace Weather
{
    public static class ExtendedMethod
    {
        public static T ParseValue<T>(this string property)
        {
            if (typeof(T) == typeof(int))
                return (T) Convert.ChangeType(Int32.Parse(property.Replace('*', '\0')), typeof(T));
            if (typeof(T) == typeof(double))
                return (T) Convert.ChangeType(Double.Parse(property.Replace('*', '\0')), typeof(T));
            return (T) Convert.ChangeType(property, typeof(T));
        }
    }
}