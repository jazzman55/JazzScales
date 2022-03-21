using Scales.Model;

namespace Scales.Theory
{
    public static class Chords
    {
        public static Chord Maj7 = new Chord("Maj7");
        public static Chord Maj9 = new Chord("Maj9");
        public static Chord Major6 = new Chord("6");
        public static Chord Major = new Chord("");
        public static Chord Maj7P11 = new Chord("Maj7(+11)");
        public static Chord Min7 = new Chord("m7");
        public static Chord Min9 = new Chord("m9");
        public static Chord Min11 = new Chord("m11");
        public static Chord Minor = new Chord("m");
        public static Chord Min6 = new Chord("m6");
        public static Chord MinP7 = new Chord("m(+7)");
        public static Chord Min7M6 = new Chord("m7(-6)");
        public static Chord Min7M9 = new Chord("m7(-9)");
        public static Chord D7 = new Chord("7");
        public static Chord D9 = new Chord("9");
        public static Chord D13 = new Chord("13");
        public static Chord D7sus = new Chord("7sus");
        public static Chord Dsus = new Chord("sus");
        public static Chord D11 = new Chord("11");
        // public static Chord B_D = new Chord("(-2)/");
        // public static Chord Gm7_D = new Chord("(-4m7)/");
        public static Chord D7P11 = new Chord("7(+11)");
        public static Chord D7alt = new Chord("7alt");
        public static Chord D7P9P5 = new Chord("7(+9+5)");
        public static Chord D7P9 = new Chord("7(+9)");
        public static Chord D7M9M5 = new Chord("7(-9-5)");
        public static Chord D7M9 = new Chord("7(-9)");
        public static Chord D7P = new Chord("7+");
        public static Chord Min7M5 = new Chord("m7(-5)");
        public static Chord Dim7 = new Chord("dim7");
        public static Chord Phryg = new Chord("phryg");
        public static Chord Maj7P5 = new Chord("Maj7(+5)");
        public static Chord D7susM9 = new Chord("7sus(-9)");

        public static Chord[] All = new[]
        {
            Maj7,
            Maj9,
            Major6,
            Major,
            Maj7P11,
            Min7,
            Min9,
            Min11,
            Minor,
            Min6,
            MinP7,
            Min7M6,
            Min7M9,
            D7,
            D9,
            D13,
            D7sus,
            Dsus,
            D11,
            // B_D,
            // Gm7_D,
            D7P11,
            D7alt,
            D7P9P5,
            D7P9,
            D7M9M5,
            D7M9,
            D7P,
            Min7M5,
            Dim7,
            Phryg,
            Maj7P5,
            D7susM9,
        };
    }
}
