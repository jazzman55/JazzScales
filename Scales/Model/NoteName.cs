namespace Scales.Model
{
    public enum NoteName : int
    {
        C = 0,
        D = 1,
        E = 2,
        F = 3,
        G = 4,
        A = 5,
        B = 6
    }

    public enum Alteration : int
    {
        None = 0,
        Sharp = 1,
        Flat = -1,
        DoubleSharp = 2,
        DoubleFlat = -2,
        TripleSharp = 3,
        TripleFlat = -3,
        QuadrupleSharp = 4,
        QuadrupleFlat = -4
    }
}
