using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.AdapterPattern
{
    public class UISystem2
    {
        private int _score = 0;
        private int _health = 0;

        public void AddMoreHealth(int health)
        {
            _health += health;
            Console.WriteLine(this.GetType().Name + " Health: " + _health);
        }

        public void AddMoreScore(int score)
        {
            _score += score;
            Console.WriteLine(this.GetType().Name + " Score: " + _score);
        }
    }
}
