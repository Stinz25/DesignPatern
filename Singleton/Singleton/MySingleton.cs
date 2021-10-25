using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class MySingleton
    {
        private static MySingleton _instance;

        public static MySingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MySingleton();
            }
            return _instance;
        }
    }
}
