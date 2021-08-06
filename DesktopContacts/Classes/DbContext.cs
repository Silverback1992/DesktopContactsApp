using SQLite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopContacts.Classes
{
    static class DbContext
    {
        private static string _databaseName;
        private static string _folderPath;
        private static string _databasePath;
        private static List<Contact> _contacts;
        public static List<Contact> Contacts { get => _contacts; }

        static DbContext()
        {
            _databaseName = ConfigurationManager.AppSettings["DbName"];
            _folderPath = ConfigurationManager.AppSettings["DbFolderPath"];
            _databasePath = Path.Combine(_folderPath, _databaseName);
            ReadSQLite();
        }

        private static void ReadSQLite()
        {
            using (var ctx = new SQLiteConnection(_databasePath))
            {
                ctx.CreateTable<Contact>();
                _contacts = ctx.Table<Contact>().ToList();
            }
        }

        public static void Refresh() => ReadSQLite();

        public static void SortContactsAZ() => _contacts = _contacts.OrderBy(c => c.Name).ToList();

        public static void SortContactsZA() => _contacts = _contacts.OrderByDescending(c => c.Name).ToList();

        public static void InsertIntoSQLite(Contact c)
        {
            using (var ctx = new SQLiteConnection(_databasePath))
            {
                ctx.CreateTable<Contact>();
                ctx.Insert(c);
            }
        }

        public static void DeleteFromSQLite(Contact c)
        {
            using(var ctx = new SQLiteConnection(_databasePath))
            {
                ctx.CreateTable<Contact>();
                ctx.Delete(c);
            }
        }

        public static void UpdateSQLite(Contact c)
        {
            using(var ctx = new SQLiteConnection(_databasePath))
            {
                ctx.CreateTable<Contact>();
                ctx.Update(c);
            }
        }
    }
}
