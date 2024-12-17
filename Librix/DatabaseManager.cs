using System;

namespace Librix
{
    internal class DatabaseManager
    {
        private string usersDbConnectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\idkwtctfolder\Projects\Librix\Librix\data\users.mdf;Integrated Security=True";

        private string itemsDbConnectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\idkwtctfolder\Projects\Librix\Librix\data\items.mdf;Integrated Security=True";

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