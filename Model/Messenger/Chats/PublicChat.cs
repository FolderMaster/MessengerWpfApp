using Model.Messenger.Authentications;
using Model.Messenger.Contacts;
using Model.Messenger.Messages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Messenger.Chats
{
    public class PublicChat : IChat
    {
        public string Name { get; private set; }

        public byte[] Image { get; private set; }

        public string Description { get; private set; }

        public ObservableCollection<IMessage> Messages { get; private set; } = new();

        public ObservableCollection<IContact> Contacts { get; private set; } = new();

        public PublicChat(string name, byte[] image, string description)
        {

        }

        public Task SendMessage(IMessage message, IAuthentication authentication)
        {
            throw new NotImplementedException();
        }
    }
}