using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double f)
        {
            var result = (f - 32) / 1.8;
            return result;
        }


       public static double CelsiusToFahrenheit(double c)
        {
            var res = (c * 9) / 5 + 32;
            return res;
        } 
}
}
