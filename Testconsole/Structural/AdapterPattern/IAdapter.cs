using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.AdapterPattern
{
    interface IAdapter
    {
        void IncreaseProgress();
        void IncreaseHealth();
    }
    
    public class AdapterUI1 : IAdapter
    {
        private UISystem1 ui { get; set; }

        public AdapterUI1(UISystem1 ui1)
        {
            ui = ui1;
        }

        public void IncreaseProgress()
        {
            ui.IncreaseScore(1);
            ui.RefreshScore();
        }

        public void IncreaseHealth()
        {
            ui.IncreaseHealth(1);
            ui.RefreshHealth();
        }
    }

    public class AdapterUI2 : IAdapter
    {
        private UISystem2 ui { get; set; }

        public AdapterUI2(UISystem2 ui2)
        {
            ui = ui2;
        }

        public void IncreaseProgress()
        {
            ui.AddMoreScore(1);
        }

        public void IncreaseHealth()
        {
            ui.AddMoreHealth(1);
        }
    }
}
