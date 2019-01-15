using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles_Zoo.Classes
{
    class Pidgeon : Bird
    {
        public override string AnimalName { get; set; } = "Pidgeon";

        //Methods
        public override string Eat()
        {
            string eatMessage = "The " + AnimalName + " is eating some birdseed.";
            Console.WriteLine(eatMessage);
            return eatMessage;
        }
        public override string Sleep()
        {
            string sleepMessage = "The " + AnimalName + " sleeps in its nest in the " + LivesIn + ".";
            Console.WriteLine(sleepMessage);
            return sleepMessage;
        }
        public override string Flap()
        {
            string flapMessage = "The pidgeon flutters its wings.";
            Console.WriteLine(flapMessage);
            return flapMessage;
        }
        public string Coo()
        {
            string cooMessage = "The pidgeon goes 'Coo!'";
            Console.WriteLine(cooMessage);
            return cooMessage;
        }
    }
}
