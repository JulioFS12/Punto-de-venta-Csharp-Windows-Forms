using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class DClient
    {
        //Variables
            private int _Idcliente;

            private string _Nombreya;

            private string _Tipo_Documento;

            private string _Num_Documento;


            private string _Direccion;

            private string _Telefono;

            private string _TextoBuscar;


            //Propiedades Métodos Setter and Getter

            public int Idcliente
            {
                get { return _Idcliente; }
                set { _Idcliente = value; }
            }

            public string Nombreya
            {
                get { return _Nombreya; }
                set { _Nombreya = value; }
            }

            public string Tipo_Documento
            {
                get { return _Tipo_Documento; }
                set { _Tipo_Documento = value; }
            }
            public string Num_Documento
            {
                get { return _Num_Documento; }
                set { _Num_Documento = value; }
            }

            public string Direccion
            {
                get { return _Direccion; }
                set { _Direccion = value; }
            }

            public string Telefono
            {
                get { return _Telefono; }
                set { _Telefono = value; }
            }

            public string TextoBuscar
            {
                get { return _TextoBuscar; }
                set { _TextoBuscar = value; }
            }

            //Constructores
            public DClient()
            {

            }
            public DClient(int idcliente, string nombreya, string tipo_documento, string num_documento, string direccion,
                string telefono,string textobuscar)
            {
                this.Idcliente = idcliente;
                this.Nombreya = nombreya;
                this.Tipo_Documento = tipo_documento;
                this.Num_Documento = num_documento;
                this.Direccion = direccion;
                this.Telefono = telefono;
                this.TextoBuscar = textobuscar;

            }

            //Métodos


            public string Insertar(DClient Cliente)
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
                    SqlCmd.CommandText = "insertar_cliente";
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter ParIdcliente = new SqlParameter();
                    ParIdcliente.ParameterName = "@idcliente";
                    ParIdcliente.SqlDbType = SqlDbType.Int;
                    ParIdcliente.Direction = ParameterDirection.Output;
                    SqlCmd.Parameters.Add(ParIdcliente);

                    SqlParameter ParNombreya = new SqlParameter();
                    ParNombreya.ParameterName = "@nombreya";
                    ParNombreya.SqlDbType = SqlDbType.VarChar;
                    ParNombreya.Size = 100;
                    ParNombreya.Value = Cliente.Nombreya;
                    SqlCmd.Parameters.Add(ParNombreya);

                    SqlParameter ParTipoDocumento = new SqlParameter();
                    ParTipoDocumento.ParameterName = "@tipo_documento";
                    ParTipoDocumento.SqlDbType = SqlDbType.VarChar;
                    ParTipoDocumento.Size = 50;
                    ParTipoDocumento.Value = Cliente.Tipo_Documento;
                    SqlCmd.Parameters.Add(ParTipoDocumento);

                    SqlParameter ParNum_Documento = new SqlParameter();
                    ParNum_Documento.ParameterName = "@num_documento";
                    ParNum_Documento.SqlDbType = SqlDbType.VarChar;
                    ParNum_Documento.Size = 50;
                    ParNum_Documento.Value = Cliente.Num_Documento;
                    SqlCmd.Parameters.Add(ParNum_Documento);

                    SqlParameter ParDireccion = new SqlParameter();
                    ParDireccion.ParameterName = "@direccion";
                    ParDireccion.SqlDbType = SqlDbType.VarChar;
                    ParDireccion.Size = 150;
                    ParDireccion.Value = Cliente.Direccion;
                    SqlCmd.Parameters.Add(ParDireccion);

                    SqlParameter ParTelefono = new SqlParameter();
                    ParTelefono.ParameterName = "@telefono";
                    ParTelefono.SqlDbType = SqlDbType.VarChar;
                    ParTelefono.Size = 50;
                    ParTelefono.Value = Cliente.Telefono;
                    SqlCmd.Parameters.Add(ParTelefono);

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

            //Método Editar
            public string Editar(DClient Cliente)
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
                    SqlCmd.CommandText = "editar_cliente";
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter ParIdcliente = new SqlParameter();
                    ParIdcliente.ParameterName = "@idcliente";
                    ParIdcliente.SqlDbType = SqlDbType.Int;
                    ParIdcliente.Value = Cliente.Idcliente;
                    SqlCmd.Parameters.Add(ParIdcliente);

                    SqlParameter ParNombreya = new SqlParameter();
                    ParNombreya.ParameterName = "@nombreya";
                    ParNombreya.SqlDbType = SqlDbType.VarChar;
                    ParNombreya.Size = 50;
                    ParNombreya.Value = Cliente.Nombreya;
                    SqlCmd.Parameters.Add(ParNombreya);

                    SqlParameter ParTipoDocumento = new SqlParameter();
                    ParTipoDocumento.ParameterName = "@tipo_documento";
                    ParTipoDocumento.SqlDbType = SqlDbType.VarChar;
                    ParTipoDocumento.Size = 50;
                    ParTipoDocumento.Value = Cliente.Tipo_Documento;
                    SqlCmd.Parameters.Add(ParTipoDocumento);

                    SqlParameter ParNum_Documento = new SqlParameter();
                    ParNum_Documento.ParameterName = "@num_documento";
                    ParNum_Documento.SqlDbType = SqlDbType.VarChar;
                    ParNum_Documento.Size = 50;
                    ParNum_Documento.Value = Cliente.Num_Documento;
                    SqlCmd.Parameters.Add(ParNum_Documento);

                    SqlParameter ParDireccion = new SqlParameter();
                    ParDireccion.ParameterName = "@direccion";
                    ParDireccion.SqlDbType = SqlDbType.VarChar;
                    ParDireccion.Size = 150;
                    ParDireccion.Value = Cliente.Direccion;
                    SqlCmd.Parameters.Add(ParDireccion);

                    SqlParameter ParTelefono = new SqlParameter();
                    ParTelefono.ParameterName = "@telefono";
                    ParTelefono.SqlDbType = SqlDbType.VarChar;
                    ParTelefono.Size = 50;
                    ParTelefono.Value = Cliente.Telefono;
                    SqlCmd.Parameters.Add(ParTelefono);

                    //Ejecutamos nuestro comando

                    rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Registro";


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

            //Método Eliminar
            public string Eliminar(DClient Cliente)
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
                    SqlCmd.CommandText = "eliminar_cliente";
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter ParIdcliente = new SqlParameter();
                    ParIdcliente.ParameterName = "@idcliente";
                    ParIdcliente.SqlDbType = SqlDbType.Int;
                    ParIdcliente.Value = Cliente.Idcliente;
                    SqlCmd.Parameters.Add(ParIdcliente);


                    //Ejecutamos nuestro comando

                    rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";


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

            //Método Mostrar
            public DataTable Mostrar()
            {
                DataTable DtResultado = new DataTable("cliente");
                SqlConnection SqlCon = new SqlConnection();
                try
                {
                    SqlCon.ConnectionString = Connection.Cn;
                    SqlCommand SqlCmd = new SqlCommand();
                    SqlCmd.Connection = SqlCon;
                    SqlCmd.CommandText = "mostrar_cliente";
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

            public DataTable BuscarNum_Documento(DClient Cliente)
            {
                DataTable DtResultado = new DataTable("cliente");
                SqlConnection SqlCon = new SqlConnection();
                try
                {
                    SqlCon.ConnectionString = Connection.Cn;
                    SqlCommand SqlCmd = new SqlCommand();
                    SqlCmd.Connection = SqlCon;
                    SqlCmd.CommandText = "buscar_cliente_num_documento";
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter ParTextoBuscar = new SqlParameter();
                    ParTextoBuscar.ParameterName = "@textobuscar";
                    ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                    ParTextoBuscar.Size = 100;
                    ParTextoBuscar.Value = Cliente.TextoBuscar;
                    SqlCmd.Parameters.Add(ParTextoBuscar);

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
