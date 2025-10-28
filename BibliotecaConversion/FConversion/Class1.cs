using System;
namespace FConversion
{
    public static class Conversions
    {
        private const double METERS_PER_KILOMETER = 1000.0;
        private const double FAHRENHEIT_MULTIPLIER = 9.0 / 5.0;
        private const double FAHRENHEIT_OFFSET = 32.0;

        public static double MetersToKilometers(double meters)
        {
            return meters / METERS_PER_KILOMETER;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return FAHRENHEIT_MULTIPLIER * celsius + FAHRENHEIT_OFFSET;
        }
    }
}