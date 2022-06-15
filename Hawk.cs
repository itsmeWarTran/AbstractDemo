using System;
namespace AbstractDemo
{
    public class Hawk : Animal
    {
        public Hawk()
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Caw-caw");
        }

    }
}
