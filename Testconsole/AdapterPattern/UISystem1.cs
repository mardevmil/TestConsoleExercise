using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testconsole.AdapterPattern
{
    public class UISystem1
    {
        private int _score = 0;
        private int _health = 0;

        public void IncreaseScore(int score)
        {
            _score += score;
        }

        public void IncreaseHealth(int health)
        {
            _health += health;
        }

        public void RefreshHealth()
        {
            Console.WriteLine("Health: " + _health);
        }

        public void RefreshScore()
        {
            Console.WriteLine("Score: " + _score);
        }
    }
}
