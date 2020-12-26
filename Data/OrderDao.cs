using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Data
{
    public class OrderDao : ConnectionSql
    {
        public DataTable getSalesOrder(DateTime fromDate, DateTime toDate)
        {
            using (var connection = getConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select v.Fecha, d.Nombre, d.[Precio Unitario], d.[Cantidad], d.Descuento, 
                        d.[Precio Total de Producto]
                        from detalle_venta d
                        inner join venta v on d.[Id Venta] = v.[Id Venta]
                        order by d.[Id Venta] asc";
                    command.Parameters.Add("@fromDate", SqlDbType.Date).Value = fromDate;
                    command.Parameters.Add("@toDate", SqlDbType.Date).Value = toDate;
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();

                    return table;
                }
            }
        }
    }
}
