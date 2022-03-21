using Scales.Model;

namespace Scales.Theory
{
    public static class Intervals
    {
        public static Interval P1 = new Interval("Perfect unison", 1, 0);
        public static Interval Min2 = new Interval("Minor second", 2, 1);
        public static Interval Maj2 = new Interval("Major second", 2, 2);
        public static Interval Min3 = new Interval("Minor third", 3, 3);
        public static Interval Maj3 = new Interval("Major third", 3, 4);
        public static Interval P4 = new Interval("Perfect fourth", 4, 5);
        public static Interval Aug4 = new Interval("Augmented fourth", 4, 6);
        public static Interval Dim5 = new Interval("Diminished fifth", 5, 6);
        public static Interval P5 = new Interval("Perfect fifth", 5, 7);
        public static Interval Min6 = new Interval("Minor sixth", 6, 8);
        public static Interval Maj6 = new Interval("Major sixth", 6, 9);
        public static Interval Min7 = new Interval("Minor seventh", 7, 10);
        public static Interval Maj7 = new Interval("Major seventh", 7, 11);
        public static Interval P8 = new Interval("Perfect octave", 8, 12);

        public static Interval Aug2 = new Interval("Augmented second", 2, 3);
        public static Interval Aug1 = new Interval("Augmented unison", 1, 1);
        public static Interval Dim3 = new Interval("Diminished third", 3, 2);

        public static Interval[] AllIntervals = new[]
        {
            P1,
            Min2,
            Maj2,
            Min3,
            Maj3,
            P4,
            Aug4,
            Dim5,
            P5,
            Min6,
            Maj6,
            Min7,
            Maj7,
            P8,

            Aug2,
            Aug1,
            Dim3
        };
    }
}
