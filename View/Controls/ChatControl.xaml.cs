using System.Windows;
using System.Windows.Controls;

using Model.Messenger.Chats;
using Model.Messenger.Contacts;

namespace View.Controls
{
    public partial class ChatControl : UserControl
    {
        public IChat Chat
        {
            get => (IChat)GetValue(ChatProperty);
            set => SetValue(ChatProperty, value);
        }

        public IContact CurrentContact
        {
            get => (IContact)GetValue(CurrentContactProperty);
            set => SetValue(CurrentContactProperty, value);
        }

        private static DependencyProperty ChatProperty = DependencyProperty.Register(nameof(Chat),
            typeof(IChat), typeof(ChatControl));

        private static DependencyProperty CurrentContactProperty =
            DependencyProperty.Register(nameof(CurrentContact), typeof(IContact),
                typeof(ChatControl));

        public ChatControl()
        {
            InitializeComponent();
        }
    }
}