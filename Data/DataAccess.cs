using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class DataAccess
    {
        
    }

    public abstract class ConnectionSql
    {
        protected SqlConnection getConnection()
        {
            return new SqlConnection("Data Source=(local); Initial catalog = bd_Basic; Integrated Security=true");
        }
    }
}
