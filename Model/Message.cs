using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Message : IMessage
    {
        private string? _content;

        public object Content { get => _content; set => _content = value as string; }

        public Contact Contact { get; set; }

        public Message() { }

        public Message(string content, Contact contact)
        {
            Content = content;
            Contact = contact;
        }
    }
}
