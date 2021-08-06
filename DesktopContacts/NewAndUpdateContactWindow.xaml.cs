using DesktopContacts.Classes;
using SQLite;
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
    /// Interaction logic for NewContactWindow.xaml
    /// </summary>
    public partial class NewAndUpdateContactWindow : Window
    {
        private Contact _contact;

        public NewAndUpdateContactWindow(Contact c = null)
        {
            InitializeComponent();

            if (c != null)
            {
                nameTextbox.Text = c.Name;
                emailTextbox.Text = c.Email;
                phoneTextbox.Text = c.Phone;
                saveButton.IsEnabled = false;
                _contact = c;
            }
            else
                updateButton.IsEnabled = false;
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            var contact = new Contact()
            {
                Name = nameTextbox.Text,
                Email = emailTextbox.Text,
                Phone = phoneTextbox.Text
            };

            DbContext.InsertIntoSQLite(contact);

            nameTextbox.Clear();
            emailTextbox.Clear();
            phoneTextbox.Clear();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            if(_contact == null)
            {
                var mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            else
            {
                Close();
            }
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            _contact.Name = nameTextbox.Text;
            _contact.Email = emailTextbox.Text;
            _contact.Phone = phoneTextbox.Text;

            DbContext.UpdateSQLite(_contact);
            Close();
        }
    }
}
