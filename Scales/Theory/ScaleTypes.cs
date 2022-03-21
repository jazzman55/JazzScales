using Scales.Model;

namespace Scales.Theory
{
    /// https://www.apassion4jazz.net/scales.html
    /// https://www.apassion4jazz.net/modes.html

    public static class ScaleTypes
    {
        public static ScaleType Major = new ScaleType("Major", new[]
        {
            Intervals.Maj2, Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Maj2, Intervals.Maj2, Intervals.Min2,
        });

        public static ScaleType MinorNatural = new ScaleType("Natural Minor", new[]
        {
            Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Maj2,
        });

        public static ScaleType MinorHarmonic = new ScaleType("Harmonic Minor", new[]
        {
            Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Maj2, Intervals.Min2, Intervals.Aug2, Intervals.Min2,
        });

        public static ScaleType MinorMelodicAsc = new ScaleType("Melodic Minor (ascending)", new[]
        {
            Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Maj2, Intervals.Maj2, Intervals.Maj2, Intervals.Min2,
        });

        public static ScaleType MinorMelodicDesc = new ScaleType("Melodic Minor (descending)", new[]
        {
            Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Maj2,
        });


        //modes
        public static ScaleType Dorian = new ScaleType("Dorian", new[]
        {
            Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Maj2, Intervals.Maj2, Intervals.Min2, Intervals.Maj2,
        });

        public static ScaleType Phrygian = new ScaleType("Phrygian", new[]
        {
            Intervals.Min2, Intervals.Maj2, Intervals.Maj2, Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Maj2,
        });

        public static ScaleType PhrygianAug6 = new ScaleType("Phrygian #6", new[]
        {
            Intervals.Min2, Intervals.Maj2, Intervals.Maj2, Intervals.Maj2, Intervals.Maj2, Intervals.Min2, Intervals.Maj2,
        });

        ///https://pianoencyclopedia.com/scales/spanish-phrygian-i/C-spanish-phrygian-i.html
        public static ScaleType PhrygianSpanish = new ScaleType("Phrygian Spanish", new[]
        {
            Intervals.Min2, Intervals.Aug2, Intervals.Min2, Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Maj2,
        });

        public static ScaleType Lydian = new ScaleType("Lydian", new[]
        {
            Intervals.Maj2, Intervals.Maj2, Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Maj2, Intervals.Min2,
        });

        public static ScaleType Mixolydian = new ScaleType("Mixolydian", new[]
        {
            Intervals.Maj2, Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Maj2, Intervals.Min2, Intervals.Maj2,
        });

        public static ScaleType Locrian = new ScaleType("Locrian", new[]
        {
            Intervals.Min2, Intervals.Maj2, Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Maj2, Intervals.Maj2,
        });

        public static ScaleType LocrianAug2 = new ScaleType("Locrian #2", new[]
        {
            Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Maj2, Intervals.Maj2,
        });


        //other
        public static ScaleType Enigmatic = new ScaleType("Enigmatic", new[]
        {
            Intervals.Min2, Intervals.Aug2, Intervals.Maj2, Intervals.Maj2, Intervals.Maj2, Intervals.Min2, Intervals.Min2,
        });

        public static ScaleType Chromatic = new ScaleType("Chromatic", new[]
        {
            Intervals.Min2, Intervals.Aug1, Intervals.Min2, Intervals.Aug1, Intervals.Min2, Intervals.Min2, Intervals.Aug1, Intervals.Min2, Intervals.Aug1, Intervals.Min2, Intervals.Aug1, Intervals.Min2
        });

        public static ScaleType WHDiminished = new ScaleType("WH Diminished", new[]
        {
            Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Aug1, Intervals.Maj2, Intervals.Min2,
        });

        public static ScaleType HWDiminished = new ScaleType("HW Diminished", new[]
        {
            Intervals.Min2, Intervals.Maj2, Intervals.Aug1, Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Min2, Intervals.Maj2
        });

        public static ScaleType Major6Diminished = new ScaleType("Major 6 Diminished", new[]
        {
            Intervals.Maj2, Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Min2, Intervals.Aug1, Intervals.Maj2, Intervals.Min2,
        });

        public static ScaleType Minor6Diminished = new ScaleType("Minor 6 Diminished", new[]
        {
            Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Maj2, Intervals.Min2, Intervals.Aug1, Intervals.Maj2, Intervals.Min2,
        });

