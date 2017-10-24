using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace DapperExplained
{
    public static class Dapper
    {
        public static IEnumerable<T> Query<T>(this IDbConnection conn, string sql, object parameters)
        {
            // Dapper would be implemented here.
            return null;//ignore the return null this is 
        }
    }
}