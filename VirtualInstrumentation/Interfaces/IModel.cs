using System;

namespace VirtualInstrumentation.Interfaces
{
    internal interface IModel
    {
        event Action<DateTime, double> NextPoint;
        event Action<double, double, double> BaseXs;
        event Action<double, double, double> FilterXs;
        event Action<double> BaseY;
        event Action<double> FilterY;
        event Action<InstrumentMessage> Message;

        void Start(double w0, double w1, double w2, double w3, double w4, double w5);
        void Stop();
        void UpdateW(int code, double w);
        void StartWriteDB();
        void StopWriteDB();
    }
}
