using GitImprov.DTO;
using GitImprov.Tests.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GitImprov.Helpers
{
    internal class Timer
    {
        private static int _counter = 15;
        private static int _time = 15;
        private static LabelsDto _labels;
        private static frmTest _form;

        public static void SetTimer(int time)
        {
            if (time > 0 )
            {
                _time = time;
                _counter = time;
            }
        }

        public static async void StartTimer(LabelsDto labels, Tests.GUI.frmTest form)
        {
            _labels = labels;
            _form = form;

            await Task.Run(() => RunTimer());

            Restart();
        }

        private static void RunTimer()
        {

            MethodInvoker inv1 = delegate
            {
                GuitarPlayerGenerator.GetRandomGuitarPlayer(_labels.GuitarPlayer);
                _labels.Mode.Text = ModesGenerator.GetRandomMode();
                _labels.Technique.Text = TechniqueGenerator.GetRandomTechnique();
            };
            _form.Invoke(inv1);

            while (_counter > 0)
            {
                MethodInvoker inv2 = delegate
                {
                   _labels.Timer.Text = _counter.ToString();
                };

                _form.Invoke(inv2);

                Thread.Sleep(1000);
                _counter--;

                if (_counter == 0)
                {
                    MethodInvoker inv3 = delegate
                    {
                        GuitarPlayerGenerator.GetRandomGuitarPlayer(_labels.GuitarPlayer);
                        _labels.Mode.Text = ModesGenerator.GetRandomMode();
                        _labels.Technique.Text = TechniqueGenerator.GetRandomTechnique();
                    };

                    _form.Invoke(inv3);
                    Repeat();
                }
            } 
        }

        private static void Repeat()
        {
            _counter = _time;
        }

        public static void StopTimer()
        {
            _counter = -1;
        }

        public static void Restart()
        {
            _counter = 15;

            MethodInvoker inv4 = delegate
            {
                _labels.Timer.Text = "-";
                _labels.GuitarPlayer.Text = "-";
                _labels.Mode.Text = "-";
                _labels.Technique.Text = "-";
            };
            _form.Invoke(inv4);
        }
    }
}
