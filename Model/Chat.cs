using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Chat : IChat
    {
        public string Name { get; set; }

        public ObservableCollection<IMessage> Messages { get; set; } = new();

        public ObservableCollection<Contact> Contacts { get; set; }

        public Chat() { }

        public Chat(string name, ObservableCollection<Contact> contacts)
        {
            Name = name;
            Contacts = contacts;
        }

        public Chat(string name, ObservableCollection<IMessage> messages,
            ObservableCollection<Contact> contacts)
        {
            Name = name;
            Messages = messages;
            Contacts = contacts;
        }
    }
}