namespace Scales.Model
{
    public class ScaleType
    {
        public ScaleType(string name, IEnumerable<Interval> steps)
        {
            Name = name;
            Steps = steps;
        }

        public string Name { get; }
        public IEnumerable<Interval> Steps{ get; }
    }
}
