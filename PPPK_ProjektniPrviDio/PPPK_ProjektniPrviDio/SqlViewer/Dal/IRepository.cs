using System.Collections.Generic;
using System.Data;
using Zadatak.Models;

namespace Zadatak.Dal
{
    interface IRepository
    {
        IEnumerable<Column> GetColumns(DBEntity entity);
        IEnumerable<Database> GetDatabases();
        IEnumerable<DBEntity> GetDBTables(Database database);
        void LogIn(string server, string username, string password);
        DataSet ExecuteSelectQuery(string dbName, string query);
        int ExecuteCommand(string dbName, string queryString);
    }
}