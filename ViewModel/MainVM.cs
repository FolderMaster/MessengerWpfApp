using CommunityToolkit.Mvvm.ComponentModel;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public partial class MainVM: ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<IChat> chats = new();

        [ObservableProperty]
        private IChat? selectedChat = null;

        [ObservableProperty]
        private Contact? currentContact = null;

        public MainVM()
        {
            CurrentContact = new Contact("Darkonge", "Nikto", "Go to the hell!", "", "");
            var builder = new ContactBuilder(CurrentContact);
            Chats.Add(builder.BuildContact("Ulitka", "Maria", "()", "", "").BuildChat().Chat);
            Chats.Add(builder.BuildContact("Fedor", "Ogurec", "-_-", "", "").BuildChat().Chat);
            Chats.Add(builder.BuildContact("Ahinea", "Serega", "*", "", "").BuildChat().Chat);
            Chats.Add(builder.BuildContact("Tim27", "Kalishe", "+-+", "", "").BuildChat().Chat);
        }
    }
}