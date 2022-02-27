using System;
using System.Windows.Forms;

using VirtualInstrumentation.Interfaces;
using VirtualInstrumentation.Model;

namespace VirtualInstrumentation
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IForm mainForm = new MainForm();
            IModel instrument = new Instrument();

            mainForm.Start += instrument.Start;
            mainForm.Stop += instrument.Stop;
            mainForm.Exit += instrument.Stop;
            mainForm.WXChange += instrument.UpdateW;
            mainForm.Write += instrument.StartWriteDB;
            mainForm.NWrite += instrument.StopWriteDB;

            instrument.BaseXs += mainForm.UpdateBaseXs;
            instrument.FilterXs += mainForm.UpdateFilterXs;
            instrument.BaseY += mainForm.UpdateBaseY;
            instrument.FilterY += mainForm.UpdateFilterY;
            instrument.NextPoint += mainForm.UpdateChart;
            instrument.Message += mainForm.PrintMessage;

            Application.Run((Form)mainForm);
        }
    }
}
