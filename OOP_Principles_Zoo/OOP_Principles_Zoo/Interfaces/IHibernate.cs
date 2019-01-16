using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles_Zoo.Interfaces
{
    public interface IHibernate
    {
        bool IsHibernating { get; set; }
        string StartHibernating();
        string StopHibernating();
    }
}
