using Microsoft.SqlServer.TransactSql.ScriptDom;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak0102.Dal
{
    public static class SqlParser
    {
        public static bool IsSQLQueryValid(string sql, out List<string> errors, out TSqlTokenType keyword)
        {
            TSql140Parser parser = new TSql140Parser(false);
            TSqlFragment fragment;
            IList<ParseError> parseErrors;
            errors = new List<string>();

            using (TextReader reader = new StringReader(sql))
            {
                fragment = parser.Parse(reader, out parseErrors);
                keyword = fragment.ScriptTokenStream.First().TokenType;

                if (parseErrors != null && parseErrors.Count > 0)
                {
                    errors = parseErrors.Select(e => e.Message).ToList();
                    return false;
                }
            }
            return true;
        }
    }
}
