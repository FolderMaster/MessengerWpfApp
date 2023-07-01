using System.Collections.ObjectModel;

namespace Model
{
    public interface IChat
    {
        public string Name { get; set; }

        public ObservableCollection<IMessage> Messages { get; set; }

        public ObservableCollection<Contact> Contacts { get; set; }
    }
}