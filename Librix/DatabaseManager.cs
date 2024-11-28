using System;

namespace Librix
{
    internal class DatabaseManager
    {
        private string adminDbConnectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\idkwtctfolder\Projects\Librix\Librix\data\admin.mdf;Integrated Security=True;Connect Timeout=30";

        private string itemsDbConnectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\idkwtctfolder\Projects\Librix\Librix\data\items.mdf;Integrated Security=True;Connect Timeout=30";

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
