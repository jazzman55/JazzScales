using Scales.Theory;

namespace Scales.Model
{
    public class ChordScale
    {
        public Chord Chord { get; }
        public ScaleType ScaleType { get; }
        public Interval Transposition { get; }

        public ChordScale(Chord chord, ScaleType scaleType, Interval transposition)
        {
            Chord = chord;
            ScaleType = scaleType;
            Transposition = transposition;
        }

        public ChordScale(Chord chord, ScaleType scaleType) : this(chord, scaleType, Intervals.P1)
        {
        }

    }
}
