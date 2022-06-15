using System;

namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var grizzly = new Bear();

            grizzly.MakeSound();

            Console.WriteLine("_______________________");

            var ATLhawk = new Hawk();

            ATLhawk.MakeSound();
            ATLhawk.EatsFood();
        }
    }
}
