using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles_Zoo.Classes
{
    public abstract class Animal
    {
        //Properties
        public abstract bool IsReal { get; set; }
        public abstract string AnimalName { get; set; }
        public virtual int NumberOfLegs { get; set; } = 4;

        //Methods
        public abstract string Eat();
        public abstract string Sleep();
        public virtual string Walk()
        {
            string walkStatement = "I am walking now.";
            Console.WriteLine(walkStatement);
            return walkStatement;
        }
    }
}
