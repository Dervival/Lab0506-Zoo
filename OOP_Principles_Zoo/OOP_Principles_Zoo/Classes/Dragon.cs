using System;
using System.Collections.Generic;
using System.Text;
using OOP_Principles_Zoo.Interfaces;

namespace OOP_Principles_Zoo.Classes
{
    public class Dragon : Reptile, IHibernate, IFly
    {
        public override string AnimalName { get; set; } = "Dragon";
        public override bool BreathesFire { get; set; } = true;
        public override bool IsReal { get; set; } = false;
        //Interface properties
        public override bool IsHibernating { get; set; } = false;
        public bool IsFlying { get; set; } = true;

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

        //Interface methods
        public override string StartHibernating()
        {
            string hibernateMessage = "";
            if (IsHibernating)
            {
                hibernateMessage = "The dragon is already hibernating!";
                Console.WriteLine(hibernateMessage);
                return hibernateMessage;
            }
            hibernateMessage = "The dragon begins to hibernate.";
            Console.WriteLine(hibernateMessage);
            IsHibernating = true;
            return hibernateMessage;
        }
        public override string StopHibernating()
        {
            string hibernateMessage = "";
            if (!IsHibernating)
            {
                hibernateMessage = "The dragon is not hibernating, so cannot stop hibernating.";
                Console.WriteLine(hibernateMessage);
                return hibernateMessage;
            }
            hibernateMessage = "The dragon stops hibernating.";
            Console.WriteLine(hibernateMessage);
            IsHibernating = false;
            return hibernateMessage;
        }
        public string TakeOff()
        {
            string flyMessage = "";
            if (!IsFlying)
            {
                flyMessage = "The pidgeon takes flight!";
                IsFlying = true;
                return flyMessage;
            }
            else
            {
                flyMessage = "The pidgeon is already flying.";
                return flyMessage;
            }
        }
        public string Land(string location)
        {
            string flyMessage = "";
            if (IsFlying)
            {
                flyMessage = "The pidgeon lands at + " + location + ".";
                IsFlying = false;
                return flyMessage;
            }
            else
            {
                flyMessage = "The pidgeon is not currently flying, so it cannot land.";
                return flyMessage;
            }
        }
    }
}
