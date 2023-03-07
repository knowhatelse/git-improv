using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitImprov.Helpers
{
    public class Labels
    {
        public Label Timer;
        public Label GuitarPlayer;
        public Label Mode;
        public Label Technique;

        public Labels(Label timer, Label guitarPlayer, Label mode, Label technique)
        {
            Timer = timer;
            GuitarPlayer = guitarPlayer;
            Mode = mode;
            Technique = technique;
        }
    }
}
