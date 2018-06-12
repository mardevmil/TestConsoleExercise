using System;

namespace Exercise.AnimalChoirSimulator
{
    class Mouse : IAnimal
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

        public Mouse() { Loudness = Loudness.LOW; }
        public Mouse(Loudness loudness)
        {
            Loudness = loudness;
        }

        public void Sing()
        {
            switch (Loudness)
            {
                case Loudness.LOW:      Console.Write(" squeak "); break;
                case Loudness.MEDIUM:   Console.Write(" Squeak "); break;
                case Loudness.HIGH:     Console.Write(" SQUEAK "); break;
                default:
                    Console.Write("squeak");  break;
            }
        }
    }
}
