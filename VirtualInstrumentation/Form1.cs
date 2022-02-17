using System;
using System.Windows.Forms;

namespace VirtualInstrumentation
{
    public partial class MainForm : Form
    {
        public event Action Start;
        public event Action Stop;
        public event Action Exit;

        public event Action<double> W0Change;
        public event Action<double> W1Change;
        public event Action<double> W2Change;
        public event Action<double> W3Change;
        public event Action<double> W4Change;
        public event Action<double> W5Change;

        public MainForm()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            Start?.Invoke();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            Stop?.Invoke();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Exit?.Invoke();
        }

        private void Weight0NUD_ValueChanged(object sender, EventArgs e)
        {
            W0Change?.Invoke(Convert.ToDouble(Weight0NUD.Value));
        }

        private void Weight3NUD_ValueChanged(object sender, EventArgs e)
        {
            W3Change?.Invoke(Convert.ToDouble(Weight3NUD.Value));
        }

        private void Weight1NUD_ValueChanged(object sender, EventArgs e)
        {
            W1Change?.Invoke(Convert.ToDouble(Weight1NUD.Value));
        }

        private void Weight4NUD_ValueChanged(object sender, EventArgs e)
        {
            W4Change?.Invoke(Convert.ToDouble(Weight4NUD.Value));
        }

        private void Weight2NUD_ValueChanged(object sender, EventArgs e)
        {
            W2Change?.Invoke(Convert.ToDouble(Weight2NUD.Value));
        }

        private void Weight5NUD_ValueChanged(object sender, EventArgs e)
        {
            W5Change?.Invoke(Convert.ToDouble(Weight5NUD.Value));
        }

        public void UpdateChart(double newY, double newX)
        {
            //TODO. Add new point to Series. Shift Chart Area.
        }

        public void UpdateBaseXs(double x0, double x1, double x2)
        {
            //TODO. Print value xs in TBs
        }

        public void UpdateFilterXs(double x0, double x1, double x2)
        {
            //TODO. Print value xs in TBs
        }

        public void UpdateBaseY(double y)
        {
            //TODO. Print value y in TB
        }

        public void UpdateFilterY(double y)
        {
            //TODO. Print value y in TB
        }

        public void PrintMessage(InstrumentMessage message)
        {

        }
    }
}
