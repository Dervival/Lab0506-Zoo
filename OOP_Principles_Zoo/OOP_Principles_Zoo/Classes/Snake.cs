using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles_Zoo.Classes
{
    public class Snake : Reptile
    {
        public override string AnimalName { get; set; } = "Snake";
        public override int NumberOfLegs { get; set; } = 0;
        public override bool IsReal { get; set; } = true;
        //Interface properties
        public override bool IsHibernating { get; set; } = true;

        public override string Eat()
        {
            string eatMessage = "The " + AnimalName + " is eating a mouse.";
            Console.WriteLine(eatMessage);
            return eatMessage;
        }

        public override string Sleep()
        {
            string sleepMessage = "During the winter, " + base.Sleep().ToLower();
            Console.WriteLine(sleepMessage);
            return sleepMessage;
        }

        public override string Walk()
        {
            string walkMessage = "As the snake has no legs, it cannot walk.";
            Console.WriteLine(walkMessage);
            return walkMessage;
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
