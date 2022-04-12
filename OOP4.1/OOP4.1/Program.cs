using System;

namespace OOP4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new();
            building.Add(3, 6, 7);

            Building building2 = new();
            building2.Add(5, 7, 10, 76);

            building.Print();
            building2.Print();
            building.Print();
        }
    }
}
