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
using System.Windows.Shapes;

namespace DesktopContacts
{
    /// <summary>
    /// Interaction logic for ContactsWindow.xaml
    /// </summary>
    public partial class ContactsWindow : Window
    {
        public ContactsWindow()
        {
            InitializeComponent();
            if(DbContext.Contacts != null)
                contactsListView.ItemsSource = DbContext.Contacts;
            updateContactButton.IsEnabled = false;
            deleteContactButton.IsEnabled = false;
            CompositionTarget.Rendering += UpdateUpdateAndDeleteButtons;
        }

        private void UpdateUpdateAndDeleteButtons(object sender, EventArgs e)
        {
            if(contactsListView.SelectedItems.Count > 0)
            {
                updateContactButton.IsEnabled = true;
                deleteContactButton.IsEnabled = true;
            }
            else
            {
                updateContactButton.IsEnabled = false;
                deleteContactButton.IsEnabled = false;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(this.IsLoaded)
            {
                var searchTextBox = (TextBox)sender;
                var filteredContactList = DbContext.Contacts.Where(c => c.Name.ToLowerInvariant().Contains(searchTextBox.Text.ToLowerInvariant())).ToList();
                contactsListView.ItemsSource = filteredContactList;
            }
        }

        private void TextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            ((TextBox)sender).Text = "";
        }

        private void sortAZButton_Click(object sender, RoutedEventArgs e)
        {
            DbContext.SortContactsAZ();
            contactsListView.ItemsSource = DbContext.Contacts;
            searchTextBox.Text = "";
        }

        private void sortZAButton_Click(object sender, RoutedEventArgs e)
        {
            DbContext.SortContactsZA();
            contactsListView.ItemsSource = DbContext.Contacts;
            searchTextBox.Text = "";
        }

        private void dbRefreshButton_Click(object sender, RoutedEventArgs e)
        {
            DbContext.Refresh();
            contactsListView.ItemsSource = DbContext.Contacts;
            searchTextBox.Text = "";
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void updateContactButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedContact = (Contact)contactsListView.SelectedItem;

            if (selectedContact != null)
            {
                var updateContactWindow = new NewAndUpdateContactWindow(selectedContact);
                updateContactWindow.ShowDialog();
                DbContext.Refresh();
                contactsListView.ItemsSource = DbContext.Contacts;
            }
        }

        private void deleteContactButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedContact = (Contact)contactsListView.SelectedItem;

            if (selectedContact != null)
            {
                DbContext.DeleteFromSQLite(selectedContact);
                DbContext.Refresh();
                contactsListView.ItemsSource = DbContext.Contacts;
            }
        }
    }
}
