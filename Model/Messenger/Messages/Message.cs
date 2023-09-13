using Model.Messenger.Contacts;

namespace Model.Messenger.Messages
{
    public class Message : IMessage
    {
        private string? _content;

        public object Content { get => _content; set => _content = value as string; }

        public IContact Contact { get; set; }

        public Message(string content, IContact contact)
        {
            Content = content;
            Contact = contact;
        }
    }
}