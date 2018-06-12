using System;

namespace Exercise.AnimalChoirSimulator
{
    class Dog : IAnimal
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

        public Dog() { Loudness = Loudness.LOW; }

        public Dog(Loudness loudness)
        {
            Loudness = loudness;
        }

        public void Sing()
        {
            switch (Loudness)
            {
                case Loudness.LOW:      Console.Write(" bark "); break;
                case Loudness.MEDIUM:   Console.Write(" Bark "); break;
                case Loudness.HIGH:     Console.Write(" BARK "); break;
                default:
                    Console.Write("bark"); break;
            }
        }
    }
}
