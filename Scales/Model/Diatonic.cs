namespace Scales.Model
{
    public class Diatonic
    {
        private static readonly int[] IntervalsFromC = { 0, 2, 4, 5, 7, 9, 11 };
        private static readonly int[] Intervals = { 0, 2, 2, 1, 2, 2, 2, 1 };

        public static NoteName Add(NoteName root, int steps)
        {
            var newNote = ((int)root + steps) % 7;
            if (newNote < 0)
                newNote += 7;
            return (NoteName)newNote;
        }

        public static int Subtract(NoteName note1, NoteName note2)
        {
            var steps = (int)note1 - (int)note2;
            if (steps < 0)
                steps += 7;
            return steps;
        }

        public static int GetHalftonesFromC(NoteName root, Alteration alteration)
        {
            return IntervalsFromC[(int)root] + (int)alteration;
        }

        public static int GetHalftonesBetween(NoteName note1, NoteName note2)
        {
            int s = 0;
            int low = (int)note1;
            int hi = (int)note2;
            // if (hi <= low)
            if (hi < low)
                hi += 8;
            for (int i = low + 1; i <= hi; i++)
            {
                s += Intervals[i % 8];
            }

            return s;
        }

        public static IEnumerable<Alteration> GetAllowedAlterations(NoteName note)
        {
            var alt = Enum.GetValues<Alteration>().Where(a => Math.Abs((int)a) < 2).ToList();
            if (note == NoteName.C || note == NoteName.F)
                alt.Remove(Alteration.Flat);
            if (note == NoteName.B || note == NoteName.E)
                alt.Remove(Alteration.Sharp);
            return alt;
        }
    }
}
