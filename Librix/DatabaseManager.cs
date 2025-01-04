using System;

namespace Librix
{
    internal class DatabaseManager
    {
        private string usersDbConnectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Luna\Desktop\New folder\Librix\Librix\data\users.mdf"";Integrated Security=True;Connect Timeout=30";

        private string itemsDbConnectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Luna\Desktop\New folder\Librix\Librix\data\items.mdf"";Integrated Security=True;Connect Timeout=30";

        public string GetUsersDbConnectionString()
        {
            return usersDbConnectionString;
        }

        public string GetItemsDbConnectionString()
        {
            return itemsDbConnectionString;
        }
    }
}