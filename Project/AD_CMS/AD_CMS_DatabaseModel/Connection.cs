using System;

namespace AD_CMS
{
    public class Connection
    {
        public static string getConnectionString()
        {
            return @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\MasterDatabase.mdf;Integrated Security=True;User Instance=True";
        }
    }
}
