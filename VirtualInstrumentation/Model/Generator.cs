using System;

namespace VirtualInstrumentation.Model
{
    internal class Generator
    {
        private Random _random;
        private double _max;
        private double _min;

        public double CurrentValue { get; private set; }

        public Generator(int seed, double max, double min)
        {
            _random = new Random(seed);
            CurrentValue = NextValue();
            _max = max;
            _min = min;
        }

        private double NextValue()
        {
            return (_random.NextDouble() * 10) - 5;
        }

        private double NextReadValue()
        {
            double value = NextValue();

            if (Math.Abs(CurrentValue - value) <= 0.5)
            {
                CurrentValue = value;
            }
            else
            {
                double direction = _random.NextDouble() / 2;
                CurrentValue = value < CurrentValue ? CurrentValue - direction : CurrentValue + direction;
            }

            return CurrentValue;
        }

        private double NextErrorRate()
        {
            return _random.NextDouble() / 1000;
        }

        public double Next()
        {
            double result = NextReadValue() + NextErrorRate();

            if (result > _max)
            {
                CurrentValue = _max - _random.NextDouble() / 2;
                return CurrentValue;
            }
            if (result < _min)
            {
                CurrentValue = _min + _random.NextDouble() / 2;
                return CurrentValue;
            }
            
            return result;
        }
    }
}
