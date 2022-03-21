using Scales;
using Scales.Model;
using Scales.Theory;

namespace JazzScales.App.ViewModels
{
    public class ScalesViewModel
    {
        private readonly MessageViewModel _messageVm;

        public ScalesViewModel(MessageViewModel messageVm)
        {
            _messageVm = messageVm;
        }

        public IEnumerable<string> AllNotes => Enum.GetValues<NoteName>().Select(Formatter.GetNoteString);

        public IEnumerable<string> AllAlterations => Diatonic.GetAllowedAlterations(Formatter.ParseNote(SelectedRoot).Root).Select(Formatter.GetAlterationString);

        public IEnumerable<ScaleType> AllScales => ScaleTypes.All;

        public string SelectedRoot { get; set; } = Formatter.FormatNote(new Note(NoteName.C));
        public string SelectedAlteration { get; set; }

        public string SelectedScale { get; set; }
        public bool Enharmonic { get; set; } = true;

        public string GetScale()
        {
            _messageVm.HideMessage();
            try
            {
                return String.IsNullOrEmpty(SelectedScale) ? String.Empty :
                    new Scale(Formatter.ParseNote($"{SelectedRoot}{SelectedAlteration}"),
                            AllScales.Single(c => c.Name == SelectedScale),
                            Enharmonic)
                        .ToString();

            }
            catch (Exception e)
            {
                _messageVm.DisplayMessage("Sorry! Error occurred.", MessageTypeEnum.Danger);
            }
            return String.Empty;
        }
    }
}