        public static ScaleType Augmented = new ScaleType("Augmented", new[]
        {
            Intervals.Min3, Intervals.Aug1, Intervals.Min3, Intervals.Min2, Intervals.Aug2, Intervals.Min2,
        });

        public static ScaleType WholeTone = new ScaleType("Whole Tone", new[]
        {
            Intervals.Maj2, Intervals.Maj2, Intervals.Dim3, Intervals.Maj2, Intervals.Maj2, Intervals.Maj2,
        });

        public static ScaleType LydianDominant = new ScaleType("Lydian Dominant", new[]
        {
            Intervals.Maj2, Intervals.Maj2, Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Min2, Intervals.Maj2,
        });

        public static ScaleType LydianAugmented = new ScaleType("Lydian Augmented", new[]
        {
            Intervals.Maj2, Intervals.Maj2, Intervals.Maj2, Intervals.Maj2, Intervals.Min2, Intervals.Min2, Intervals.Maj2,
        });

        public static ScaleType PentatonicMajor = new ScaleType("Pentatonic Major", new[]
        {
            Intervals.Maj2, Intervals.Maj2, Intervals.Min3, Intervals.Maj2, Intervals.Min3,
        });

        public static ScaleType PentatonicMinor = new ScaleType("Pentatonic Minor", new[]
        {
            Intervals.Min3, Intervals.Maj2, Intervals.Maj2, Intervals.Min3, Intervals.Maj2,
        });

        ///https://ianring.com/musictheory/scales/1189
        public static ScaleType PentatonicSuspended = new ScaleType("Pentatonic Suspended", new[]
        {
            Intervals.Maj2, Intervals.Min3, Intervals.Maj2, Intervals.Min3, Intervals.Maj2,
        });

        public static ScaleType Altered = new ScaleType("Altered", new[]
        {
            Intervals.Min2, Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Maj2, Intervals.Maj2, Intervals.Maj2,
        });

        public static ScaleType InSen = new ScaleType("In Sen", new[]
        {
            Intervals.Min2, Intervals.Maj3, Intervals.Maj2, Intervals.Min3, Intervals.Maj2,
        });

        public static ScaleType Semitone3 = new ScaleType("3 Semitone", new[]
        {
            Intervals.Min3, Intervals.Min3, Intervals.Aug2, Intervals.Min3
        });

        public static ScaleType Semitone4 = new ScaleType("4 Semitone", new[]
        {
            Intervals.Maj3, Intervals.Maj3, Intervals.Aug2
        });

        public static ScaleType Blues = new ScaleType("Blues", new[]
        {
            Intervals.Min3, Intervals.Maj2, Intervals.Min2, Intervals.Aug1, Intervals.Min3, Intervals.Maj2,
        });

        public static ScaleType BebopMajor = new ScaleType("Bebop Major", new[]
        {
            Intervals.Maj2, Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Aug1, Intervals.Min2
        });

        public static ScaleType BebopMinor = new ScaleType("Bebop Minor", new[]
        {
            Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Aug1, Intervals.Min2
        });

        ///https://hellomusictheory.com/learn/bebop-scales/
        public static ScaleType BebopDominant = new ScaleType("Bebop Dominant", new[]
        {
            Intervals.Maj2, Intervals.Maj2, Intervals.Min2, Intervals.Maj2, Intervals.Maj2, Intervals.Min2, Intervals.Aug1, Intervals.Min2
        });

        public static ScaleType[] All = new[]
        {
            Major,
            MinorNatural,
            MinorHarmonic,
            MinorMelodicAsc,
            MinorMelodicDesc,
            Dorian,
            Phrygian,
            PhrygianAug6,
            PhrygianSpanish,
            Lydian,
            Mixolydian,
            Locrian,
            LocrianAug2,
            Enigmatic,
            Chromatic,
            WHDiminished,
            HWDiminished,
            Major6Diminished,
            Minor6Diminished,
            Augmented,
            WholeTone,
            LydianDominant,
            LydianAugmented,
            PentatonicMajor,
            PentatonicMinor,
            PentatonicSuspended,
            Altered,
            InSen,
            Semitone3,
            Semitone4,
            Blues,
            BebopMajor,
            BebopMinor,
            BebopDominant,
        };
    }
}
