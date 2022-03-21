namespace Scales.Model
{
    public class Scale
    {
        public string Name { get; }
        public Note[] Steps { get; }

        public Scale(Note root, ScaleType scaleType, bool enharmonic = false)
        {
            var s = scaleType.Steps.ToArray();
            Steps = new Note[s.Length + 1];
            Steps[0] = root;

            for (int i = 1; i < Steps.Length; i++)
            {
                Steps[i] = Steps[i - 1].Transpose(s[i - 1]);
            }

            if(enharmonic)
                EnharmonicSimplify();

            Name = $"{Steps[0]} {scaleType.Name}";
        }

        private void EnharmonicSimplify()
        {
            for (int i = 0; i < Steps.Length; i++)
            {
                var newNote = Steps[i].GetEnharmonicEquivalent();
                if (Math.Abs((int)newNote.Alteration) < Math.Abs((int)Steps[i].Alteration))
                    Steps[i] = newNote;
            }
        }

        public override string ToString()
        {
            return $"{Name} ({String.Join(", ", Steps.AsEnumerable())})";
        }
    }
}
