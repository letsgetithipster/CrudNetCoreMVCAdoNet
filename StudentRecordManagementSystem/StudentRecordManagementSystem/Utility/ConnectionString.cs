using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRecordManagementSystem.Utility
{
    public static class ConnectionString
    {
        private static string connectionName = "Data Source=;Initial Catalog=;User ID=;Password=;";

        public static string CName
        {
            get => connectionName;
        }
    }
}
