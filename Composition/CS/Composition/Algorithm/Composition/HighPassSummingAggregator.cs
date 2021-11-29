using System.Collections.Generic;

namespace Algorithm.Composition
{
    public class HighPassSummingAggregator
    {
        private readonly IEnumerable<Measurement> _measurements;

        public HighPassSummingAggregator(IEnumerable<Measurement> measurements)
        {
            _measurements = measurements;
        }

        public virtual Measurement Aggregate()
        {
            var measurements = _measurements;
            measurements = new HighPassFilter().Filter(measurements);
            return new SummingStrategy().Aggregate(measurements);
        }
    }
}