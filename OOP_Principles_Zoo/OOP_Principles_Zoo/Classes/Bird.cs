using System;
using System.Collections.Generic;
using System.Text;
using OOP_Principles_Zoo.Interfaces;

namespace OOP_Principles_Zoo.Classes
{
    public abstract class Bird : Animal, IFly
    {
        public override bool IsReal { get; set; } = true;
        public override int NumberOfLegs { get; set; } = 2;
        public bool HasWings { get; set; } = true;
        public virtual string LivesIn { get; set; } = "city";
        public virtual bool IsFlying { get; set; } = false;

        public abstract string Flap();
        public override string Walk()
        {
            string walkStatement = "The " + AnimalName + " walks around its nest in the " + LivesIn + ".";
            Console.WriteLine(walkStatement);
            return walkStatement;
        }
        public abstract string TakeOff();
        public abstract string Land(string location);
    }
}
