using System;

namespace Exercise.AnimalChoirSimulator
{
    class Cat : IAnimal
    {
        private Loudness _loudness = Loudness.LOW;
        public Loudness Loudness
        {
            get
            {
                return _loudness;
            }
            set
            {
                _loudness = value;
            }
        }

        public Cat() { Loudness = Loudness.LOW; }
        public Cat(Loudness loudness)
        {
            Loudness = loudness;
        }

        public void Sing()
        {
            switch (Loudness)
            {
                case Loudness.LOW:      Console.Write(" meow "); break;
                case Loudness.MEDIUM:   Console.Write(" Meow "); break;
                case Loudness.HIGH:     Console.Write(" MEOW "); break;
                default:
                    Console.Write("meow"); break;
            }
        }
    }
}
