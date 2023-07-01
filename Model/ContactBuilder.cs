using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Model
{
    public class ContactBuilder
    {
        public Contact Contact { get; set; }

        public Contact NewContact { get; set; }

        public IChat Chat { get; set; }

        public ContactBuilder(Contact contact) => Contact = contact;

        public ContactBuilder BuildContact(string nick, string name, string bio, string email,
            string phone)
        {
            NewContact = new(nick, name, bio, email, phone);
            return this;
        }

        public ContactBuilder BuildChat()
        {
            Chat = new Chat(NewContact.Nick, new ObservableCollection<Contact>() { Contact, NewContact });
            Chat.Messages.Add(new Message("Hi!", Contact));
            Chat.Messages.Add(new Message("Hi!", NewContact));
            return this;
        }
    }
}
