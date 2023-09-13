using CommunityToolkit.Mvvm.ComponentModel;
using Model;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.Messenger.Chats;
using Model.Messenger.Contacts;

namespace ViewModel.VMs
{
    public partial class MainVM: ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<IChat> chats = new();

        [ObservableProperty]
        private IChat? selectedChat = null;

        [ObservableProperty]
        private IContact? currentContact = null;

        public MainVM()
        {
            CurrentContact = new User("Darkonge", null, "Go to the hell!");
        }
    }
}