using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles_Zoo.Classes
{
    public class Dragon : Reptile
    {
        public override string AnimalName { get; set; } = "Dragon";
        public override bool BreathesFire { get; set; } = true;
        public override bool IsReal { get; set; } = false;
        //Interface properties
        public override bool IsHibernating { get; set; } = false;

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
    }
}
