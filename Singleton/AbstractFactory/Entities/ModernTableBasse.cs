using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Entities
{
    public class ModernTableBasse : ITableBasse
    {
        public ModernTableBasse()
        {
            Console.WriteLine("Table basse moderne");
        }
    }
}
