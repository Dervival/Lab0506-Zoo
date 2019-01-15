using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles_Zoo.Classes
{
    public abstract class Bird : Animal
    {
        public override bool IsReal { get; set; } = true;
        public override int NumberOfLegs { get; set; } = 2;
        public bool HasWings { get; set; } = true;
        public virtual string LivesIn { get; set; } = "city";

        public abstract string Flap();
        public override string Walk()
        {
            string walkStatement = "The " + AnimalName + " walks around its nest in the " + LivesIn + ".";
            Console.WriteLine(walkStatement);
            return walkStatement;
        }
    }
}
