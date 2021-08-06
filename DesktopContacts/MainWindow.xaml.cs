using DesktopContacts.Classes;
using System;
using System.Collections.Generic;
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

namespace DesktopContacts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void createNewContactButton_Click(object sender, RoutedEventArgs e)
        {
            var newContactWindow = new NewAndUpdateContactWindow();
            newContactWindow.Show();
            Close();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e) => Close();

        private void readContactsButton_Click(object sender, RoutedEventArgs e)
        {
            var contactsWindow = new ContactsWindow();
            contactsWindow.Show();
            Close();
        }
    }
}
