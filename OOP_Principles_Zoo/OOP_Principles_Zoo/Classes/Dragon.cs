using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles_Zoo.Classes
{
    class Dragon : Reptile
    {
        public override string AnimalName { get; set; } = "Dragon";
        public override bool BreathesFire { get; set; } = true;
        public override bool IsReal { get; set; } = false;

        public override string Eat()
        {
            string eatMessage = "The " + AnimalName + " is eating a horse.";
            Console.WriteLine(eatMessage);
            return eatMessage;
        }

        public override string Walk()
        {
            string walkMessage = "The " + AnimalName + " walks using its " + NumberOfLegs + " legs.";
            Console.WriteLine(walkMessage);
            return walkMessage;
        }

        public string Fly()
        {
            string flyMessage = "";
            if (!IsReal)
            {
                flyMessage = "If it had existed, ";
            }
            flyMessage = flyMessage + "The " + AnimalName + " flew over the zoo, frightening the patrons.";
            Console.WriteLine(flyMessage);
            return flyMessage;
        }
    }
}
