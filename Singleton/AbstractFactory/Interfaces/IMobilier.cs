using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Interfaces
{
    public interface IMobilier
    {
        public IChaise CreateChaise();

        public ITableBasse CreateTableBasse();
    }
}
