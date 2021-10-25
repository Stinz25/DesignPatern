using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Entities
{
    public class VictorianTableBasse : ITableBasse
    {
        public VictorianTableBasse()
        {
            Console.WriteLine("Table basse victorian");
        }
    }
}
