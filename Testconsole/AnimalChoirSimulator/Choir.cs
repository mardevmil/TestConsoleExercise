using System;
using System.Collections.Generic;

namespace Testconsole.AnimalChoirSimulator
{
    class Choir
    {
        private int _crescendoStep = 0; // just for testng from console
        private int _arpeggioStep = 0;
        
        private List<SingerGroup> _singerGroups;
        private List<IAnimal> _singers;

        public Choir(SingerGroup lowSingerGroup, SingerGroup mediumSingerGroup, SingerGroup highSingerGroup)
        {
            _singers = new List<IAnimal>();
            _singerGroups = new List<SingerGroup>();
            _singerGroups.Add(mediumSingerGroup);
            _singerGroups.Add(lowSingerGroup);
            _singerGroups.Add(highSingerGroup);

            _singerGroups.Sort
            (
                (x, y) =>
                {
                    if (x.LoudnessLevel < y.LoudnessLevel)
                        return -1;
                    else if (x.LoudnessLevel > y.LoudnessLevel)
                        return 1;
                    return 0;
                }
            );            
        }

        public void Crescendo()
        {
            if (_crescendoStep >= _singerGroups.Count)
            {
                _singers.Clear();
                _crescendoStep = 0;
            }

            if(_crescendoStep == 0)
            {
                //_lowSingerGroup.ListOfSingers.ForEach(animal => _singers.Add(animal));
                _singerGroups[_crescendoStep].ListOfSingers.ForEach(animal => _singers.Add(animal));                
            }
            else if(_crescendoStep > 0)
            {
                Random rnd = new Random();
                int randomIndex = rnd.Next(0, _singerGroups[_crescendoStep].ListOfSingers.Count);
                _singers.Add(_singerGroups[_crescendoStep].ListOfSingers[randomIndex]);
            }
            _singers.ForEach(animal => animal.Sing());
            _crescendoStep++;
            Console.Write("\n");
        }

        public void Arpeggio()
        {
            if (_arpeggioStep >= _singerGroups.Count)
                _arpeggioStep = 0;

            _singerGroups[_arpeggioStep++].ListOfSingers.ForEach(animal => animal.Sing());
            Console.Write("\n");
        }
    }
}
