using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles_Zoo.Classes
{
    public class Pidgeon : Bird
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
        public override string TakeOff()
        {
            string flyMessage = "";
            if (!IsFlying)
            {
                flyMessage = "The pidgeon takes flight!";
                IsFlying = true;
                Console.WriteLine(flyMessage);
                return flyMessage;
            }
            else
            {
                flyMessage = "The pidgeon is already flying.";
                Console.WriteLine(flyMessage);
                return flyMessage;
            }
        }
        public override string Land(string location)
        {
            string flyMessage = "";
            if (IsFlying)
            {
                flyMessage = "The pidgeon lands at " + location + ".";
                IsFlying = false;
                Console.WriteLine(flyMessage);
                return flyMessage;
            }
            else
            {
                flyMessage = "The pidgeon is not currently flying, so it cannot land.";
                Console.WriteLine(flyMessage);
                return flyMessage;
            }
        }
    }
}
