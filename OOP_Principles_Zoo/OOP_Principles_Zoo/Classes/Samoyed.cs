using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles_Zoo.Classes
{
    class Samoyed : Dog
    {
        //Properties
        public override string AnimalName { get; set; } = "Samoyed";
        //Methods
        //Direct overrides
        public override string Bark()
        {
            string barkMessage = "The " + AnimalName + " howls.";
            Console.WriteLine(barkMessage);
            return barkMessage;
        }
        public override string Walk()
        {
            string walkMessage = "Please walk the " + AnimalName + ".";
            Console.WriteLine(walkMessage);
            return walkMessage;
        }
        public override string BrushSelf()
        {
            string brushMessage = "The " + AnimalName + " is brushing their own coat.";
            if (HasTwoCoats)
            {
                brushMessage = brushMessage + " The " + AnimalName + "'s second coat sheds.";
            }
            Console.WriteLine(brushMessage);
            return brushMessage;
        }
        //Messing around with Eat() from the Dog class
        public string SamoyedEat()
        {
            string eatMessage = "The white " + AnimalName + " says: ";
            Console.WriteLine(eatMessage);
            eatMessage = eatMessage + Eat();
            return eatMessage;
        }
        //Methods unique to Samoyed
        public string RollOver()
        {
            string message = "The samoyed rolls on the ground, making their coat dirty.";
            Console.WriteLine(message);
            return message;
        }
    }

}
