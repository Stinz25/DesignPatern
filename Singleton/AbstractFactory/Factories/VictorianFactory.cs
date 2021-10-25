using AbstractFactory.Interfaces;
using AbstractFactory.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    public class VictorianFactory : IMobilier
    {
        public IChaise CreateChaise()
        {
            return new VictorianChaise();
        }

        public ITableBasse CreateTableBasse()
        {
            return new VictorianTableBasse();
        }
    }
}
