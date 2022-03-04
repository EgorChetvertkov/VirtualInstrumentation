using System;

namespace VirtualInstrumentation.Interfaces
{
    internal interface IForm
    {
        event Action<double, double, double, double, double, double> Start;
        event Action Stop;
        event Action Exit;

        event Action<int, double> WXChange;

        void UpdateChart(DateTime newX, double newFiltredY, double newY);
        void UpdateBaseXs(double x0, double x1, double x2);
        void UpdateFilterXs(double x0, double x1, double x2);
        void UpdateBaseY(double y);
        void UpdateFilterY(double y);
        void PrintMessage(InstrumentMessage message);
    }
}
