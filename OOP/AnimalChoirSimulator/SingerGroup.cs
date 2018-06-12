using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.AnimalChoirSimulator
{
    class SingerGroup
    {
        private Loudness _loudness = Loudness.LOW;
        public Loudness LoudnessLevel { get => _loudness; }

        public List<IAnimal> ListOfSingers;

        public SingerGroup()
        {
            ListOfSingers = new List<IAnimal>();
            _loudness = Loudness.LOW;
        }
        public SingerGroup(Loudness loudness)
        {
            ListOfSingers = new List<IAnimal>();
            _loudness = loudness;
        }
        public SingerGroup(Loudness loudness, List<IAnimal> list)
        {
            ListOfSingers = new List<IAnimal>();
            _loudness = loudness;
            list.ForEach(animal => AddToSingerGroup(animal));
            //for (int i = 0; i < list.Count; i++)
            //    AddToSingerGroup(list[i]);
        }

        public void AddToSingerGroup(IAnimal animal)
        {
            if (animal.Loudness == _loudness)
                ListOfSingers.Add(animal);
            else
                Console.WriteLine("Animal " + animal.GetType() + " doesn't have right loudnass, so it can't be added in singer group!");
        }
    }
}
