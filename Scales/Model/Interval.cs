
namespace Scales.Model
{
    public class Interval
    {
        public Interval(string name, int steps, int halftones)
        {
            Name = name;
            Steps = steps;
            Halftones = halftones;
        }

        public Interval(int steps, int halftones) : this(String.Empty, steps, halftones)
        {
        }

        public string Name { get; }
        public int Steps { get; }
        public int Halftones { get; }

        protected bool Equals(Interval other)
        {
            return Steps == other.Steps && Halftones == other.Halftones;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Interval)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Steps, Halftones);
        }
    }
    public enum Direction{ Up, Down }

}
