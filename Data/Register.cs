using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{

    public class Register
    {

        private string _Serial;

        public string Serial
        {
            get { return _Serial; }
            set { _Serial = value; }
        }

        public Register()
        {

        }
        public Register(string serial)
        {
            this.Serial = serial;
        }

        public string Insert(Register Serial)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Connection.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "insertar_serial";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDescription = new SqlParameter();
                ParDescription.ParameterName = "@serial";
                ParDescription.SqlDbType = SqlDbType.VarChar;
                ParDescription.Size = 50;
                ParDescription.Value = Serial.Serial;
                SqlCmd.Parameters.Add(ParDescription);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }

        public DataTable Mostrar()
            {
                DataTable DtResultado = new DataTable("Activacion");
                SqlConnection SqlCon = new SqlConnection();
                try
                {
                    SqlCon.ConnectionString = Connection.Cn;
                    SqlCommand SqlCmd = new SqlCommand();
                    SqlCmd.Connection = SqlCon;
                    SqlCmd.CommandText = "validar_activacion";
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                    SqlDat.Fill(DtResultado);

                }
                catch (Exception ex)
                {
                    DtResultado = null;
                }
                return DtResultado;

            }

        public DataTable ValidarSerial(Register Login)
        {
            DataTable DtResultado = new DataTable("Activacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "validar_serial";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@serial";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 50;
                ParPassword.Value = Login.Serial;
                SqlCmd.Parameters.Add(ParPassword);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
    }
}
