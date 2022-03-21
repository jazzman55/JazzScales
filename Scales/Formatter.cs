using Scales.Model;

namespace Scales
{
    public class Formatter
    {
        private const string NoteSymbols = "CDEFGAB";

        public static string FormatNote(Note note)
        {
            return $"{NoteSymbols[(int)note.Root]}{GetAlterationString(note.Alteration)}";
        }

        public static Note ParseNote(string noteSymbol)
        {
            noteSymbol = noteSymbol.Trim();
            return new Note((NoteName)NoteSymbols.IndexOf(noteSymbol[0]), GetAlteration(noteSymbol.Substring(1)));
        }

        public static string GetNoteString(NoteName note)
        {
            return NoteSymbols[(int)note].ToString();
        }

        public static string GetAlterationString(Alteration noteAlteration)
        {
            switch (noteAlteration)
            {
                case Alteration.None: return String.Empty; ;
                case Alteration.Sharp: return "#";
                case Alteration.DoubleSharp: return "x";
                case Alteration.TripleSharp: return "#x";
                case Alteration.Flat: return "b";
                case Alteration.DoubleFlat: return "bb";
                case Alteration.TripleFlat: return "bbb";
                case Alteration.QuadrupleSharp: return "xx";
                case Alteration.QuadrupleFlat: return "bbbb";
            }

            throw new NotSupportedException();
        }

        private static Alteration GetAlteration(string alterationSymbol)
        {
            switch (alterationSymbol)
            {
                case "": return Alteration.None;
                case "#": return Alteration.Sharp;
                case "x": return Alteration.DoubleSharp;
                case "#x": return Alteration.TripleSharp;
                case "b": return Alteration.Flat;
                case "bb": return Alteration.DoubleFlat;
                case "bbb": return Alteration.TripleFlat;
            }

            throw new ArgumentException("unknown symbol", nameof(alterationSymbol));
        }
    }
}
