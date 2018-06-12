using System;
using System.Runtime.InteropServices;

namespace Exercise.Observer
{
    class Game
    {
        private int _score = 0;
        private ScoreObserver _scoreObserver;

        public int Score
        {
            get { return _score; }
            set
            {
                _score = value;
                _scoreObserver.Notify();
            }
        }

        private static Game instance;

        private Game()
        {
            _scoreObserver = new ScoreObserver();
            var uiController = new UIController();
            var achievementController = new AchievementController();

            _scoreObserver.Attach(uiController);
            _scoreObserver.Attach(achievementController);
        }

        public static Game Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Game();
                }
                return instance;
            }
        }        
    }
}
