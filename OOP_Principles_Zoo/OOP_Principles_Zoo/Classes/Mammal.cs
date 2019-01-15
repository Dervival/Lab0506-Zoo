using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles_Zoo.Classes
{
    public abstract class Mammal : Animal
    {
        //Properties
        public override bool IsReal { get; set; } = true;
        public virtual bool HasFur {get; set;} = true;
        //Methods
        public abstract string BrushSelf();
    }
}
