using System;

namespace VirtualInstrumentation.Model
{
    internal class Generator
    {
        private Random _random;
        private double _previousValue;

        public Generator(double start)
        {
            _random = new Random();
            _previousValue = start;
        }

        private double NextReadValue()
        {
            double value = (_random.NextDouble() * 10) - 5;

            if (Math.Abs(_previousValue - value) <= 0.5)
            {
                _previousValue = value;
                return _previousValue;
            }

            _previousValue = value < _previousValue ? _previousValue - (_previousValue / 2) : _previousValue + (_previousValue / 2);

            return _previousValue;
        }

        private double NextErrorRate()
        {
            return _random.NextDouble() / 1000;
        }

        public double Next()
        {
            return NextReadValue() + NextErrorRate();
        }
    }
}
