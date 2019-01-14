using System;
using OOP_Principles_Zoo.Classes;

namespace OOP_Principles_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Corgi ein = new Corgi();
            ein.Eat();
            ein.Sleep();
            ein.Walk();
            ein.BrushSelf();
            ein.Bark();
            Samoyed sam = new Samoyed();
            sam.Bark();
            sam.BrushSelf();
            sam.SamoyedEat();
            sam.Eat();
            sam.Walk();
            sam.Sleep();
            sam.RollOver();
        }
    }
}
