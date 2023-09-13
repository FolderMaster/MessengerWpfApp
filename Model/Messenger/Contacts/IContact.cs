using Model.Messenger.Authentications;
using Model.Messenger.Chats;

namespace Model.Messenger.Contacts
{
    public interface IContact
    {
        public string Nick { get; }

        public byte[] Avatar { get; }

        public string Bio { get; }

        public ContactStatus Status { get; }

        public IChat? GetPrivateChat(IAuthentication authentication);
    }
}