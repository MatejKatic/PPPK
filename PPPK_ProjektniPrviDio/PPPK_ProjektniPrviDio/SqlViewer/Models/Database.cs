using System;
using System.Collections.Generic;
using Zadatak.Dal;

namespace Zadatak.Models
{
    class Database
    {
        private readonly Lazy<IEnumerable<DBEntity>> tables;

        public Database()
        {
            tables = new Lazy<IEnumerable<DBEntity>>(() => RepositoryFactory.GetRepository().GetDBTables(this));
        }
        public IList<DBEntity> Tables
        {
            get => new List<DBEntity>(tables.Value);
        }

        public string Name { get; set; }
        public override string ToString() => Name;
    }
}
