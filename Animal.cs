using System;
namespace AbstractDemo
{
    public abstract class Animal
    {
        public int numOfLegs = 4;
        public bool hasTail;
        public string name;
        public int numEyes;
        public bool hasTeeth;

        public abstract void MakeSound(); //Stubbed out method

        public virtual void EatsFood()
        {
            Console.WriteLine("Munch, munch"); //Default implementation
        }

    }
}
