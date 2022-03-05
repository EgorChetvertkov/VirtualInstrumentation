using System;

namespace VirtualInstrumentation.Model
{
    public class Function
    {
        private double _w0;
        private double _w1;
        private double _w2;
        private double _w3;
        private double _w4;
        private double _w5;

        public double W0 { get { return _w0; } set { _w0 = ValidWeight(value); } }
        public double W1 { get { return _w1; } set { _w1 = ValidWeight(value); } } 
        public double W2 { get { return _w2; } set { _w2 = ValidWeight(value); } }
        public double W3 { get { return _w3;} set { _w3 = ValidWeight(value); } }
        public double W4 { get { return _w4; } set { _w4 = ValidWeight(value); } }
        public double W5 { get { return _w5; } set { _w5 = ValidWeight(value); } }


        public void UpdateWs(double w0, double w1, double w2, double w3, double w4, double w5)
        {
            W0 = w0;
            W1 = w1;
            W2 = w2;
            W3 = w3;
            W4 = w4;
            W5 = w5;
        }

        public double Calculate(double x0, double x1, double x2)
        {
            return (_w0 * x0) + 
                (_w3 * Math.Sin(_w1 * x1)) + (_w4 * Math.Cos(_w2 * x2)) + _w5;
        }

        private double ValidWeight(double w)
        {
            return w >= -5 && w <= 5 ? w : 0;
        }

    }
}
