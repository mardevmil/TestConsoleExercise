using System;

namespace Testconsole
{
    class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        public void TestMethod()
        {
            Console.WriteLine("\n +++ This is test method in Singelton class");
        }
    }
}
