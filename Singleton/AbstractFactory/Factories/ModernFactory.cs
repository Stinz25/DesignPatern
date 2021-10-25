using AbstractFactory.Interfaces;
using AbstractFactory.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    public class ModernFactory : IMobilier
    {
        public IChaise CreateChaise()
        {
            return new ModernChaise();
        }

        public ITableBasse CreateTableBasse()
        {
            return new ModernTableBasse();
        }
    }
}
