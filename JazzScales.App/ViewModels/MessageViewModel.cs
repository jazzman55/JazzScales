namespace JazzScales.App.ViewModels
{
    public class MessageViewModel
    {
        public event EventHandler StateChanged;
        public string MessageText { get; private set; }
        public MessageTypeEnum MessageType { get; private set; }

        public void DisplayMessage(string text, MessageTypeEnum type)
        {
            MessageText = text;
            MessageType = type;
            StateChanged?.Invoke(this, EventArgs.Empty);
        }

        public void HideMessage()
        {
            MessageText = null;
            StateChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
