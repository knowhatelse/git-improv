using GitImprov.DTO;
using GitImprov.Generators;

namespace GitImprov.Controllers
{
    internal class TimerController
    {
        private const int ZERO_TIME = 0;
        private const int STOP_TIME = -1;
        private const int THREAD_PAUSE_TIME = 1000;

        private static readonly Random _random = new();

        private static readonly GuitarPlayerService _guitarPlayerService = GuitarPlayerService.GetInstance();
        private static readonly ModeService _modeService = ModeService.GetInstance();
        private static readonly TechniqueService _techniqueService = TechniqueService.GetInstance();

        private static int _counter = 30;
        private static int _time = 30;
        private static bool _isPaused;

        private static ControlsDto? _controls;
        private static Form? _form;
        private static Thread? _timerThread;


        private static void UpdateDisplay()
        {
            var guitarPlayer = _guitarPlayerService.GetRandomGuitarPlayer();
            var mode = _modeService.GetRandomMode();
            var technique = _techniqueService.GetRandomTechnique();

            MethodInvoker invoker = delegate
            {
                _controls!.GuitarPlayer!.Text = guitarPlayer is null ? string.Empty : guitarPlayer.Name;
                _controls!.Mode!.Text = mode is null ? string.Empty : mode.Name;
                _controls!.Technique!.Text = technique is null ? string.Empty : technique.Name;
                _controls!.Notes!.Text = _random.Next(1, 5).ToString();
            };

            _form?.Invoke(invoker);
        }

        private static void Run()
        {
            while (_counter > ZERO_TIME)
            {
                if (!_isPaused)
                {
                    MethodInvoker invoker = delegate
                    {
                        _controls!.Timer!.Text = _counter.ToString();
                    };

                    _form?.Invoke(invoker);
                    Thread.Sleep(THREAD_PAUSE_TIME);
                    _counter--;

                    if (_counter == ZERO_TIME)
                    {
                        UpdateDisplay();
                        _counter = _time;
                    }
                }
            }
        }

        public static void SetTimer(int time)
        {
            if (time > ZERO_TIME)
            {
                _time = time;
                _counter = time;
            }
        }

        public static void Restart()
        {
            _counter = _time;
            UpdateDisplay();
        }

        public static void Start(ControlsDto controls, Form form)
        {
            _controls = controls;
            _form = form;

            UpdateDisplay();

            Thread timerThread = new(Run);
            _timerThread = timerThread;
            timerThread.Start();

            Restart();
        }

        public static void Stop()
        {
            _counter = STOP_TIME;

            _controls!.Timer!.Text = string.Empty;
            _controls!.GuitarPlayer!.Text = string.Empty;
            _controls!.Mode!.Text = string.Empty;
            _controls!.Technique!.Text = string.Empty;
            _controls!.Notes!.Text = string.Empty;

            _isPaused = false;

            try
            {
#pragma warning disable CS8602
#pragma warning disable SYSLIB0006
                _timerThread.Abort();
#pragma warning restore SYSLIB0006
#pragma warning restore CS8602
            }
            catch (Exception) { }
        }

        public static void Pause()
        {
            _isPaused = true;
        }

        public static void Resume()
        {
            _isPaused = false;
        }

    }
}
