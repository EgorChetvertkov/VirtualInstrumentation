using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using VirtualInstrumentation.Interfaces;

namespace VirtualInstrumentation
{
    public partial class MainForm : Form, IForm
    {
        private double _centerX;

        public event Action<double, double, double, double, double, double> Start;
        public event Action Stop;
        public event Action Exit;

        public event Action<int, double> WXChange;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Chart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            Chart.ChartAreas[0].AxisY.Interval = 10;
            StopBtn.Enabled = false;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            StartBtn.Enabled = false;
            StopBtn.Enabled = true;
            Chart.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            Chart.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();
            _centerX = (Chart.ChartAreas[0].AxisX.Minimum + Chart.ChartAreas[0].AxisX.Maximum) / 2;

            Start?.Invoke(
                (double)Weight0NUD.Value,
                (double)Weight1NUD.Value,
                (double)Weight2NUD.Value,
                (double)Weight3NUD.Value,
                (double)Weight4NUD.Value,
                (double)Weight5NUD.Value
                );
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            Stop?.Invoke();
            StartBtn.Enabled = true;
            Chart.Series.Clear();
            Chart.ChartAreas.Clear();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Exit?.Invoke();
            Application.Exit();
        }

        private void Weight0NUD_ValueChanged(object sender, EventArgs e)
        {
            WXChange?.Invoke(0, Convert.ToDouble(Weight0NUD.Value));
        }

        private void Weight3NUD_ValueChanged(object sender, EventArgs e)
        {
            WXChange?.Invoke(3, Convert.ToDouble(Weight3NUD.Value));
        }

        private void Weight1NUD_ValueChanged(object sender, EventArgs e)
        {
            WXChange?.Invoke(1, Convert.ToDouble(Weight1NUD.Value));
        }

        private void Weight4NUD_ValueChanged(object sender, EventArgs e)
        {
            WXChange?.Invoke(4, Convert.ToDouble(Weight4NUD.Value));
        }

        private void Weight2NUD_ValueChanged(object sender, EventArgs e)
        {
            WXChange?.Invoke(2, Convert.ToDouble(Weight2NUD.Value));
        }

        private void Weight5NUD_ValueChanged(object sender, EventArgs e)
        {
            WXChange?.Invoke(5, Convert.ToDouble(Weight5NUD.Value));
        }

        public void UpdateChart(DateTime newX, double newFiltredY, double newY)
        {
            if (InvokeRequired)
            {
                _ = Invoke(new Action(() => UpdateChart(newX, newFiltredY, newY)));
            }
            else
            {
                double x = newX.ToOADate();

                if (x >= _centerX)
                {
                    Chart.ChartAreas[0].AxisX.Minimum = DateTime.Now.AddSeconds(-30).ToOADate();
                    Chart.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddSeconds(30).ToOADate();
                    _centerX = (Chart.ChartAreas[0].AxisX.Minimum + Chart.ChartAreas[0].AxisX.Maximum) / 2;
                }

                Chart.Series[0].Points.AddXY(x, newFiltredY);
                Chart.Series[1].Points.AddXY(x, newY);
            }
        }

        public void UpdateBaseXs(double x0, double x1, double x2)
        {
            if (InvokeRequired)
            {
                _ = Invoke(new Action(() => UpdateBaseXs(x0, x1, x2)));
            }
            else
            {
                XBase0TB.Text = Math.Round(x0, 3).ToString();
                XBase1TB.Text = Math.Round(x1, 3).ToString();
                XBase2TB.Text = Math.Round(x2, 3).ToString();
            }
        }

        public void UpdateFilterXs(double x0, double x1, double x2)
        {
            if (InvokeRequired)
            {
                _ = Invoke(new Action(() => UpdateFilterXs(x0, x1, x2)));
            }
            else
            {
                XFilter0TB.Text = Math.Round(x0, 3).ToString();
                XFilter1TB.Text = Math.Round(x1, 3).ToString();
                XFilter2TB.Text = Math.Round(x2, 3).ToString();
            }
        }

        public void UpdateBaseY(double y)
        {
            if (InvokeRequired)
            {
                _ = Invoke(new Action(() => UpdateBaseY(y)));
            }
            else
            {
                YBaseTB.Text = Math.Round(y, 2).ToString();
            }
        }

        public void UpdateFilterY(double y)
        {
            if (InvokeRequired)
            {
                _ = Invoke(new Action(() => UpdateFilterY(y)));
            }
            else
            {
                YFilterTB.Text = Math.Round(y, 2).ToString();
            }
        }

        public void PrintMessage(InstrumentMessage message)
        {
            if (InvokeRequired)
            {
                _ = Invoke(new Action(() => PrintMessage(message)));
            }
            else
            {
                InfoTB.Text = message.ToString();
            }
        }
    }
}
