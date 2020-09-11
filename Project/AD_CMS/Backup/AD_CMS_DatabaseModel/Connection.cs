using System;

namespace AD_CMS
{
    public class Connection
    {
        public static string getConnectionString()
        {
            return @"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\Project 2018\My Project\PROJECT20018\AD_CMS\AD_CMS\MasterDatabase.mdf;Integrated Security=True;User Instance=True";
        }
    }
}
