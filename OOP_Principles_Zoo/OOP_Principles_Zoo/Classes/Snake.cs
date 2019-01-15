using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles_Zoo.Classes
{
    class Snake : Reptile
    {
        public override string AnimalName { get; set; } = "Snake";
        public override int NumberOfLegs { get; set; } = 0;
        public override bool IsReal { get; set; } = true;

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
    }
}
