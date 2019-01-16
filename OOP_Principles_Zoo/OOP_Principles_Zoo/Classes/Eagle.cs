using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles_Zoo.Classes
{
    public class Eagle : Bird
    {
        public override string AnimalName { get; set; } = "Eagle";
        public override string LivesIn { get; set; } = "Countryside";

        //Methods
        public override string Eat()
        {
            string eatMessage;
            Console.WriteLine("The " + AnimalName + " is hungry. Time to hunt!");
            if (Hunt("rabbit"))
            {
                eatMessage = "The eagle is now eating a rabbit.";
                Console.WriteLine(eatMessage);
                return eatMessage;
            }
            if (Hunt("mouse"))
            {
                eatMessage = "The eagle is now eating a mouse.";
                Console.WriteLine(eatMessage);
                return eatMessage;
            }
            eatMessage = "The eagle failed to hunt, and is still hungry.";
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
            string flapMessage = "The eagle spreads its wings.";
            Console.WriteLine(flapMessage);
            return flapMessage;
        }
        public bool Hunt(string huntTarget)
        {
            bool huntSuccess;
            Console.WriteLine("The eagle is hunting a " + huntTarget + ".");
            Console.WriteLine("The eagle strikes!");
            switch (huntTarget)
            {
                case "mouse":
                    huntSuccess = true;
                    break;
                case "snake":
                    huntSuccess = true;
                    break;
                default:
                    huntSuccess = false;
                    break;
            }
            return huntSuccess;
        }
        public override string TakeOff()
        {
            string flyMessage = "";
            if (!IsFlying)
            {
                Flap();
                flyMessage = "The eagle takes off!";
                IsFlying = true;
                Console.WriteLine(flyMessage);
                return flyMessage;
            }
            else
            {
                flyMessage = "The eagle is already flying.";
                Console.WriteLine(flyMessage);
                return flyMessage;
            }
        }
        public override string Land(string location)
        {
            string flyMessage = "";
            if (IsFlying)
            {
                flyMessage = "The eagle lands at " + location + ".";
                IsFlying = false;
                Console.WriteLine(flyMessage);
                return flyMessage;
            }
            else
            {
                flyMessage = "The eagle is not currently flying, so it cannot land.";
                Console.WriteLine(flyMessage);
                return flyMessage;
            }
        }
    }
}
