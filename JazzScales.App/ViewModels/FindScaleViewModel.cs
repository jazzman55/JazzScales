using Scales;
using Scales.Model;
using Scales.Theory;

namespace JazzScales.App.ViewModels
{
    public class FindScaleViewModel
    {
        private readonly MessageViewModel _messageVm;

        public FindScaleViewModel(MessageViewModel messageVm)
        {
            _messageVm = messageVm;
        }

        public IEnumerable<Chord> AllChords => Chords.All;

        public IEnumerable<string> AllNotes => Enum.GetValues<NoteName>().Select(Formatter.GetNoteString);

        public IEnumerable<string> AllAlterations => Diatonic.GetAllowedAlterations(Formatter.ParseNote(SelectedRoot).Root).Select(Formatter.GetAlterationString);

        public IEnumerable<string> SingleAlterations => Diatonic.GetAllowedAlterations(Formatter.ParseNote(TransposingRoot).Root).Select(Formatter.GetAlterationString);

        public string SelectedRoot { get; set; } = Formatter.FormatNote(new Note(NoteName.C));
        public string SelectedAlteration { get; set; }
        public string SelectedChord { get; set; }

        public string TransposingRoot { get; set; } = Formatter.FormatNote(new Note(NoteName.C));
        public string TransposingAlteration { get; set; }

        public string FormatChord(Chord chord)
        {
            return $"{SelectedRoot}{SelectedAlteration} {chord.Kind}";
        }

        public IEnumerable<Scale> Scales
        {
            get
            {
                _messageVm.HideMessage();
                try
                {
                    return String.IsNullOrEmpty(SelectedChord)
                        ? Array.Empty<Scale>()
                        : ChordScales.GetScalesForChord(
                            GetRoot(), AllChords.Single(c => c.Kind == SelectedChord), Enharmonic);

                }
                catch (Exception e)
                {
                    _messageVm.DisplayMessage("Sorry! Error occurred.", MessageTypeEnum.Danger);
                }

                return Array.Empty<Scale>();
            }
        }

        public bool Enharmonic { get; set; } = true;

        private Note GetRoot()
        {
            var scaleRoot = Formatter.ParseNote($"{SelectedRoot}{SelectedAlteration}");
            var transposition = Formatter.ParseNote($"{TransposingRoot}{TransposingAlteration}")
                .GetInterval(new Note(NoteName.C));
            return scaleRoot.Transpose(transposition);
        }


    }
}
