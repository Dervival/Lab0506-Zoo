using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles_Zoo.Interfaces
{
    public interface IFly
    {
        bool IsFlying { get; set; }
        string TakeOff();
        string Land(string location);
    }
}
