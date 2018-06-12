using System;

namespace Exercise.AdapterPattern
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
            Console.WriteLine(this.GetType().Name + " Health: " + _health);
        }

        public void RefreshScore()
        {
            Console.WriteLine(this.GetType().Name + " Score: " + _score);
        }
    }
}
