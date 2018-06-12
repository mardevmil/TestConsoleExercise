using System;

namespace Exercise
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
            Console.WriteLine("This is test method in Singelton class");
        }
    }
}
