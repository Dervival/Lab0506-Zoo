using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles_Zoo.Classes
{
    abstract class Dog : Mammal
    {
        //Properties
        virtual public bool HasTwoCoats { get; set; } = true;
        //Methods
        public override string Eat()
        {
            string eatMessage = "I am eating some kibble.";
            Console.WriteLine(eatMessage);
            return eatMessage;
        }
        public override string Sleep()
        {
            string sleepMessage = AnimalName + " is sleeping now.";
            Console.WriteLine(sleepMessage);
            return sleepMessage;
        }
        abstract public string Bark(); 
    }
}
