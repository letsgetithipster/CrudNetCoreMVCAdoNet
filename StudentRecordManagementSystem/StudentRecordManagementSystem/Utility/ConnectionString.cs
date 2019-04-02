using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRecordManagementSystem.Utility
{
    public static class ConnectionString
    {
        private static string connectionName = "Data Source=172.18.32.1;Initial Catalog=CrudCoreAdo;User ID=sa;Password=Dev*2019;";

        public static string CName
        {
            get => connectionName;
        }
    }
}
