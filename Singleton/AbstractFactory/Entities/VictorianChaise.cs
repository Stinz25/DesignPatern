using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Entities
{
    public class VictorianChaise : IChaise
    {
        public VictorianChaise()
        {
            Console.WriteLine("Chaise victorian");
        }
    }
}
