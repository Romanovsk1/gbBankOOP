using System;

namespace OOP7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var originalString = "welcome to the club buddy";

            var ACoder = new ACoder(originalString);

            Console.WriteLine($"{nameof(originalString)} =  {originalString}");
            Console.WriteLine($"ACoder.Encode= {ACoder.Encode()}");
            Console.WriteLine($"ACoder.Decode= {ACoder.Decode()}");


            var BCoder = new BCoder(originalString);

            Console.WriteLine($"{nameof(originalString)} =  {originalString}");
            Console.WriteLine($"BCoder.Encode= {BCoder.Encode()}");
            Console.WriteLine($"BCoder.Decode= {BCoder.Decode()}");

            Console.ReadKey();
        }
    }
}
