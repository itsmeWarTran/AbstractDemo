using System;
namespace AbstractDemo
{
    public class Bear : Animal
    {
        public Bear()
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Grrrrrrrrr");
        }

        public override void EatsFood()
        {
            Console.WriteLine("Chomp, chomp"); 
        }

    }
}

