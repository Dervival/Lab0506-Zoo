using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles_Zoo.Classes
{
    class Corgi : Dog
    {
        //Properties
        public override string AnimalName { get; set; } = "Corgi";
        public override bool HasTwoCoats { get; set; } = false;
        //Methods
        public override string Eat()
        {
            string eatMessage = "The " + AnimalName + " is eating some kibble.";
            Console.WriteLine(eatMessage);
            return eatMessage;
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
        public override string Bark()
        {
            string barkMessage = "The " + AnimalName + " barks quietly.";
            Console.WriteLine(barkMessage);
            return barkMessage;
        }
        public string Flop()
        {
            string message = "The corgi flops on the ground.";
            Console.WriteLine(message);
            return message;
        }
    }
}
