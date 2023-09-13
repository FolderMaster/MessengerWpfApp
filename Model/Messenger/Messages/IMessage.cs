using Model.Messenger.Contacts;

namespace Model.Messenger.Messages
{
    public interface IMessage
    {
        public object Content { get; set; }

        public IContact Contact { get; set; }
    }
}