using Model.Messenger.Authentications;
using Model.Messenger.Chats;

namespace Model.Messenger.Contacts
{
    public class Bot : IContact
    {
        public string Nick { get; private set; }

        public byte[] Avatar { get; private set; }

        public string Bio { get; private set; }

        public ContactStatus Status { get; private set; }

        public Bot(string nick, byte[] avatar, string bio)
        {
            Nick = nick;
            Avatar = avatar;
            Bio = bio;
        }

        public IChat? GetPrivateChat(IAuthentication authentication)
        {
            throw new NotImplementedException();
        }
    }
}
