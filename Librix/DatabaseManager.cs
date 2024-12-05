using System;

namespace Librix
{
    internal class DatabaseManager
    {
        private string adminDbConnectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Luna\Desktop\New folder\Librix\Librix\data\admin.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=True";

        private string itemsDbConnectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Luna\Desktop\New folder\Librix\Librix\data\items.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=True";

        public string GetAdminDbConnectionString()
        {
            return adminDbConnectionString;
        }

        public string GetItemsDbConnectionString()
        {
            return itemsDbConnectionString;
        }
    }
}
