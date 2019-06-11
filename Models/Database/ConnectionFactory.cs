using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace WebComponent.Models.Database
{
    public class  ConnectionFactory
    {
        public  IDbConnection CreateDBConnection()
        {
            string connString = System.Environment.CurrentDirectory;
            return new SQLiteConnection($"Data Source={connString}\\BIMComponent.db;");
        }
    }
}
