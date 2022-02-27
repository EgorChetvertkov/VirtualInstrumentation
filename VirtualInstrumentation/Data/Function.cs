using System;

namespace VirtualInstrumentation.Data
{
    internal class Function
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public Weights Weights { get; set; }
        public NonSmoothedValues NonSmoothedValues { get; set; }
        public SmoothedValues SmoothedValues { get; set; }
    }
}
