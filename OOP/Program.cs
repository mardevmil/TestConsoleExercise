using System;
using Exercise.AbstractClass;
using Exercise.AnimalChoirSimulator;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n************************ Abstract Class using *************************** ");
            // this is possible, but 
            //THIS Person s = new Person() isn't
            //Person s = new Student();         
            Student s = new Student();
            s.Name = "Marko";
            s.PrintName();
            s.PrintHeight();
            s.CalculateSomething();

            var dog1 = new Dog(Loudness.LOW);
            var dog2 = new Dog(Loudness.MEDIUM);
            var dog3 = new Dog(Loudness.HIGH);

            var cat1 = new Cat(Loudness.LOW);
            var cat2 = new Cat(Loudness.MEDIUM);
            var cat3 = new Cat(Loudness.HIGH);

            var mouse1 = new Mouse(Loudness.LOW);
            var mouse2 = new Mouse(Loudness.MEDIUM);
            var mouse3 = new Mouse(Loudness.HIGH);

            var lowSingerGroup = new SingerGroup(Loudness.LOW);
            lowSingerGroup.AddToSingerGroup(dog1);
            lowSingerGroup.AddToSingerGroup(cat1);
            lowSingerGroup.AddToSingerGroup(mouse1);

            var mediumSingerGroup = new SingerGroup(Loudness.MEDIUM);
            mediumSingerGroup.AddToSingerGroup(dog2);
            mediumSingerGroup.AddToSingerGroup(cat2);
            mediumSingerGroup.AddToSingerGroup(mouse2);

            var highSingerGroup = new SingerGroup(Loudness.HIGH);
            highSingerGroup.AddToSingerGroup(dog3);
            highSingerGroup.AddToSingerGroup(cat3);
            highSingerGroup.AddToSingerGroup(mouse3);

            //highSingerGroup.AddToSingerGroup(mouse1);

            Choir choir = new Choir(lowSingerGroup, mediumSingerGroup, highSingerGroup);

            Console.WriteLine("\n************************ Animal Choir Simulator *************************** ");
            Console.WriteLine("Press C for Crescendo or A for Arpeggio. Space for exit." );
            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey(true);
                

                if (keyinfo.Key == ConsoleKey.C)
                {
                    choir.Crescendo();
                }

                if (keyinfo.Key == ConsoleKey.A)
                {
                    choir.Arpeggio();
                }
            }
            while (keyinfo.Key != ConsoleKey.Spacebar);
        }
    }
}
