using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = MySingleton.GetInstance();
            var singleton2 = MySingleton.GetInstance();

            if (singleton1 == singleton2)
            {
                Console.WriteLine("ils sont égaux");
            }
            else
            {
                Console.WriteLine("Pas égaux");
            }

        }
    }
}
