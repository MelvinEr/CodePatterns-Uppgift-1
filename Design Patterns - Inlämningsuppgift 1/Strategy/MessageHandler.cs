namespace Design_Patterns_Assignment
{
    internal class MessageHandler
    {
        public IMessage MessageType { get; set; }
        public void SendMessage(string message) {
            MessageType.SendMessage(message);
        }
    }
}