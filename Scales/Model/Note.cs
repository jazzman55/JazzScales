using Scales.Theory;

namespace Scales.Model
{
    public class Note
    {
        public int Halftones { get; } //distance from C

        public NoteName Root { get; }
        public Alteration Alteration { get; }

        public Note(NoteName root, Alteration alteration = Alteration.None)
        {
            if (Math.Abs((int)alteration) > 4)
                throw new ArgumentException("Alteration value must be in -4..4 range.", nameof(alteration));

            Root = root;
            Alteration = alteration;
            Halftones = Diatonic.GetHalftonesFromC(root, alteration);

        }

        public Note Transpose(Interval interval, Direction direction = Direction.Up)
        {
            if (Equals(interval, Intervals.P1))
                return this;

            var newNote = direction == Direction.Up
                ? Diatonic.Add(Root, interval.Steps - 1)
                : Diatonic.Add(Root, -interval.Steps + 1);
            var alteration = direction == Direction.Up
                ? (int)(interval.Halftones - Diatonic.GetHalftonesBetween(Root, newNote) + Alteration)
                : (int)(-interval.Halftones + Diatonic.GetHalftonesBetween(newNote, Root) + Alteration);

            if (Math.Abs(alteration) > 9)
                alteration -= Math.Sign(alteration) * 12;

            return new Note(newNote, (Alteration)alteration);

        }

        public Interval GetInterval(Note otherNote)
        {
            if (Equals(otherNote, this))
                return Intervals.P1;

            var steps = Diatonic.Subtract(otherNote.Root, Root);
            var halftones = otherNote.Halftones - Halftones;
            if (halftones < 0)
                halftones += 12;
            if (halftones > 2 && steps == 0)
                steps = 7;
            return new Interval(String.Empty, steps + 1, halftones);
        }

        public Note GetEnharmonicEquivalent()
        {
            if (Alteration == Alteration.None)
                return this;

            return Transpose(new Interval(2, 0), Alteration > 0 ? Direction.Up : Direction.Down);
        }

        public override string ToString()
        {
            return Formatter.FormatNote(this);
        }

        protected bool Equals(Note other)
        {
            return Halftones == other.Halftones && Root == other.Root && Alteration == other.Alteration;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Note)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Halftones, (int)Root, (int)Alteration);
        }
    }
}
