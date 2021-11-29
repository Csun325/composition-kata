using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Inheritance
{
    /// <summary>
    /// Should filter out measurements with an X or Y that are less than or equal to 2
    /// You'll need to inherit and override methods from other classes in the inheritance folder
    /// </summary>
    public class HighPassSummingAggregator : SummingAggregator 
    {
        public HighPassSummingAggregator(Measurement[] measurements) : base(measurements)
        {
        }

        protected override IEnumerable<Measurement> FilterMeasurements(IEnumerable<Measurement> measurements)
        {
            return base.Measurements.Where(m => m.X > 2 && m.Y > 2);
        }
    }    
}