using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Contact
    {
        public string Nick { get; set; }

        public string Name { get; set; }

        public string Bio { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Contact() { }

        public Contact(string nick, string name, string bio, string email, string phone)
        {
            Nick = nick;
            Name = name;
            Bio = bio;
            Email = email;
            Phone = phone;
        }
    }
}