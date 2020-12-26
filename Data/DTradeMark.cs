using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class DTradeMark
    {
        private int _IdTradeMark;
        private string _Name;
        private string _Description;
        private string _TextSearch;

        public int IdTradeMark
        {
            get { return _IdTradeMark; }
            set { _IdTradeMark = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public string TextSearch
        {
            get { return _TextSearch; }
            set { _TextSearch = value; }
        }

        //Constructor Vacío
        public DTradeMark()
        {

        }
        //Constructor con parámetros
        public DTradeMark(int idtrademark, string name, string description, string textsearch)
        {
            this.IdTradeMark = idtrademark;
            this.Name = name;
            this.Description = description;
            this.TextSearch = textsearch;
        }


        //Método Insertar

        public string Insert(DTradeMark Trademark)
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
                SqlCmd.CommandText = "insertar_marca";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdtrademark = new SqlParameter();
                ParIdtrademark.ParameterName = "@id_marca";
                ParIdtrademark.SqlDbType = SqlDbType.Int;
                ParIdtrademark.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdtrademark);

                SqlParameter ParName = new SqlParameter();
                ParName.ParameterName = "@nombre";
                ParName.SqlDbType = SqlDbType.VarChar;
                ParName.Size = 100;
                ParName.Value = Trademark.Name;
                SqlCmd.Parameters.Add(ParName);

                SqlParameter ParDescription = new SqlParameter();
                ParDescription.ParameterName = "@descripcion";
                ParDescription.SqlDbType = SqlDbType.VarChar;
                ParDescription.Size = 256;
                ParDescription.Value = Trademark.Description;
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

        //Método Editar
        public string Edit(DTradeMark Trademark)
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
                SqlCmd.CommandText = "editar_marca";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdpresentations = new SqlParameter();
                ParIdpresentations.ParameterName = "@id_marca";
                ParIdpresentations.SqlDbType = SqlDbType.Int;
                ParIdpresentations.Value = Trademark.IdTradeMark;
                SqlCmd.Parameters.Add(ParIdpresentations);

                SqlParameter ParName = new SqlParameter();
                ParName.ParameterName = "@nombre";
                ParName.SqlDbType = SqlDbType.VarChar;
                ParName.Size = 100;
                ParName.Value = Trademark.Name;
                SqlCmd.Parameters.Add(ParName);

                SqlParameter ParDescription = new SqlParameter();
                ParDescription.ParameterName = "@descripcion";
                ParDescription.SqlDbType = SqlDbType.VarChar;
                ParDescription.Size = 256;
                ParDescription.Value = Trademark.Description;
                SqlCmd.Parameters.Add(ParDescription);

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
        public string Delete(DTradeMark Trademark)
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
                SqlCmd.CommandText = "eliminar_marca";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdTradeMark = new SqlParameter();
                ParIdTradeMark.ParameterName = "@id_marca";
                ParIdTradeMark.SqlDbType = SqlDbType.Int;
                ParIdTradeMark.Value = Trademark.IdTradeMark;
                SqlCmd.Parameters.Add(ParIdTradeMark);


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
        public DataTable Show()
        {
            DataTable DtResultado = new DataTable("marca");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_marca";
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


        //Método BuscarNombre
        public DataTable Search(DTradeMark Trademark)
        {
            DataTable DtResultado = new DataTable("marca");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Connection.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "buscar_marca";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextSearch = new SqlParameter();
                ParTextSearch.ParameterName = "@textobuscar";
                ParTextSearch.SqlDbType = SqlDbType.VarChar;
                ParTextSearch.Size = 50;
                ParTextSearch.Value = Trademark.TextSearch;
                SqlCmd.Parameters.Add(ParTextSearch);

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
