using System.Collections.ObjectModel;

using Model.Messenger.Authentications;
using Model.Messenger.Contacts;
using Model.Messenger.Messages;

namespace Model.Messenger.Chats
{
    public class PrivateChat : IChat
    {
        public string Name { get; private set; }

        public byte[] Image { get; private set; }

        public string Description { get; private set; }

        public ObservableCollection<IMessage> Messages { get; private set; } = new();

        public ObservableCollection<IContact> Contacts { get; private set; } = new();

        public PrivateChat(IContact contact1, IContact contact2)
        {

        }

        public Task SendMessage(IMessage message, IAuthentication authentication)
        {
            throw new NotImplementedException();
        }
    }
}
