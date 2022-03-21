using Scales.Model;

namespace Scales.Theory
{
    ///https://www.apassion4jazz.net/jazz-chords-scales.html
    public class ChordScales
    {
        public static ChordScale[] Scales = new[]
        {
            //CMaj7
            new ChordScale(Chords.Maj7, ScaleTypes.Major), 
            new ChordScale(Chords.Maj7, ScaleTypes.Lydian),
            new ChordScale(Chords.Maj7, ScaleTypes.BebopMajor), 
            new ChordScale(Chords.Maj7, ScaleTypes.Major6Diminished),
            new ChordScale(Chords.Maj7, ScaleTypes.PentatonicMajor),
            new ChordScale(Chords.Maj7, ScaleTypes.PentatonicMajor, Intervals.P5),
            //CMaj9
            new ChordScale(Chords.Maj9, ScaleTypes.Major),
            new ChordScale(Chords.Maj9, ScaleTypes.Lydian),
            new ChordScale(Chords.Maj9, ScaleTypes.BebopMajor),
            new ChordScale(Chords.Maj9, ScaleTypes.Major6Diminished),
            new ChordScale(Chords.Maj9, ScaleTypes.PentatonicMajor),
            new ChordScale(Chords.Maj9, ScaleTypes.PentatonicMajor, Intervals.P5),
            //C6
            new ChordScale(Chords.Major6, ScaleTypes.Major),
            new ChordScale(Chords.Major6, ScaleTypes.Lydian),
            new ChordScale(Chords.Major6, ScaleTypes.BebopMajor),
            new ChordScale(Chords.Major6, ScaleTypes.Major6Diminished),
            new ChordScale(Chords.Major6, ScaleTypes.PentatonicMajor),
            new ChordScale(Chords.Major6, ScaleTypes.PentatonicMajor, Intervals.P5),
            //C
            new ChordScale(Chords.Major, ScaleTypes.Major),
            new ChordScale(Chords.Major, ScaleTypes.Lydian),
            new ChordScale(Chords.Major, ScaleTypes.BebopMajor),
            new ChordScale(Chords.Major, ScaleTypes.Major6Diminished),
            new ChordScale(Chords.Major, ScaleTypes.PentatonicMajor),
            new ChordScale(Chords.Major, ScaleTypes.PentatonicMajor, Intervals.P5),
            //CMaj7(+11)
            new ChordScale(Chords.Maj7P11, ScaleTypes.Lydian),
            new ChordScale(Chords.Maj7P11, ScaleTypes.InSen, Intervals.Maj7),
            new ChordScale(Chords.Maj7P11, ScaleTypes.PentatonicMajor, Intervals.Maj2),
            new ChordScale(Chords.Maj7P11, ScaleTypes.PentatonicMinor, Intervals.Maj7),
            //Cm7
            new ChordScale(Chords.Min7, ScaleTypes.Dorian),
            new ChordScale(Chords.Min7, ScaleTypes.BebopMinor),
            new ChordScale(Chords.Min7, ScaleTypes.PentatonicMinor),
            new ChordScale(Chords.Min7, ScaleTypes.Minor6Diminished),
            new ChordScale(Chords.Min7, ScaleTypes.PentatonicMajor, Intervals.P4),
            new ChordScale(Chords.Min7, ScaleTypes.PentatonicMajor, Intervals.Min7),
            new ChordScale(Chords.Min7, ScaleTypes.BebopMinor, Intervals.Min3),
            new ChordScale(Chords.Min7, ScaleTypes.Blues),
            new ChordScale(Chords.Min7, ScaleTypes.MinorNatural),
            //Cm9
            new ChordScale(Chords.Min9, ScaleTypes.Dorian),
            new ChordScale(Chords.Min9, ScaleTypes.BebopMinor),
            new ChordScale(Chords.Min9, ScaleTypes.PentatonicMinor),
            new ChordScale(Chords.Min9, ScaleTypes.Minor6Diminished),
            new ChordScale(Chords.Min9, ScaleTypes.PentatonicMajor, Intervals.P4),
            new ChordScale(Chords.Min9, ScaleTypes.PentatonicMajor, Intervals.Min7),
            new ChordScale(Chords.Min9, ScaleTypes.BebopMinor, Intervals.Min3),
            new ChordScale(Chords.Min9, ScaleTypes.Blues),
            new ChordScale(Chords.Min9, ScaleTypes.MinorNatural),
            //Cm11
            new ChordScale(Chords.Min11, ScaleTypes.Dorian),
            new ChordScale(Chords.Min11, ScaleTypes.BebopMinor),
            new ChordScale(Chords.Min11, ScaleTypes.PentatonicMinor),
            new ChordScale(Chords.Min11, ScaleTypes.Minor6Diminished),
            new ChordScale(Chords.Min11, ScaleTypes.PentatonicMajor, Intervals.P4),
            new ChordScale(Chords.Min11, ScaleTypes.PentatonicMajor, Intervals.Min7),
            new ChordScale(Chords.Min11, ScaleTypes.BebopMinor, Intervals.Min3),
            new ChordScale(Chords.Min11, ScaleTypes.Blues),
            new ChordScale(Chords.Min11, ScaleTypes.MinorNatural),
            //Cm
            new ChordScale(Chords.Minor, ScaleTypes.Dorian),
            new ChordScale(Chords.Minor, ScaleTypes.BebopMinor),
            new ChordScale(Chords.Minor, ScaleTypes.PentatonicMinor),
            new ChordScale(Chords.Minor, ScaleTypes.Minor6Diminished),
            new ChordScale(Chords.Minor, ScaleTypes.PentatonicMajor, Intervals.P4),
            new ChordScale(Chords.Minor, ScaleTypes.PentatonicMajor, Intervals.Min7),
            new ChordScale(Chords.Minor, ScaleTypes.BebopMinor, Intervals.Min3),
            new ChordScale(Chords.Minor, ScaleTypes.Blues),
            new ChordScale(Chords.Minor, ScaleTypes.MinorNatural),
            //Cm6
            new ChordScale(Chords.Min6, ScaleTypes.Dorian),
            new ChordScale(Chords.Min6, ScaleTypes.MinorMelodicAsc),
            new ChordScale(Chords.Min6, ScaleTypes.PentatonicMinor),
            new ChordScale(Chords.Min6, ScaleTypes.PentatonicMinor, Intervals.Maj2),
            new ChordScale(Chords.Min6, ScaleTypes.PentatonicMajor, Intervals.P4),
            new ChordScale(Chords.Min6, ScaleTypes.PentatonicMinor, Intervals.P5),
            new ChordScale(Chords.Min7, ScaleTypes.PentatonicMajor, Intervals.Min7),
            new ChordScale(Chords.Min7, ScaleTypes.BebopMinor),
            new ChordScale(Chords.Min7, ScaleTypes.BebopMajor, Intervals.Min3),
            new ChordScale(Chords.Min7, ScaleTypes.InSen, Intervals.Maj2),
            //Cm(+7)
            new ChordScale(Chords.MinP7, ScaleTypes.MinorMelodicAsc),
            new ChordScale(Chords.MinP7, ScaleTypes.MinorHarmonic),
            new ChordScale(Chords.MinP7, ScaleTypes.BebopMajor, Intervals.Min3),
            //Cm7(-6)
            new ChordScale(Chords.Min7M6, ScaleTypes.MinorNatural),
            new ChordScale(Chords.Min7M6, ScaleTypes.PentatonicMajor, Intervals.Min6),
            //Cm7(-9)
            new ChordScale(Chords.Min7M9, ScaleTypes.Phrygian),
            new ChordScale(Chords.Min7M9, ScaleTypes.PhrygianAug6),
            //C7
            new ChordScale(Chords.D7, ScaleTypes.Mixolydian),
            new ChordScale(Chords.D7, ScaleTypes.LydianDominant),
            new ChordScale(Chords.D7, ScaleTypes.BebopDominant),
            new ChordScale(Chords.D7, ScaleTypes.Blues),
            new ChordScale(Chords.D7, ScaleTypes.PentatonicMajor),
            //C9
            new ChordScale(Chords.D9, ScaleTypes.Mixolydian),
            new ChordScale(Chords.D9, ScaleTypes.LydianDominant),
            new ChordScale(Chords.D9, ScaleTypes.BebopDominant),
            new ChordScale(Chords.D9, ScaleTypes.Blues),
            new ChordScale(Chords.D9, ScaleTypes.PentatonicMajor),
            //C13
            new ChordScale(Chords.D13, ScaleTypes.Mixolydian),
            new ChordScale(Chords.D13, ScaleTypes.LydianDominant),
            new ChordScale(Chords.D13, ScaleTypes.BebopDominant),
            new ChordScale(Chords.D13, ScaleTypes.Blues),
            new ChordScale(Chords.D13, ScaleTypes.PentatonicMajor),
            //C7sus
            new ChordScale(Chords.D7sus, ScaleTypes.Mixolydian),
            //Csus
            new ChordScale(Chords.Dsus, ScaleTypes.Mixolydian),
            //C11
            new ChordScale(Chords.D11, ScaleTypes.Mixolydian),
            //Bb/C
            // new ChordScale(Chords.B_D, ScaleTypes.PentatonicSuspended),
            // new ChordScale(Chords.B_D, ScaleTypes.PentatonicMajor, Intervals.P4),
            //Gm7/C
            // new ChordScale(Chords.Gm7_D, ScaleTypes.PentatonicSuspended),
            // new ChordScale(Chords.Gm7_D, ScaleTypes.PentatonicMajor, Intervals.P4),
            //C7(+11)
            new ChordScale(Chords.D7P11, ScaleTypes.LydianDominant),
            //C7alt
            new ChordScale(Chords.D7alt, ScaleTypes.Altered),
            new ChordScale(Chords.D7alt, ScaleTypes.MinorHarmonic, Intervals.P4),
            new ChordScale(Chords.D7alt, ScaleTypes.MinorMelodicAsc, Intervals.P4),
            //C7(+9+5)
            new ChordScale(Chords.D7P9P5, ScaleTypes.Altered),
            new ChordScale(Chords.D7P9P5, ScaleTypes.MinorHarmonic, Intervals.P4),
            new ChordScale(Chords.D7P9P5, ScaleTypes.MinorMelodicAsc, Intervals.P4),
            //C7(+9)
            new ChordScale(Chords.D7P9, ScaleTypes.Altered),
            new ChordScale(Chords.D7P9, ScaleTypes.MinorHarmonic, Intervals.P4),
            new ChordScale(Chords.D7P9, ScaleTypes.MinorMelodicAsc, Intervals.P4),
            //C7(-9-5)
            new ChordScale(Chords.D7M9M5, ScaleTypes.HWDiminished),
            new ChordScale(Chords.D7M9M5, ScaleTypes.MinorHarmonic, Intervals.P4),
            new ChordScale(Chords.D7M9M5, ScaleTypes.MinorMelodicAsc, Intervals.P4),
            //C7(-9)
            new ChordScale(Chords.D7M9, ScaleTypes.HWDiminished),
            new ChordScale(Chords.D7M9, ScaleTypes.MinorHarmonic, Intervals.P4),
            new ChordScale(Chords.D7M9, ScaleTypes.MinorMelodicAsc, Intervals.P4),
            //C7+
            new ChordScale(Chords.D7P, ScaleTypes.WholeTone),
            //Cm7(-5)
            new ChordScale(Chords.Min7M5, ScaleTypes.LocrianAug2),
            new ChordScale(Chords.Min7M5, ScaleTypes.Locrian),
            //Cdim7
            new ChordScale(Chords.Dim7, ScaleTypes.HWDiminished),
            //Cphryg
            new ChordScale(Chords.Phryg, ScaleTypes.Phrygian),
            new ChordScale(Chords.Phryg, ScaleTypes.PhrygianAug6),
            new ChordScale(Chords.Phryg, ScaleTypes.PhrygianSpanish),
            new ChordScale(Chords.Phryg, ScaleTypes.InSen),
            //Maj7(+5)
            new ChordScale(Chords.Maj7P5, ScaleTypes.LydianAugmented),
            new ChordScale(Chords.Maj7P5, ScaleTypes.BebopMajor),
            //C7sus(-9)
            new ChordScale(Chords.D7susM9, ScaleTypes.PhrygianAug6),
            new ChordScale(Chords.D7susM9, ScaleTypes.Phrygian),
        };

        public static Scale[] GetScalesForChord(Note root, Chord chordType, bool enharmonic = false)
        {
            return Scales.Where(sc => sc.Chord == chordType)
                .Select(sc => new Scale(root.Transpose(sc.Transposition), sc.ScaleType, enharmonic))
                .ToArray();

        }
    }
}
