namespace VirtualInstrumentation.Model
{
    public class Filter
    {
        private double _filterCoefficient;
        private double _filterValue;

        public Filter(double coefficient, double start)
        {
            _filterValue = start;
            _filterCoefficient = coefficient > 0 && coefficient <= 1 ? coefficient : 0.1;
        }

        public double ExpRunningAverage(double next)
        {
            _filterValue += (next - _filterValue) * _filterCoefficient;
            return _filterValue;
        }
    }
}
