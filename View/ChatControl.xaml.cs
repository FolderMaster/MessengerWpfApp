using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Model;

namespace View
{
    public partial class ChatControl : UserControl
    {
        public IChat Chat
        {
            get => (IChat)GetValue(ChatProperty);
            set => SetValue(ChatProperty, value);
        }

        public Contact CurrentContact
        {
            get => (Contact)GetValue(CurrentContactProperty);
            set => SetValue(CurrentContactProperty, value);
        }

        private static DependencyProperty ChatProperty = DependencyProperty.Register(nameof(Chat),
            typeof(IChat), typeof(ChatControl));

        private static DependencyProperty CurrentContactProperty =
            DependencyProperty.Register(nameof(CurrentContact), typeof(Contact),
                typeof(ChatControl));

        public ChatControl()
        {
            InitializeComponent();
        }
    }
}