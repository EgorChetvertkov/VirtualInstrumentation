using System;
using System.Threading;
using System.Threading.Tasks;

using VirtualInstrumentation.Interfaces;

namespace VirtualInstrumentation.Model
{
    internal class Instrument : IModel
    {
        private Timer _timer;

        private Generator _x0Generator;
        private Generator _x1Generator;
        private Generator _x2Generator;

        private Filter _x0Filter;
        private Filter _x1Filter;
        private Filter _x2Filter;
        private Filter _yFilter;

        private Function _function;

        public event Action<DateTime, double, double> NextPoint;
        public event Action<double, double, double> BaseXs;
        public event Action<double, double, double> FilterXs;
        public event Action<double> BaseY;
        public event Action<double> FilterY;
        public event Action<InstrumentMessage> Message;

        public Instrument()
        {
            _function = new Function();
        }

        private void TimerCallback(object state)
        {
            AsyncStep();
        }

        private async void AsyncStep()
        {
            await Task.Run(() => Step());
        }

        private void Step()
        {
            double x0 = _x0Generator.Next();
            double x1 = _x1Generator.Next();
            double x2 = _x2Generator.Next();
            BaseXs?.Invoke(x0, x1, x2);
            Message?.Invoke(new InstrumentMessage(TypeMessage.Информация, $"Получены данные."));

            x0 = _x0Filter.ExpRunningAverage(x0);
            x1 = _x1Filter.ExpRunningAverage(x1);
            x2 = _x2Filter.ExpRunningAverage(x2);
            FilterXs?.Invoke(x0, x1, x2);
            Message?.Invoke(new InstrumentMessage(TypeMessage.Информация, $"Данные сглажены."));

            double y = _function.Calculate(x0, x1, x2);
            BaseY?.Invoke(y);
            Message?.Invoke(new InstrumentMessage(TypeMessage.Информация, $"Расчитано значение."));

            double filtredY = _yFilter.ExpRunningAverage(y);
            FilterY?.Invoke(filtredY);
            Message?.Invoke(new InstrumentMessage(TypeMessage.Информация, $"Значение сглажено."));

            NextPoint?.Invoke(DateTime.Now, filtredY, y);
            Message?.Invoke(new InstrumentMessage(TypeMessage.Информация, $"Выведена точка."));
        }

        public void Start(double w0, double w1, double w2, double w3, double w4, double w5)
        {
            _x0Generator = new Generator(10, 5, -5);
            _x1Generator = new Generator(144, 5, -5);
            _x2Generator = new Generator(1024, 5, -5);

            _x0Filter = new Filter(0.7, _x0Generator.CurrentValue);
            _x1Filter = new Filter(0.7, _x1Generator.CurrentValue);
            _x2Filter = new Filter(0.7, _x2Generator.CurrentValue);

            _function.UpdateWs(w0, w1, w2, w3, w4, w5);
            _yFilter = new Filter(0.7,
                _function.Calculate(_x0Generator.CurrentValue, _x1Generator.CurrentValue, _x2Generator.CurrentValue));

            _timer = new Timer(TimerCallback, null, 0, 1000);
        }

        public void UpdateW(int code, double w)
        {
            switch (code)
            {
                case 0:
                    _function.W0 = w;
                    break;
                case 1:
                    _function.W1 = w;
                    break;
                case 2:
                    _function.W2 = w;
                    break;
                case 3:
                    _function.W3 = w;
                    break;
                case 4:
                    _function.W4 = w;
                    break;
                case 5:
                    _function.W5 = w;
                    break;
                default:
                    break;
            }

            Message?.Invoke(new InstrumentMessage(TypeMessage.Информация, $"Вес {code} изменен на {w}."));
        }

        public void Stop()
        {
            _timer?.Dispose();
            Message?.Invoke(new InstrumentMessage(TypeMessage.Информация, $"Счет прекращен."));
        }
    }
}
