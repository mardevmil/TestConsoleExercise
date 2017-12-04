﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testconsole.AdapterPattern
{
    public class UISystem2
    {
        private int _score = 0;
        private int _health = 0;

        public void AddMoreHealth(int health)
        {
            _health += health;
            Console.WriteLine("Health: " + _health);
        }

        public void AddMoreScore(int score)
        {
            _score += score;
            Console.WriteLine("Score: " + _score);
        }
    }
}
