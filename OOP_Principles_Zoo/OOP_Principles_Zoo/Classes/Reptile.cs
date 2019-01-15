using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles_Zoo.Classes
{
    public abstract class Reptile : Animal
    {
        public virtual bool BreathesFire { get; set; } = false;

        public override string Sleep()
        {
            string sleepMessage = "The " + AnimalName + " sleeps in its den.";
            Console.WriteLine(sleepMessage);
            return sleepMessage;
        }

        public string Firebreath()
        {
            if (BreathesFire)
            {
                string fireMessage = "The " + AnimalName + " breathes fire at you!";
                Console.WriteLine(fireMessage);
                return fireMessage;
            }
            else
            {
                string fireMessage = "The " + AnimalName + " looks sadly at you, as it cannot breathe fire.";
                Console.WriteLine(fireMessage);
                return fireMessage;
            }
        }
    }
}
