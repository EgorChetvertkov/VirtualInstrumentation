namespace VirtualInstrumentation
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.XBase0Label = new System.Windows.Forms.Label();
            this.XBase0TB = new System.Windows.Forms.TextBox();
            this.XBase1TB = new System.Windows.Forms.TextBox();
            this.XBase1Label = new System.Windows.Forms.Label();
            this.XBase2TB = new System.Windows.Forms.TextBox();
            this.XBase2Label = new System.Windows.Forms.Label();
            this.BaseXGB = new System.Windows.Forms.GroupBox();
            this.IndicatorXBase2 = new System.Windows.Forms.Panel();
            this.IndicatorXBase1 = new System.Windows.Forms.Panel();
            this.IndicatorXBase0 = new System.Windows.Forms.Panel();
            this.FilterXGB = new System.Windows.Forms.GroupBox();
            this.IndicatorXFilter2 = new System.Windows.Forms.Panel();
            this.IndicatorXFilter1 = new System.Windows.Forms.Panel();
            this.IndicatorXFilter0 = new System.Windows.Forms.Panel();
            this.XFilter0TB = new System.Windows.Forms.TextBox();
            this.XFilter2TB = new System.Windows.Forms.TextBox();
            this.XFilter0Label = new System.Windows.Forms.Label();
            this.XFilter2Label = new System.Windows.Forms.Label();
            this.XFilter1Label = new System.Windows.Forms.Label();
            this.XFilter1TB = new System.Windows.Forms.TextBox();
            this.SettersParametrsGB = new System.Windows.Forms.GroupBox();
            this.Weight3NUD = new System.Windows.Forms.NumericUpDown();
            this.Weight3Label = new System.Windows.Forms.Label();
            this.Weight2NUD = new System.Windows.Forms.NumericUpDown();
            this.Weight2Label = new System.Windows.Forms.Label();
            this.Weight1NUD = new System.Windows.Forms.NumericUpDown();
            this.Weight1Label = new System.Windows.Forms.Label();
            this.Weight0NUD = new System.Windows.Forms.NumericUpDown();
            this.Weight0Label = new System.Windows.Forms.Label();
            this.Weight4NUD = new System.Windows.Forms.NumericUpDown();
            this.Weight4Label = new System.Windows.Forms.Label();
            this.Weight5NUD = new System.Windows.Forms.NumericUpDown();
            this.Weight5Label = new System.Windows.Forms.Label();
            this.YBaseTB = new System.Windows.Forms.TextBox();
            this.YFilterTB = new System.Windows.Forms.TextBox();
            this.YBaseLabel = new System.Windows.Forms.Label();
            this.YFilterLabel = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.BaseXGB.SuspendLayout();
            this.FilterXGB.SuspendLayout();
            this.SettersParametrsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Weight3NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight2NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight1NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight0NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight4NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight5NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart
            // 
            this.Chart.BackColor = System.Drawing.Color.Black;
            this.Chart.BorderlineColor = System.Drawing.Color.Black;
            chartArea13.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Lime;
            chartArea13.AxisX.LabelStyle.Format = "HH:mm:ss";
            chartArea13.AxisX.LineColor = System.Drawing.Color.Lime;
            chartArea13.AxisX.MajorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea13.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Lime;
            chartArea13.AxisX.Maximum = 9D;
            chartArea13.AxisX.Minimum = 0D;
            chartArea13.AxisX.MinorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea13.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Lime;
            chartArea13.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Lime;
            chartArea13.AxisX.TitleForeColor = System.Drawing.Color.Lime;
            chartArea13.AxisY.Interval = 11D;
            chartArea13.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Lime;
            chartArea13.AxisY.LineColor = System.Drawing.Color.Lime;
            chartArea13.AxisY.MajorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea13.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Lime;
            chartArea13.AxisY.Maximum = 55D;
            chartArea13.AxisY.Minimum = -55D;
            chartArea13.AxisY.MinorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea13.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Lime;
            chartArea13.AxisY.TitleForeColor = System.Drawing.Color.Lime;
            chartArea13.BackColor = System.Drawing.Color.Black;
            chartArea13.Name = "ChartArea";
            this.Chart.ChartAreas.Add(chartArea13);
            this.Chart.Location = new System.Drawing.Point(409, 13);
            this.Chart.Margin = new System.Windows.Forms.Padding(4);
            this.Chart.Name = "Chart";
            series13.BorderWidth = 2;
            series13.ChartArea = "ChartArea";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Color = System.Drawing.Color.Lime;
            series13.LabelForeColor = System.Drawing.Color.Lime;
            series13.Name = "Series1";
            series13.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.Chart.Series.Add(series13);
            this.Chart.Size = new System.Drawing.Size(762, 535);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "График функции";
            // 
            // XBase0Label
            // 
            this.XBase0Label.AutoSize = true;
            this.XBase0Label.Location = new System.Drawing.Point(7, 28);
            this.XBase0Label.Name = "XBase0Label";
            this.XBase0Label.Size = new System.Drawing.Size(33, 18);
            this.XBase0Label.TabIndex = 1;
            this.XBase0Label.Text = "x₀ =";
            // 
            // XBase0TB
            // 
            this.XBase0TB.BackColor = System.Drawing.Color.Black;
            this.XBase0TB.ForeColor = System.Drawing.Color.Lime;
            this.XBase0TB.Location = new System.Drawing.Point(46, 25);
            this.XBase0TB.Name = "XBase0TB";
            this.XBase0TB.ReadOnly = true;
            this.XBase0TB.Size = new System.Drawing.Size(55, 26);
            this.XBase0TB.TabIndex = 2;
            this.XBase0TB.Text = "-0.001";
            this.XBase0TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // XBase1TB
            // 
            this.XBase1TB.BackColor = System.Drawing.Color.Black;
            this.XBase1TB.ForeColor = System.Drawing.Color.Lime;
            this.XBase1TB.Location = new System.Drawing.Point(46, 57);
            this.XBase1TB.Name = "XBase1TB";
            this.XBase1TB.ReadOnly = true;
            this.XBase1TB.Size = new System.Drawing.Size(55, 26);
            this.XBase1TB.TabIndex = 4;
            this.XBase1TB.Text = "0.001";
            this.XBase1TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // XBase1Label
            // 
            this.XBase1Label.AutoSize = true;
            this.XBase1Label.Location = new System.Drawing.Point(7, 60);
            this.XBase1Label.Name = "XBase1Label";
            this.XBase1Label.Size = new System.Drawing.Size(33, 18);
            this.XBase1Label.TabIndex = 3;
            this.XBase1Label.Text = "x₁ =";
            // 
            // XBase2TB
            // 
            this.XBase2TB.BackColor = System.Drawing.Color.Black;
            this.XBase2TB.ForeColor = System.Drawing.Color.Lime;
            this.XBase2TB.Location = new System.Drawing.Point(46, 89);
            this.XBase2TB.Name = "XBase2TB";
            this.XBase2TB.ReadOnly = true;
            this.XBase2TB.Size = new System.Drawing.Size(55, 26);
            this.XBase2TB.TabIndex = 6;
            this.XBase2TB.Text = "0.001";
            this.XBase2TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // XBase2Label
            // 
            this.XBase2Label.AutoSize = true;
            this.XBase2Label.Location = new System.Drawing.Point(7, 92);
            this.XBase2Label.Name = "XBase2Label";
            this.XBase2Label.Size = new System.Drawing.Size(33, 18);
            this.XBase2Label.TabIndex = 5;
            this.XBase2Label.Text = "x₂ =";
            // 
            // BaseXGB
            // 
            this.BaseXGB.Controls.Add(this.YBaseLabel);
            this.BaseXGB.Controls.Add(this.IndicatorXBase2);
            this.BaseXGB.Controls.Add(this.YBaseTB);
            this.BaseXGB.Controls.Add(this.IndicatorXBase1);
            this.BaseXGB.Controls.Add(this.IndicatorXBase0);
            this.BaseXGB.Controls.Add(this.XBase0TB);
            this.BaseXGB.Controls.Add(this.XBase2TB);
            this.BaseXGB.Controls.Add(this.XBase0Label);
            this.BaseXGB.Controls.Add(this.XBase2Label);
            this.BaseXGB.Controls.Add(this.XBase1Label);
            this.BaseXGB.Controls.Add(this.XBase1TB);
            this.BaseXGB.Location = new System.Drawing.Point(12, 13);
            this.BaseXGB.Name = "BaseXGB";
            this.BaseXGB.Size = new System.Drawing.Size(171, 161);
            this.BaseXGB.TabIndex = 7;
            this.BaseXGB.TabStop = false;
            this.BaseXGB.Text = "Исходные значения";
            // 
            // IndicatorXBase2
            // 
            this.IndicatorXBase2.BackColor = System.Drawing.Color.Lime;
            this.IndicatorXBase2.Location = new System.Drawing.Point(125, 92);
            this.IndicatorXBase2.Name = "IndicatorXBase2";
            this.IndicatorXBase2.Size = new System.Drawing.Size(16, 16);
            this.IndicatorXBase2.TabIndex = 9;
            // 
            // IndicatorXBase1
            // 
            this.IndicatorXBase1.BackColor = System.Drawing.Color.Lime;
            this.IndicatorXBase1.Location = new System.Drawing.Point(125, 60);
            this.IndicatorXBase1.Name = "IndicatorXBase1";
            this.IndicatorXBase1.Size = new System.Drawing.Size(16, 16);
            this.IndicatorXBase1.TabIndex = 8;
            // 
            // IndicatorXBase0
            // 
            this.IndicatorXBase0.BackColor = System.Drawing.Color.Lime;
            this.IndicatorXBase0.Location = new System.Drawing.Point(125, 28);
            this.IndicatorXBase0.Name = "IndicatorXBase0";
            this.IndicatorXBase0.Size = new System.Drawing.Size(16, 16);
            this.IndicatorXBase0.TabIndex = 7;
            // 
            // FilterXGB
            // 
            this.FilterXGB.Controls.Add(this.YFilterLabel);
            this.FilterXGB.Controls.Add(this.YFilterTB);
            this.FilterXGB.Controls.Add(this.IndicatorXFilter2);
            this.FilterXGB.Controls.Add(this.IndicatorXFilter1);
            this.FilterXGB.Controls.Add(this.IndicatorXFilter0);
            this.FilterXGB.Controls.Add(this.XFilter0TB);
            this.FilterXGB.Controls.Add(this.XFilter2TB);
            this.FilterXGB.Controls.Add(this.XFilter0Label);
            this.FilterXGB.Controls.Add(this.XFilter2Label);
            this.FilterXGB.Controls.Add(this.XFilter1Label);
            this.FilterXGB.Controls.Add(this.XFilter1TB);
            this.FilterXGB.Location = new System.Drawing.Point(189, 13);
            this.FilterXGB.Name = "FilterXGB";
            this.FilterXGB.Size = new System.Drawing.Size(213, 161);
            this.FilterXGB.TabIndex = 8;
            this.FilterXGB.TabStop = false;
            this.FilterXGB.Text = "Сглаженные значения";
            // 
            // IndicatorXFilter2
            // 
            this.IndicatorXFilter2.BackColor = System.Drawing.Color.Lime;
            this.IndicatorXFilter2.Location = new System.Drawing.Point(118, 92);
            this.IndicatorXFilter2.Name = "IndicatorXFilter2";
            this.IndicatorXFilter2.Size = new System.Drawing.Size(16, 16);
            this.IndicatorXFilter2.TabIndex = 12;
            // 
            // IndicatorXFilter1
            // 
            this.IndicatorXFilter1.BackColor = System.Drawing.Color.Lime;
            this.IndicatorXFilter1.Location = new System.Drawing.Point(118, 60);
            this.IndicatorXFilter1.Name = "IndicatorXFilter1";
            this.IndicatorXFilter1.Size = new System.Drawing.Size(16, 16);
            this.IndicatorXFilter1.TabIndex = 11;
            // 
            // IndicatorXFilter0
            // 
            this.IndicatorXFilter0.BackColor = System.Drawing.Color.Lime;
            this.IndicatorXFilter0.Location = new System.Drawing.Point(118, 28);
            this.IndicatorXFilter0.Name = "IndicatorXFilter0";
            this.IndicatorXFilter0.Size = new System.Drawing.Size(16, 16);
            this.IndicatorXFilter0.TabIndex = 10;
            // 
            // XFilter0TB
            // 
            this.XFilter0TB.BackColor = System.Drawing.Color.Black;
            this.XFilter0TB.ForeColor = System.Drawing.Color.Lime;
            this.XFilter0TB.Location = new System.Drawing.Point(46, 25);
            this.XFilter0TB.Name = "XFilter0TB";
            this.XFilter0TB.ReadOnly = true;
            this.XFilter0TB.Size = new System.Drawing.Size(55, 26);
            this.XFilter0TB.TabIndex = 2;
            this.XFilter0TB.Text = "0.000";
            this.XFilter0TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // XFilter2TB
            // 
            this.XFilter2TB.BackColor = System.Drawing.Color.Black;
            this.XFilter2TB.ForeColor = System.Drawing.Color.Lime;
            this.XFilter2TB.Location = new System.Drawing.Point(46, 89);
            this.XFilter2TB.Name = "XFilter2TB";
            this.XFilter2TB.ReadOnly = true;
            this.XFilter2TB.Size = new System.Drawing.Size(55, 26);
            this.XFilter2TB.TabIndex = 6;
            this.XFilter2TB.Text = "0.000";
            this.XFilter2TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // XFilter0Label
            // 
            this.XFilter0Label.AutoSize = true;
            this.XFilter0Label.Location = new System.Drawing.Point(7, 28);
            this.XFilter0Label.Name = "XFilter0Label";
            this.XFilter0Label.Size = new System.Drawing.Size(33, 18);
            this.XFilter0Label.TabIndex = 1;
            this.XFilter0Label.Text = "x₀ =";
            // 
            // XFilter2Label
            // 
            this.XFilter2Label.AutoSize = true;
            this.XFilter2Label.Location = new System.Drawing.Point(7, 92);
            this.XFilter2Label.Name = "XFilter2Label";
            this.XFilter2Label.Size = new System.Drawing.Size(33, 18);
            this.XFilter2Label.TabIndex = 5;
            this.XFilter2Label.Text = "x₂ =";
            // 
            // XFilter1Label
            // 
            this.XFilter1Label.AutoSize = true;
            this.XFilter1Label.Location = new System.Drawing.Point(7, 60);
            this.XFilter1Label.Name = "XFilter1Label";
            this.XFilter1Label.Size = new System.Drawing.Size(33, 18);
            this.XFilter1Label.TabIndex = 3;
            this.XFilter1Label.Text = "x₁ =";
            // 
            // XFilter1TB
            // 
            this.XFilter1TB.BackColor = System.Drawing.Color.Black;
            this.XFilter1TB.ForeColor = System.Drawing.Color.Lime;
            this.XFilter1TB.Location = new System.Drawing.Point(46, 57);
            this.XFilter1TB.Name = "XFilter1TB";
            this.XFilter1TB.ReadOnly = true;
            this.XFilter1TB.Size = new System.Drawing.Size(55, 26);
            this.XFilter1TB.TabIndex = 4;
            this.XFilter1TB.Text = "0.000";
            this.XFilter1TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SettersParametrsGB
            // 
            this.SettersParametrsGB.Controls.Add(this.Weight5NUD);
            this.SettersParametrsGB.Controls.Add(this.Weight5Label);
            this.SettersParametrsGB.Controls.Add(this.Weight4NUD);
            this.SettersParametrsGB.Controls.Add(this.Weight4Label);
            this.SettersParametrsGB.Controls.Add(this.Weight3NUD);
            this.SettersParametrsGB.Controls.Add(this.Weight3Label);
            this.SettersParametrsGB.Controls.Add(this.Weight2NUD);
            this.SettersParametrsGB.Controls.Add(this.Weight2Label);
            this.SettersParametrsGB.Controls.Add(this.Weight1NUD);
            this.SettersParametrsGB.Controls.Add(this.Weight1Label);
            this.SettersParametrsGB.Controls.Add(this.Weight0NUD);
            this.SettersParametrsGB.Controls.Add(this.Weight0Label);
            this.SettersParametrsGB.Location = new System.Drawing.Point(12, 180);
            this.SettersParametrsGB.Name = "SettersParametrsGB";
            this.SettersParametrsGB.Size = new System.Drawing.Size(390, 100);
            this.SettersParametrsGB.TabIndex = 9;
            this.SettersParametrsGB.TabStop = false;
            this.SettersParametrsGB.Text = "Настраиваемые параметры";
            // 
            // Weight3NUD
            // 
            this.Weight3NUD.BackColor = System.Drawing.Color.Black;
            this.Weight3NUD.DecimalPlaces = 1;
            this.Weight3NUD.ForeColor = System.Drawing.Color.Lime;
            this.Weight3NUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Weight3NUD.Location = new System.Drawing.Point(46, 57);
            this.Weight3NUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Weight3NUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.Weight3NUD.Name = "Weight3NUD";
            this.Weight3NUD.ReadOnly = true;
            this.Weight3NUD.Size = new System.Drawing.Size(52, 26);
            this.Weight3NUD.TabIndex = 17;
            this.Weight3NUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Weight3NUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.Weight3NUD.ValueChanged += new System.EventHandler(this.Weight3NUD_ValueChanged);
            // 
            // Weight3Label
            // 
            this.Weight3Label.AutoSize = true;
            this.Weight3Label.Location = new System.Drawing.Point(6, 59);
            this.Weight3Label.Name = "Weight3Label";
            this.Weight3Label.Size = new System.Drawing.Size(37, 18);
            this.Weight3Label.TabIndex = 16;
            this.Weight3Label.Text = "w₃ =";
            // 
            // Weight2NUD
            // 
            this.Weight2NUD.BackColor = System.Drawing.Color.Black;
            this.Weight2NUD.DecimalPlaces = 1;
            this.Weight2NUD.ForeColor = System.Drawing.Color.Lime;
            this.Weight2NUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Weight2NUD.Location = new System.Drawing.Point(240, 25);
            this.Weight2NUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Weight2NUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.Weight2NUD.Name = "Weight2NUD";
            this.Weight2NUD.ReadOnly = true;
            this.Weight2NUD.Size = new System.Drawing.Size(52, 26);
            this.Weight2NUD.TabIndex = 15;
            this.Weight2NUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Weight2NUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.Weight2NUD.ValueChanged += new System.EventHandler(this.Weight2NUD_ValueChanged);
            // 
            // Weight2Label
            // 
            this.Weight2Label.AutoSize = true;
            this.Weight2Label.Location = new System.Drawing.Point(200, 27);
            this.Weight2Label.Name = "Weight2Label";
            this.Weight2Label.Size = new System.Drawing.Size(37, 18);
            this.Weight2Label.TabIndex = 14;
            this.Weight2Label.Text = "w₂ =";
            // 
            // Weight1NUD
            // 
            this.Weight1NUD.BackColor = System.Drawing.Color.Black;
            this.Weight1NUD.DecimalPlaces = 1;
            this.Weight1NUD.ForeColor = System.Drawing.Color.Lime;
            this.Weight1NUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Weight1NUD.Location = new System.Drawing.Point(144, 25);
            this.Weight1NUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Weight1NUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.Weight1NUD.Name = "Weight1NUD";
            this.Weight1NUD.ReadOnly = true;
            this.Weight1NUD.Size = new System.Drawing.Size(52, 26);
            this.Weight1NUD.TabIndex = 13;
            this.Weight1NUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Weight1NUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.Weight1NUD.ValueChanged += new System.EventHandler(this.Weight1NUD_ValueChanged);
            // 
            // Weight1Label
            // 
            this.Weight1Label.AutoSize = true;
            this.Weight1Label.Location = new System.Drawing.Point(104, 27);
            this.Weight1Label.Name = "Weight1Label";
            this.Weight1Label.Size = new System.Drawing.Size(37, 18);
            this.Weight1Label.TabIndex = 12;
            this.Weight1Label.Text = "w₁ =";
            // 
            // Weight0NUD
            // 
            this.Weight0NUD.BackColor = System.Drawing.Color.Black;
            this.Weight0NUD.DecimalPlaces = 1;
            this.Weight0NUD.ForeColor = System.Drawing.Color.Lime;
            this.Weight0NUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Weight0NUD.Location = new System.Drawing.Point(46, 25);
            this.Weight0NUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Weight0NUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.Weight0NUD.Name = "Weight0NUD";
            this.Weight0NUD.ReadOnly = true;
            this.Weight0NUD.Size = new System.Drawing.Size(52, 26);
            this.Weight0NUD.TabIndex = 11;
            this.Weight0NUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Weight0NUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.Weight0NUD.ValueChanged += new System.EventHandler(this.Weight0NUD_ValueChanged);
            // 
            // Weight0Label
            // 
            this.Weight0Label.AutoSize = true;
            this.Weight0Label.Location = new System.Drawing.Point(6, 27);
            this.Weight0Label.Name = "Weight0Label";
            this.Weight0Label.Size = new System.Drawing.Size(37, 18);
            this.Weight0Label.TabIndex = 10;
            this.Weight0Label.Text = "w₀ =";
            // 
            // Weight4NUD
            // 
            this.Weight4NUD.BackColor = System.Drawing.Color.Black;
            this.Weight4NUD.DecimalPlaces = 1;
            this.Weight4NUD.ForeColor = System.Drawing.Color.Lime;
            this.Weight4NUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Weight4NUD.Location = new System.Drawing.Point(144, 59);
            this.Weight4NUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Weight4NUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.Weight4NUD.Name = "Weight4NUD";
            this.Weight4NUD.ReadOnly = true;
            this.Weight4NUD.Size = new System.Drawing.Size(52, 26);
            this.Weight4NUD.TabIndex = 19;
            this.Weight4NUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Weight4NUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.Weight4NUD.ValueChanged += new System.EventHandler(this.Weight4NUD_ValueChanged);
            // 
            // Weight4Label
            // 
            this.Weight4Label.AutoSize = true;
            this.Weight4Label.Location = new System.Drawing.Point(104, 61);
            this.Weight4Label.Name = "Weight4Label";
            this.Weight4Label.Size = new System.Drawing.Size(37, 18);
            this.Weight4Label.TabIndex = 18;
            this.Weight4Label.Text = "w₄ =";
            // 
            // Weight5NUD
            // 
            this.Weight5NUD.BackColor = System.Drawing.Color.Black;
            this.Weight5NUD.DecimalPlaces = 1;
            this.Weight5NUD.ForeColor = System.Drawing.Color.Lime;
            this.Weight5NUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Weight5NUD.Location = new System.Drawing.Point(240, 59);
            this.Weight5NUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Weight5NUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.Weight5NUD.Name = "Weight5NUD";
            this.Weight5NUD.ReadOnly = true;
            this.Weight5NUD.Size = new System.Drawing.Size(52, 26);
            this.Weight5NUD.TabIndex = 21;
            this.Weight5NUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Weight5NUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.Weight5NUD.ValueChanged += new System.EventHandler(this.Weight5NUD_ValueChanged);
            // 
            // Weight5Label
            // 
            this.Weight5Label.AutoSize = true;
            this.Weight5Label.Location = new System.Drawing.Point(200, 61);
            this.Weight5Label.Name = "Weight5Label";
            this.Weight5Label.Size = new System.Drawing.Size(37, 18);
            this.Weight5Label.TabIndex = 20;
            this.Weight5Label.Text = "w₅ =";
            // 
            // YBaseTB
            // 
            this.YBaseTB.BackColor = System.Drawing.Color.Black;
            this.YBaseTB.ForeColor = System.Drawing.Color.Lime;
            this.YBaseTB.Location = new System.Drawing.Point(46, 121);
            this.YBaseTB.Name = "YBaseTB";
            this.YBaseTB.ReadOnly = true;
            this.YBaseTB.Size = new System.Drawing.Size(55, 26);
            this.YBaseTB.TabIndex = 10;
            this.YBaseTB.Text = "-55.01";
            this.YBaseTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // YFilterTB
            // 
            this.YFilterTB.BackColor = System.Drawing.Color.Black;
            this.YFilterTB.ForeColor = System.Drawing.Color.Lime;
            this.YFilterTB.Location = new System.Drawing.Point(46, 121);
            this.YFilterTB.Name = "YFilterTB";
            this.YFilterTB.ReadOnly = true;
            this.YFilterTB.Size = new System.Drawing.Size(55, 26);
            this.YFilterTB.TabIndex = 23;
            this.YFilterTB.Text = "55.00";
            this.YFilterTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // YBaseLabel
            // 
            this.YBaseLabel.AutoSize = true;
            this.YBaseLabel.Location = new System.Drawing.Point(7, 124);
            this.YBaseLabel.Name = "YBaseLabel";
            this.YBaseLabel.Size = new System.Drawing.Size(28, 18);
            this.YBaseLabel.TabIndex = 11;
            this.YBaseLabel.Text = "y =";
            // 
            // YFilterLabel
            // 
            this.YFilterLabel.AutoSize = true;
            this.YFilterLabel.Location = new System.Drawing.Point(7, 124);
            this.YFilterLabel.Name = "YFilterLabel";
            this.YFilterLabel.Size = new System.Drawing.Size(28, 18);
            this.YFilterLabel.TabIndex = 24;
            this.YFilterLabel.Text = "y =";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(12, 377);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(390, 53);
            this.StartBtn.TabIndex = 10;
            this.StartBtn.Text = "Старт";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(12, 495);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(390, 53);
            this.ExitBtn.TabIndex = 12;
            this.ExitBtn.Text = "Сброс/Выход";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(12, 436);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(390, 53);
            this.StopBtn.TabIndex = 13;
            this.StopBtn.Text = "Стоп";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(10, 304);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(390, 67);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "Тип\r\nКод\r\nТекст";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Информационное окно";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.SettersParametrsGB);
            this.Controls.Add(this.FilterXGB);
            this.Controls.Add(this.BaseXGB);
            this.Controls.Add(this.Chart);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Виртуальный прибор для расчета значения функции";
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.BaseXGB.ResumeLayout(false);
            this.BaseXGB.PerformLayout();
            this.FilterXGB.ResumeLayout(false);
            this.FilterXGB.PerformLayout();
            this.SettersParametrsGB.ResumeLayout(false);
            this.SettersParametrsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Weight3NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight2NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight1NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight0NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight4NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight5NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Label XBase0Label;
        private System.Windows.Forms.TextBox XBase0TB;
        private System.Windows.Forms.TextBox XBase1TB;
        private System.Windows.Forms.Label XBase1Label;
        private System.Windows.Forms.TextBox XBase2TB;
        private System.Windows.Forms.Label XBase2Label;
        private System.Windows.Forms.GroupBox BaseXGB;
        private System.Windows.Forms.GroupBox FilterXGB;
        private System.Windows.Forms.TextBox XFilter0TB;
        private System.Windows.Forms.TextBox XFilter2TB;
        private System.Windows.Forms.Label XFilter0Label;
        private System.Windows.Forms.Label XFilter2Label;
        private System.Windows.Forms.Label XFilter1Label;
        private System.Windows.Forms.TextBox XFilter1TB;
        private System.Windows.Forms.Panel IndicatorXBase2;
        private System.Windows.Forms.Panel IndicatorXBase1;
        private System.Windows.Forms.Panel IndicatorXBase0;
        private System.Windows.Forms.Panel IndicatorXFilter2;
        private System.Windows.Forms.Panel IndicatorXFilter1;
        private System.Windows.Forms.Panel IndicatorXFilter0;
        private System.Windows.Forms.GroupBox SettersParametrsGB;
        private System.Windows.Forms.NumericUpDown Weight0NUD;
        private System.Windows.Forms.Label Weight0Label;
        private System.Windows.Forms.NumericUpDown Weight3NUD;
        private System.Windows.Forms.Label Weight3Label;
        private System.Windows.Forms.NumericUpDown Weight2NUD;
        private System.Windows.Forms.Label Weight2Label;
        private System.Windows.Forms.NumericUpDown Weight1NUD;
        private System.Windows.Forms.Label Weight1Label;
        private System.Windows.Forms.NumericUpDown Weight5NUD;
        private System.Windows.Forms.Label Weight5Label;
        private System.Windows.Forms.NumericUpDown Weight4NUD;
        private System.Windows.Forms.Label Weight4Label;
        private System.Windows.Forms.TextBox YBaseTB;
        private System.Windows.Forms.TextBox YFilterTB;
        private System.Windows.Forms.Label YBaseLabel;
        private System.Windows.Forms.Label YFilterLabel;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

