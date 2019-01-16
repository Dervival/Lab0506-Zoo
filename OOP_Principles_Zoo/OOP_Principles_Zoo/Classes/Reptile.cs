using System;
using System.Collections.Generic;
using System.Text;
using OOP_Principles_Zoo.Interfaces;

namespace OOP_Principles_Zoo.Classes
{
    public abstract class Reptile : Animal, IHibernate
    {
        public virtual bool BreathesFire { get; set; } = false;

        public abstract bool IsHibernating { get; set; }

        public abstract string StartHibernating();
        public abstract string StopHibernating();

        public override string Sleep()
        {
            string sleepMessage = "The " + AnimalName + " sleeps in its den.";
            Console.WriteLine(sleepMessage);
            return sleepMessage;
        }

        public virtual string Firebreath()
        {
            string fireMessage = "The " + AnimalName + " looks sadly at you, as it cannot breathe fire.";
            Console.WriteLine(fireMessage);
            return fireMessage;
        }
    }
}
