using System.Collections.ObjectModel;

using Model.Messenger.Contacts;
using Model.Messenger.Messages;
using Model.Messenger.Authentications;

namespace Model.Messenger.Chats
{
    public interface IChat
    {
        public string Name { get; }

        public byte[] Image { get; }

        public string Description { get; }

        public ObservableCollection<IMessage> Messages { get; }

        public ObservableCollection<IContact> Contacts { get; }

        public Task SendMessage(IMessage message, IAuthentication authentication);
    }
}