using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Reflection.Emit;

using VirtualInstrumentation.Model;

namespace VirtualInstrumentationTest
{
    [TestClass]
    public class GeneratorTest
    {
        [TestMethod]
        public void ErrorTest()
        {
            Generator generator = new Generator(0, 5, -5);
            double sumErrors = 0;
            int n = 1000;
            double exeptedError = 0.00001;

            for (int i = 0; i < n; i++)
            {
                double value = generator.Next();
                double trueValue = generator.CurrentValue;

                sumErrors += Math.Abs(trueValue - value);
            }

            double meanError = sumErrors / n;

            Assert.IsTrue(exeptedError >= meanError, $"—редн€€ погрешность измерени€ {meanError}.");
        }

        [TestMethod]
        public void FilterTest()
        {
            Generator generator = new Generator(0, 5, -5);
            Filter filter = new Filter(0.99999999, generator.CurrentValue);

            double sumErrors = 0;
            int n = 1000;
            double exeptedError = 0.00001;

            for (int i = 0; i < n; i++)
            {
                double generatorValue = generator.Next();
                double filterValue = filter.ExpRunningAverage(generatorValue);
                Console.WriteLine($"{generatorValue} - {generator.CurrentValue} - {filterValue}");
                sumErrors += Math.Abs(generator.CurrentValue - filterValue);
            }

            double meanError = sumErrors / n;

            Assert.IsTrue(exeptedError >= meanError, $"—редн€€ погрешность измерени€ {meanError}.");
        }

        [TestMethod]
        public void FunctionValueTest()
        {
            double exeptedError = 0.00001;

            Generator _x0Generator = new Generator(0, 5, -5);
            Generator _x1Generator = new Generator(0, 5, -5);
            Generator _x2Generator = new Generator(0, 5, -5);

            Function _function = new Function();
            _function.UpdateWs(1, 1, 1, 1, 1, 1);
            
            Filter _x0Filter = new Filter(0.99999999, _x0Generator.CurrentValue);
            Filter _x1Filter = new Filter(0.99999999, _x1Generator.CurrentValue);
            Filter _x2Filter = new Filter(0.99999999, _x2Generator.CurrentValue);
            Filter _yFilter = _yFilter = new Filter(0.99999999,
                _function.Calculate(_x0Generator.CurrentValue, _x1Generator.CurrentValue, _x2Generator.CurrentValue));

            double x0 = _x0Generator.Next();
            double x1 = _x1Generator.Next();
            double x2 = _x2Generator.Next();

            double y = _function.Calculate(x0, x1, x2);

            x0 = _x0Filter.ExpRunningAverage(x0);
            x1 = _x1Filter.ExpRunningAverage(x1);
            x2 = _x2Filter.ExpRunningAverage(x2);

            y = _function.Calculate(x0, x1, x2);
            double filtredY = _yFilter.ExpRunningAverage(y);

            Assert.AreEqual(y, filtredY, exeptedError);
        }
    }
}