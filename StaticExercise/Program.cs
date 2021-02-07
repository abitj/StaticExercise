using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("After Conversion:");
            Console.WriteLine("-----------------------------");
            var celsius = TempConverter.FahrenheitToCelsius(86); 
            Console.WriteLine($" {celsius} Celsius.");

            
            var fahrenheit = TempConverter.CelsiusToFahrenheit(34);
            Console.WriteLine($" {fahrenheit} Fahrenheit.");

        }
    }
}
