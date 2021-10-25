using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Entities
{
    public class ModernChaise : IChaise
    {
        public ModernChaise()
        {
            Console.WriteLine("Chaise moderne");
        }
    }
}
