using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperExplained
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var conn = new SqlConnection("soem connection string"))
            {
                conn.Open();
                var sql = "SELECT * FROM product where id = @id";
                var parameters = new {id = 1}; //<- Typically you see this inlined into the method below.  
                var products = conn.Query<Product>(sql, parameters);
                //  above is not so scary right?  <Product> is the type you expect Dapper to populate
                
                //  Above line is equivalent to below.
                //  var products = Dapper.Query<Product>(conn, sql, new {id = 1});

                var firstProduct = products.First(); 
                //Dapper.Query always returns a IEnumerable<T> so we're using System.Linq's method to get the first record returned.
            }
        }
    }
}
