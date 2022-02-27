using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using VirtualInstrumentation.Interfaces;

namespace VirtualInstrumentation
{
    public partial class MainForm : Form, IForm
    {
        private double _centerX;
        private int _rank;

        private bool _isWork;
        private bool _isWrite;

        public event Action<double, double, double, double, double, double> Start;
        public event Action Stop;
        public event Action Exit;
        public event Action Write;
        public event Action NWrite;

        public event Action<int, double> WXChange;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Chart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            Chart.ChartAreas[0].AxisY.Interval = 10;
            _rank = 5;
            _isWork = false;
            _isWrite = false;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (_isWork)
            {
                StopWork();
            }
            else
            {
                StartWork();
            }

            _isWork = !_isWork;
        }

        private void StartWork()
        {
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

        private void StopWork()
        {
            Stop?.Invoke();
            Chart.Series.Clear();
            Chart.ChartAreas.Clear();
        }

        private void WriteBtn_Click(object sender, EventArgs e)
        {
            if (_isWrite)
            {
                StopWrite();
            }
            else
            {
                StartWrite();
            }

            _isWrite = !_isWrite;
        }

        private void StartWrite()
        {
            Write?.Invoke();
        }

        private void StopWrite()
        {
            NWrite?.Invoke();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if (!_isWork && !_isWrite)
            {
                KillInstrument();
                return;
            }
            
            if (_isWrite)
            {
                StopWrite();
                _isWrite = false;
            }
            if (_isWork)
            {
                StopWork();
                _isWork = false;
            }
        }

        private void KillInstrument()
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

        public void UpdateChart(DateTime newX, double newY)
        {
            if (InvokeRequired)
            {
                _ = Invoke(new Action(() => UpdateChart(newX, newY)));
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

                Chart.Series[0].Points.AddXY(x, newY);
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
                XBase0TB.Text = Math.Round(x0, _rank).ToString($"F{_rank}");
                XBase1TB.Text = Math.Round(x1, _rank).ToString($"F{_rank}");
                XBase2TB.Text = Math.Round(x2, _rank).ToString($"F{_rank}");
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
                XFilter0TB.Text = Math.Round(x0, _rank).ToString($"F{_rank}");
                XFilter1TB.Text = Math.Round(x1, _rank).ToString($"F{_rank}");
                XFilter2TB.Text = Math.Round(x2, _rank).ToString($"F{_rank}");
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
                YBaseTB.Text = Math.Round(y, _rank).ToString($"F{_rank}");
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
                YFilterTB.Text = Math.Round(y, _rank).ToString($"F{_rank}");
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
