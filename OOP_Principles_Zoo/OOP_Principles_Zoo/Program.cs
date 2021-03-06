﻿using System;
using OOP_Principles_Zoo.Classes;

namespace OOP_Principles_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Corgi ein = new Corgi();
            Samoyed sam = new Samoyed();
            Pidgeon pete = new Pidgeon();
            Eagle ethan = new Eagle();
            Snake sal = new Snake();
            Dragon dan = new Dragon();
            Console.WriteLine("Meet Ein the " + ein.AnimalName + ".");
            ein.Eat();
            ein.Sleep();
            ein.Walk();
            ein.BrushSelf();
            ein.Bark();
            ein.Flop();
            Console.WriteLine("\nMeet Sam the " + sam.AnimalName + ".");
            sam.Eat();
            sam.Sleep();
            sam.Walk();
            sam.BrushSelf();
            sam.Bark();
            sam.SamoyedEat();
            sam.RollOver();
            Console.WriteLine("\nMeet Pete the " + pete.AnimalName + ".");
            pete.Eat();
            pete.Sleep();
            pete.Walk();
            pete.Flap();
            pete.TakeOff();
            pete.TakeOff();
            pete.Land("home");
            pete.Land("elseswhere");
            pete.Coo();
            Console.WriteLine("\nMeet Ethan the " + ethan.AnimalName + ".");
            ethan.Eat();
            ethan.Sleep();
            ethan.Walk();
            ethan.Flap();
            ethan.Hunt("snake");
            ethan.TakeOff();
            ethan.Land("the zoo");
            Console.WriteLine("\nMeet Sal the " + sal.AnimalName + ".");
            sal.StopHibernating();
            sal.Eat();
            sal.Sleep();
            sal.Walk();
            sal.Firebreath();
            sal.StartHibernating();
            sal.StopHibernating();
            Console.WriteLine("\nFinally, meet Dan the " + dan.AnimalName + ".");
            dan.Eat();
            dan.Sleep();
            dan.Walk();
            dan.Firebreath();
            dan.Fly();
            dan.TakeOff();
            dan.Land("your car");
            dan.StartHibernating();
            Console.WriteLine("\nThank you for visiting the zoo.");
        }
    }
}
